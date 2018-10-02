CREATE PROCEDURE [dbo].[uspAddPartyMember]
	@PartyId UNIQUEIDENTIFIER,
	@PersonId UNIQUEIDENTIFIER
AS
BEGIN

	INSERT INTO dbo.Members(PartyId, PersonId)
	VALUES(@PartyId, @PersonId)

END
