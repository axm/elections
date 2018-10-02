CREATE PROCEDURE [dbo].[uspGetParty]
	@PartyId UNIQUEIDENTIFIER
AS
BEGIN

	SELECT *
	FROM [dbo].[Parties]
	WHERE [PartyId] = @PartyId

END
