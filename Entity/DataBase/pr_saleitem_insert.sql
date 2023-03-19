BEGIN TRY 
 Drop function [dbo].[pr_saleitem_insert]
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
CREATE PROCEDURE [dbo].[pr_saleitem_insert]
	-- Add the parameters for the stored procedure here
	@ItemCD varchar(12),
	@CashSaleCD int,
	@GoodSaleCD int,
	@SaleDate datetime,
	@Qty int,
	@UOMCD varchar(3),
	@Price money,
	@CreatedUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	BEGIN TRAN
	BEGIN TRY

		-- Insert statements for procedure here
		Declare @OpenQty int
		Declare @OpenAmt money
		Declare @saleno varchar(20)
		Exec pr_CounterType_GetNewID
				@CounterKey = 6, 
				@Type='Trans',
				@NewID = @saleno OUTPUT

		--save data into SaleItem
		insert into SaleItem(SaleNo,ItemCD,CashSaleCD,GoodSaleCD,SaleDate,Qty,UOMCD,Price,CreatedUser,CreatedDate) 
		values(@saleno,@ItemCD,@CashSaleCD,@GoodSaleCD,@SaleDate,@Qty,@UOMCD,@Price,@CreatedUser,GETDATE())

		Set @OpenQty=(Select CloseQty from TransactionLedger where ItemCD=@ItemCD and LedgerDate=(Select MAX(LedgerDate) from TransactionLedger where ItemCD=@ItemCD))

		Declare @tlgno varchar(20)
		Exec pr_CounterType_GetNewID
				@CounterKey = 8, 
				@Type='Trans',
				@NewID = @tlgno OUTPUT

		--save into TransactionLedger
		insert into TransactionLedger(LedgerNo,ItemCD,OpenQty,SaleQty,CloseQty,TransactionType,LedgerDate,CreatedUser,CreatedDate) 
			values(@tlgno,@ItemCD,@OpenQty,@Qty,(@OpenQty+@Qty),'Sale',@SaleDate,@CreatedUser,GETDATE())
        
		Set @OpenAmt=(Select CloseAmt from CashLedger where ItemCD=@ItemCD and LedgerDate=(Select MAX(LedgerDate) from CashLedger where ItemCD=@ItemCD))

        Declare @clgno varchar(20)
		Exec pr_CounterType_GetNewID
				@CounterKey = 9, 
				@Type='Trans',
				@NewID = @clgno OUTPUT

       --save into CashLedger
		insert into CashLedger(CashLedgerNo,ItemCD,LedgerType,OpenAmt,PurchaseAmt,SaleAmt,CloseAmt,LedgerDate,CreatedUser,CreatedDate) 
			values(@clgno,@ItemCD,'Sale',@OpenAmt,0,@Price,(@OpenAmt+@Price),@SaleDate,@CreatedUser,GETDATE())

		COMMIT TRANSACTION

	END TRY	
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END
