 BEGIN TRY 
 Drop Procedure [dbo].[pr_category_insert]
END try
BEGIN CATCH END CATCH 
SET ANSI_NULLS ON
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[pr_category_insert]
	@CategoryName nvarchar(50),
	@Status		varchar(10),
	@Operator   varchar(10)
AS
BEGIN

Declare @maxcatcd varchar(20)
	Exec pr_CounterType_GetNewID
		@CounterKey = 1, 
		@Type='Mst',
        @NewID = @maxcatcd OUTPUT

	INSERT INTO Category
         (
          CategoryCD,
		  CategoryName,
		  Status,
		  CreatedDate,
		  CreatedUser
		 )
		  VALUES
           (
		  @maxcatcd
           ,@CategoryName
           ,@Status           
           ,GetDate()
           ,@Operator
           );
END
