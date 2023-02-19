BEGIN TRY 
 Drop Procedure [dbo].[pr_stockitem_insert]
END try
BEGIN CATCH END CATCH 
/****** Object:  StoredProcedure [dbo].[pr_stockitem_insert]    Script Date: 2023/02/19 17:14:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[pr_stockitem_insert]
	-- Add the parameters for the stored procedure here
	@SubCode varchar(10),
	@ItemName	nvarchar(100),
	@UOMCD	varchar(3),
	@Qty int,
	@LastSalePrice money,
	@BarCode varchar(50),
	@ReorderQty int,
	@Status	varchar(10),
	@CreatedUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Declare @SysDatetime Datetime=GetDate()
	Declare @maxitemcd varchar(12)
	Exec pr_CounterType_GetNewID
		@CounterKey = 4, 
        @NewID = @maxitemcd OUTPUT
    -- Insert statements for procedure here
	insert into StockItem(ItemCD,SubCode,ItemName,UOMCD,Qty,LastSalePrice,BarCode,ReorderQty,Status,CreatedDate,CreatedUser)
	values(@maxitemcd,@SubCode,@ItemName,@UOMCD,@Qty,@LastSalePrice,@BarCode,@ReorderQty,@Status,@SysDatetime,@CreatedUser)
END
