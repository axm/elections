﻿CREATE TABLE [dbo].[Members]
(
	[PersonId] UNIQUEIDENTIFIER NOT NULL,
	[PartyId] UNIQUEIDENTIFIER NOT NULL,
	[TimestampCreated] DATETIME NOT NULL DEFAULT(GETUTCDATE())
)
