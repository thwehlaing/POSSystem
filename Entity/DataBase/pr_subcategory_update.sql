BEGIN TRY 
 Drop Procedure [dbo].[[pr_subcategory_update]
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
ALTER PROCEDURE [dbo].[pr_subcategory_update] 
	-- Add the parameters for the stored procedure here
	@SubCode varchar(10),
	@CategoryCD varchar(10),
	@SubName nvarchar(50),	
	@Status	varchar(10),
	
	@UpdatedUser	varchar(50)	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	DECLARE @SysDatetime datetime = GETDATE()
   update SubCategory set SubName=@SubName,Status=@Status,UpdateDate=@SysDatetime,UpdatedUser=@UpdatedUser where SubCode=@SubCode and CategoryCD=@CategoryCD
END
