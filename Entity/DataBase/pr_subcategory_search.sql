BEGIN TRY 
 Drop Procedure [dbo].[[pr_subcategory_search]
END try
BEGIN CATCH END CATCH 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[pr_subcategory_search]
	-- Add the parameters for the stored procedure here
	@CategoryCD	varchar(10),
	@SubName	nvarchar(50)
AS
BEGIN
	Select c.CategoryCD ,SubCode,c.CategoryName,sc.SubName from SubCategory sc 
	inner join Category c 
	on sc.CategoryCD=c.CategoryCD 
	where sc.CategoryCD=@CategoryCD and (@SubName is null OR (SubName like @SubName +'%')) and sc.Status='1'
END