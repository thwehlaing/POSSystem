 BEGIN TRY 
 Drop Procedure [dbo].[pr_category_select]
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
CREATE PROCEDURE [dbo].[pr_category_select]
AS
BEGIN
	select * from Category where Status='1'
END
