BEGIN TRY 
 Drop function [dbo].[func_get_maxsubcode]
END try
BEGIN CATCH END CATCH 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_get_maxsubcode]  (  
	@start varchar(1)
)
RETURNS varchar(10)
AS
BEGIN
   declare @maxsubcode varchar(10);	
   Set @maxsubcode=(SELECT Concat(@start,Format(Convert(INT,SUBSTRING(max(SubCode), 2, Len(max(SubCode))))+1,'000000000')) from SubCategory)
   
   if @maxsubcode is null
	   begin
		Set @maxsubcode=Concat(@start, '000000001');	
	   end
   return @maxsubcode
END
