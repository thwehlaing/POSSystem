BEGIN TRY 
 Drop Procedure [dbo].[pr_CounterType_GetNewID]
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
CREATE PROCEDURE  [dbo].[pr_CounterType_GetNewID]
(
    @CounterKey     int,
	@Type	varchar(5),
    @NewID          varchar(20) OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Prefix varchar(3) = ''
    DECLARE @Counter int = 0

    UPDATE CounterType SET 
        @Prefix = ISNULL(Prefix, ''),
        @Counter = [Counter] = ISNULL([Counter],0) + 1
    WHERE CounterKey = @CounterKey

	if @Type='Mst'
		SET @NewID = @Prefix + RIGHT(FORMAT(@Counter, '0000000000'), 10 - LEN(@Prefix))
	else
		SET @NewID = @Prefix + FORMAT(GETDate(),'yyyyMMdd')+RIGHT(FORMAT(@Counter, '0000'), 15 - (LEN(@Prefix)+8))
END
