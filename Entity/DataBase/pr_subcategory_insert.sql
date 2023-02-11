USE [POSDB]
GO
/****** Object:  StoredProcedure [dbo].[pr_subcategory_insert]    Script Date: 2/11/2023 9:35:47 PM ******/
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
	EXEC pr_CounterType_GetNewID 
        @CounterKey = 2, 
        @NewID = @maxsubcode OUTPUT
	
   insert into SubCategory(SubCode,CategoryCD,SubName,Status,CreatedDate,CreatedUser) values(@maxsubcode,@categorycd,@subname,@status,@createddate,@createduser)
END
