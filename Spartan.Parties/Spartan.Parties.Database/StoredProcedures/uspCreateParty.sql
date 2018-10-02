CREATE PROCEDURE [dbo].[uspCreateParty]
	@PartyId UNIQUEIDENTIFIER,
	@PartyRef VARCHAR(64),
	@CountryCode NVARCHAR(10),
	@Name NVARCHAR(256)
AS
BEGIN

	INSERT INTO dbo.[Parties]
           ([PartyId]
		   ,[PartyRef]
           ,[CountryCode]
           ,[Name])
     VALUES
           (@PartyId
		   ,@PartyRef
           ,@CountryCode
           ,@Name)

END