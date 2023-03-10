BEGIN TRY 
 Drop Procedure [dbo].[[pr_subcategory_insert]
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
ALTER PROCEDURE [dbo].[pr_subcategory_insert] 
	-- Add the parameters for the stored procedure here
	@CategoryCD varchar(10),
	@SubName	nvarchar(50),	
	@Status	varchar(10),	
	@CreatedUser varchar(50)	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON
DECLARE @SysDatetime datetime = GETDATE()
	DECLARE @maxsubcode varchar(20);
	EXEC pr_CounterType_GetNewID 
        @CounterKey = 2, 
		@Type='Mst',
        @NewID = @maxsubcode OUTPUT
	
   insert into SubCategory(SubCode,CategoryCD,SubName,Status,CreatedDate,CreatedUser) values(@maxsubcode,@CategoryCD,@SubName,@Status,@SysDatetime,@CreatedUser)
END
