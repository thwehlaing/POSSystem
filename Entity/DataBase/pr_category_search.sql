﻿ BEGIN TRY 
 Drop Procedure [dbo].[pr_category_search]
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
CREATE PROCEDURE [dbo].[pr_category_search] 
	-- Add the parameters for the stored procedure here
	@CategoryName nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select * from Category where Status='1' and (@CategoryName is null or CategoryName like @CategoryName+'%')
END
