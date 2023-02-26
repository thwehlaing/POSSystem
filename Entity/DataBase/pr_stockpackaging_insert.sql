BEGIN TRY 
 Drop Procedure [dbo].[pr_stockpackaging_insert]
END try
BEGIN CATCH END CATCH 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_stockpackaging_insert] 
	-- Add the parameters for the stored procedure here
	@ItemCD varchar(12),
	@PackTypeCode varchar(10),
	@Qty int,
	@CreatedUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into StockPackaging(ItemCD,PackTypeCode,Qty,CreatedDate,CreatedUser) values(@ItemCD,@PackTypeCode,@Qty,GETDATE(),@CreatedUser)
END
GO
