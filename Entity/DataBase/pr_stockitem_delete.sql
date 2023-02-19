BEGIN TRY 
 Drop Procedure [dbo].[pr_stockitem_delete]
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
CREATE PROCEDURE [dbo].[pr_stockitem_delete] 
	-- Add the parameters for the stored procedure here
	@ItemCD varchar(12),
	@UpdatedUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Declare @SystemDateTime datetime=getdate()
    -- Insert statements for procedure here
	Update StockItem Set Status='0',UpdatedDate=@SystemDateTime,UpdatedUser=@UpdatedUser where ItemCD=@ItemCD
END
GO
