BEGIN TRY 
 Drop Procedure [dbo].[pr_existcheck]
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
CREATE PROCEDURE [dbo].[pr_existcheck]
	-- Add the parameters for the stored procedure here
	@TableName varchar(50),
	@Name nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	if @TableName='Category'
		begin 			
			SELECT * FROM Category WHERE CategoryName=@Name and Status='1'
		end
	else if @TableName='Supplier'
		begin 			
			SELECT * FROM Supplier WHERE SupplierName=@Name and Status='1'
		end
	else if @TableName='SubCategory'
		begin 			
			SELECT * FROM SubCategory WHERE SubName=@Name and Status='1'
		end
	else if @TableName='PackagingType'
		begin 			
			SELECT * FROM PackagingType WHERE PackTypeName=@Name and Status='1'
		end
	else if @TableName='StockItem'
		begin 			
			SELECT * FROM StockItem WHERE ItemName=@Name and Status='1'
		end	
END
