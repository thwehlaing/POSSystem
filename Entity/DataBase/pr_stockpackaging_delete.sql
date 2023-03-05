BEGIN TRY 
 Drop Procedure [dbo].[pr_stockpackaging_delete]
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
ALTER PROCEDURE [dbo].[pr_stockpackaging_delete]
	-- Add the parameters for the stored procedure here
	@ItemCD varchar(12),
	@PackTypeCode varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete  from StockPackaging where ItemCD=@ItemCD and PackTypeCode=@PackTypeCode
END

