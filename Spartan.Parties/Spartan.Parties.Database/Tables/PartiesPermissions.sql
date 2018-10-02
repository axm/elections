CREATE TABLE [dbo].[PartiesPermissions]
(
	[UserId] UNIQUEIDENTIFIER NOT NULL,
	[PartyId] UNIQUEIDENTIFIER NOT NULL,

	CONSTRAINT PK_PartiesPermissions PRIMARY KEY(UserId, PartyId)
)
