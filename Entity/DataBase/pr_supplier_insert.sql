BEGIN TRY 
 Drop Procedure [dbo].[pr_supplier_insert]
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
ALTER PROCEDURE [dbo].[pr_supplier_insert]
	-- Add the parameters for the stored procedure here
	@SupplierName	nvarchar(50),
	@PhoneNo	nvarchar(20),
	@Address	nvarchar(200),
	@Status	varchar(10),
	@CreatedUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @SysDatetime datetime = GETDATE()
	DECLARE @maxsubcode varchar(10);
	EXEC pr_CounterType_GetNewID 
        @CounterKey = 2, 
        @NewID = @maxsubcode OUTPUT

		 insert into Supplier(SupplierCD,SupplierName,PhoneNo,Address,Status,CreatedDate,CreatedUser) values(@maxsubcode,@SupplierName,@PhoneNo,@Address,@Status,@SysDatetime,@CreatedUser)
    
END
