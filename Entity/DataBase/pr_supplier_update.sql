 BEGIN TRY 
 Drop Procedure [dbo].[pr_supplier_update]
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
ALTER PROCEDURE [dbo].[pr_supplier_update]
	-- Add the parameters for the stored procedure here
	@SupplierCD varchar(10),
	@SupplierName nvarchar(50),
	@PhoneNo nvarchar(20),
	@Address nvarchar(200),
	@Status	varchar(10),
	@UpdatedUser	varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @SysDatetime datetime = GETDATE()
	update Supplier set SupplierName=@SupplierName,PhoneNo=@PhoneNo,Address=@Address,Status=@Status,UpdatedUser=@UpdatedUser,UpdatedDate=@SysDatetime where SupplierCD=@SupplierCD
END
