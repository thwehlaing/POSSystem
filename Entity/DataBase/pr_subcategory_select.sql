BEGIN TRY 
 Drop Procedure [dbo].[[pr_subcategory_select]
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
CREATE PROCEDURE [dbo].[pr_subcategory_select]
	-- Add the parameters for the stored procedure here
	@CategoryCD varchar(10),
	@SubName	nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT s.SubCode,c.CategoryName,s.SubName from SubCategory s
	inner join Category c on s.CategoryCD=c.CategoryCD 
	where c.CategoryCD=@CategoryCD and (@SubName is null OR (SubName like @SubName +'%')) and s.Status='1'
END
