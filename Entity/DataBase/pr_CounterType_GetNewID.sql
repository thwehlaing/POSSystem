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
CREATE PROCEDURE  [dbo].[pr_CounterType_GetNewID]
(
    @CounterKey     int,
    @NewID          varchar(10) OUTPUT
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

    SET @NewID = @Prefix + RIGHT(FORMAT(@Counter, '0000000000'), 10 - LEN(@Prefix))

END