USE [CRUDASP]
GO
/****** Object:  StoredProcedure [dbo].[Zi_get]    Script Date: 4/17/2018 12:38:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Zi_get] 
	
	@ID int = null,	
	@Data datetime = null,
	@Checked nvarchar(10) = null,
	@Solved nvarchar (10) = null,
	@Comments nvarchar(100) = null
AS
BEGIN
	
	SET NOCOUNT ON;

  
	SELECT * 
    FROM [CRUDASP].[dbo].[Zi] z
    WHERE ID = ISNULL(@ID,ID);
END
