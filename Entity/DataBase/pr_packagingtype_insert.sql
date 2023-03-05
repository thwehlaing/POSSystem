BEGIN TRY 
 Drop Procedure [dbo].[pr_packagingtype_delete]
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
CREATE PROCEDURE [dbo].[pr_packagingtype_insert]
	-- Add the parameters for the stored procedure here
	@PackTypeName nvarchar(50),
	@Qty	int,
	@Status varchar(10),
	@CreatedUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Declare @maxptcd varchar(20)
	Exec pr_CounterType_GetNewID
		@CounterKey = 5, 
		@Type='Mst',
        @NewID = @maxptcd OUTPUT
    -- Insert statements for procedure here
	insert into PackagingType(PackTypeCode,PackTypeName,Qty,Status,CreatedDate,CreatedUser) values(@maxptcd,@PackTypeName,@Qty,@Status,GETDATE(),@CreatedUser)
END
