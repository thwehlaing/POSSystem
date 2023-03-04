 BEGIN TRY 
 Drop Procedure [dbo].[pr_supplier_delete]
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
CREATE PROCEDURE [dbo].[pr_supplier_delete]
	-- Add the parameters for the stored procedure here
	@SupplierCD varchar(10),
	@UpdatedUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @SysDatetime datetime = GETDATE()
    Update Supplier set Status='0',UpdatedUser=@UpdatedUser,UpdatedDate=@SysDatetime where SupplierCD=@SupplierCD
END
