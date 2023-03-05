BEGIN TRY 
 Drop Procedure [dbo].[pr_stockpackaging_update]
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
CREATE PROCEDURE [dbo].[pr_stockpackaging_update]
	-- Add the parameters for the stored procedure here
	@ItemCD varchar(12),
	@PackTypeCode varchar(10),
	@Qty int,
	@UpdatedUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update StockPackaging set Qty=@Qty,UpdatedDate=GETDATE(),UpdatedUser=@UpdatedUser where ItemCD=@ItemCD and PackTypeCode=@PackTypeCode
END
