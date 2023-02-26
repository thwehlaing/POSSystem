﻿BEGIN TRY 
 Drop Procedure [dbo].[pr_category_delete]
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
CREATE PROCEDURE [dbo].[pr_category_delete]
	-- Add the parameters for the stored procedure here
	@CategoryCD varchar(10),
	@Operator varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Category Set Status='0',UpdatedDate=getdate(),UpdatedUser=@Operator where CategoryCD=@CategoryCD
END
GO
