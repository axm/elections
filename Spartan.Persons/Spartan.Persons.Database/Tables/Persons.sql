﻿CREATE TABLE [dbo].[Persons]
(
	[PersonId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[FirstName] NVARCHAR(512) NOT NULL,
	[MiddleName] NVARCHAR(512) NULL,
	[Surname] NVARCHAR(512) NOT NULL,
	[DateOfBirth] DATE NOT NULL,
	[TimestampCreated] DATETIME NOT NULL DEFAULT GETUTCDATE(),
	[TimestampModified] DATETIME NOT NULL DEFAULT GETUTCDATE()
)
