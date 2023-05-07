BEGIN TRY 
 Drop Procedure [dbo].[purchaseitem_create]
END try
BEGIN CATCH END CATCH 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[purchaseitem_create]
	-- Add the parameters for the stored procedure here
	@GrandTotal money,
	@SupplierCD varchar(10),
	@PurchaseDate datetime,
	@PurchaseItemTable [dbo].[PurchaseItemType] ReadOnly, 
	@CreatedUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	    Declare @ItemCD varchar(12)
		Declare @PackTypeCode varchar(10)
		Declare @UOMQty int
		Declare @UOMPrice money
		Declare @PackQty int
		Declare @PackPrice money

		Declare @OpenQty int=0
		Declare @OpenAmt money=0
		Declare @pno varchar(20)
		Exec pr_CounterType_GetNewID
				@CounterKey = 7, 
				@Type='Trans',
				@NewID = @pno OUTPUT

		--save data into Purchase
		INSERT INTO Purchase(PurchaseNo,SupplierCD,PurchaseDate,TotalAmt,CreatedUser,CreatedDate) 
		VALUES(@pno,@SupplierCD,@PurchaseDate,@GrandTotal,@CreatedUser,GETDATE())

		DECLARE CURSOR_TEST CURSOR FOR
		SELECT * FROM   @PurchaseItemTable

		OPEN CURSOR_TEST 
		FETCH NEXT FROM CURSOR_TEST INTO @ItemCD,@PackTypeCode,@UOMQty,@UOMPrice,@PackQty,@PackPrice
		WHILE @@FETCH_STATUS =0 
		BEGIN 

		--save data into PurchaseItem
		INSERT INTO PurchaseItem(PurchaseNo,ItemCD,PackTypeCode,UOMQty,UOMPrice,PackQty,PackPrice,CreatedDate,CreatedUser)
		VALUES(@pno,@ItemCD,@PackTypeCode,@UOMQty,@UOMPrice,@PackQty,@PackPrice,@CreatedUser,GETDATE())

		--Save StockItem
		UPDATE StockItem set Qty=Qty+@UOMQty,UpdatedDate=GETDATE(),UpdatedUser=@CreatedUser WHERE ItemCD=@ItemCD 


		--Save StockPackaging
		UPDATE StockPackaging set PackQty=PackQty+@PackQty,UpdatedDate=GETDATE(),UpdatedUser=@CreatedUser WHERE ItemCD=@ItemCD and PackTypeCode=@PackTypeCode

		IF Exists(Select CloseQty from TransactionLedger where ItemCD=@ItemCD and LedgerDate=(Select MAX(LedgerDate) from TransactionLedger where ItemCD=@ItemCD))
		BEGIN
			Set @OpenQty=(Select CloseQty from TransactionLedger where ItemCD=@ItemCD and LedgerDate=(Select MAX(LedgerDate) from TransactionLedger where ItemCD=@ItemCD))
		END


		Declare @tlgno varchar(20)
		Exec pr_CounterType_GetNewID
				@CounterKey = 8, 
				@Type='Trans',
				@NewID = @tlgno OUTPUT

		--save into TransactionLedger
		insert into TransactionLedger(LedgerNo,ItemCD,OpenQty,PurchaseQty,CloseQty,TransactionType,LedgerDate,CreatedUser,CreatedDate) 
			values(@tlgno,@ItemCD,@OpenQty,@UOMQty,(@OpenQty+@UOMQty),'Purchase',@PurchaseDate,@CreatedUser,GETDATE())
        
		IF Exists(Select CloseAmt from CashLedger where ItemCD=@ItemCD and LedgerDate=(Select MAX(LedgerDate) from CashLedger where ItemCD=@ItemCD))
		BEGIN
			Set @OpenAmt=(Select CloseAmt from CashLedger where ItemCD=@ItemCD and LedgerDate=(Select MAX(LedgerDate) from CashLedger where ItemCD=@ItemCD))
		END		

        Declare @clgno varchar(20)
		Exec pr_CounterType_GetNewID
				@CounterKey = 9, 
				@Type='Trans',
				@NewID = @clgno OUTPUT

       --save into CashLedger
		insert into CashLedger(CashLedgerNo,ItemCD,LedgerType,OpenAmt,PurchaseAmt,SaleAmt,CloseAmt,LedgerDate,CreatedUser,CreatedDate) 
			values(@clgno,@ItemCD,'Purchase',@OpenAmt,@UOMPrice,0,(@OpenAmt+@UOMPrice),@PurchaseDate,@CreatedUser,GETDATE())
		FETCH NEXT FROM CURSOR_TEST INTO @ItemCD,@PackTypeCode,@UOMQty,@UOMPrice,@PackQty,@PackPrice

		END
CLOSE CURSOR_TEST
DEALLOCATE CURSOR_TEST
END
