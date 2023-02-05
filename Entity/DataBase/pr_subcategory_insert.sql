 BEGIN TRY 
 Drop Procedure [dbo].[pr_subcategory_insert]
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
CREATE PROCEDURE [dbo].[pr_subcategory_insert] 
	-- Add the parameters for the stored procedure here
	@categorycd varchar(10),
	@subname	nvarchar(50),	
	@status	varchar(10),
	@createddate	datetime,
	@createduser	varchar(50)	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @maxsubcode varchar(10);
	Set @maxsubcode=dbo.func_get_maxsubcode('S');
	
   insert into SubCategory(SubCode,CategoryCD,SubName,Status,CreatedDate,CreatedUser) values(@maxsubcode,@categorycd,@subname,@status,@createddate,@createduser)
END
