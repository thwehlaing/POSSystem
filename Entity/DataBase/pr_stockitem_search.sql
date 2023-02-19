BEGIN TRY 
 Drop Procedure [dbo].[pr_stockitem_search]
END try
BEGIN CATCH END CATCH 
/****** Object:  StoredProcedure [dbo].[pr_stockitem_search]    Script Date: 2023/02/19 17:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[pr_stockitem_search]
	-- Add the parameters for the stored procedure here
	@SubCode varchar(10),
	@ItemName nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select ItemCD,sc.SubName,ItemName,Qty,UOM.*,LastSalePrice,BarCode,ReorderQty from StockItem st inner join SubCategory sc on st.SubCode=sc.SubCode
	inner join UOM on st.UOMCD=UOM.UOMCD where st.SubCode=@SubCode and (@ItemName is null or ItemName like @ItemName+'%') and st.Status='1'
END
