CREATE PROCEDURE [dbo].[uspGetMembersForParty]
	@PartyId UNIQUEIDENTIFIER
AS
BEGIN

	SELECT m.PersonId
	FROM dbo.Members m
	WHERE m.PartyId = @PartyId

END
