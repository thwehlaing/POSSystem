 BEGIN TRY 
 Drop Procedure [dbo].[pr_supplier_search]
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
ALTER PROCEDURE [dbo].[pr_supplier_search]
	-- Add the parameters for the stored procedure here
	@SupplierName nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select SupplierCD,SupplierName,PhoneNo,Address from Supplier where Status='1' and SupplierName is null or SupplierName like @SupplierName+'%'
END
