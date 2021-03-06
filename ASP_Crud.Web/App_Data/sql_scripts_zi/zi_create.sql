USE [CRUDASP]
GO
/****** Object:  StoredProcedure [dbo].[Zi_create]    Script Date: 4/17/2018 12:37:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Zi_create] 
	
	 
	@ID int out,	
	@Data datetime = null,
	@Checked nvarchar(10) = null,
	@Solved nvarchar (10) = null,
	@Comments nvarchar(100) = null
	
AS
BEGIN
	
	SET NOCOUNT ON;

	INSERT INTO [CRUDASP].[dbo].[Zi]
           ([Data] ,
		   [Checked],
		   [Solved],
		   [Comments])
     VALUES
           (@Data, @Checked, @Solved, @Comments)
		   SET @ID = @@IDENTITY
		   select @ID
END