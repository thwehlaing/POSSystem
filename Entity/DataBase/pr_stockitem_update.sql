 BEGIN TRY 
 Drop Procedure [dbo].[pr_stockitem_update]
END try
BEGIN CATCH END CATCH 
/****** Object:  StoredProcedure [dbo].[pr_stockitem_update]    Script Date: 2023/02/19 17:22:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[pr_stockitem_update]
	-- Add the parameters for the stored procedure here
	@ItemCD	varchar(12),	
	@ItemName	nvarchar(100),
	@UOMCD	varchar(3),
	@Qty int,
	@LastSalePrice money,
	@BarCode varchar(50),
	@ReorderQty int,
	@Status	varchar(10),
	@UpdatedUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Declare @SysDatetime Datetime=GetDate()
    -- Insert statements for procedure here
	update StockItem Set ItemName=@ItemName,UOMCD=@UOMCD,Qty=@Qty,LastSalePrice=@LastSalePrice,
					BarCode=@BarCode,ReorderQty=@ReorderQty,Status=@Status,UpdatedDate=@SysDatetime,UpdatedUser=@UpdatedUser
					where ItemCD=@ItemCD

END
