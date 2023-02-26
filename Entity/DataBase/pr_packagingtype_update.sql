BEGIN TRY 
 Drop Procedure [dbo].[pr_packagingtype_update]
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
CREATE PROCEDURE [dbo].[pr_packagingtype_update] 
	-- Add the parameters for the stored procedure here
	@PackTypeCode varchar(10),
	@PackTypeName nvarchar(50),
	@Qty	int,
	@Status varchar(10),
	@UpdatedUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update PackagingType set PackTypeName=@PackTypeName,Qty=@Qty,Status=@Status,UpdatedDate=GETDATE(),UpdatedUser=@UpdatedUser where PackTypeCode=@PackTypeCode
END