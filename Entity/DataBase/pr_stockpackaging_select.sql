BEGIN TRY 
 Drop Procedure [dbo].[pr_stockpackaging_select]
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
ALTER PROCEDURE [dbo].[pr_stockpackaging_select]
	-- Add the parameters for the stored procedure here
	@ItemCD varchar(12)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select * from StockPackaging where (@ItemCD is null or ItemCD=@ItemCD)
END
