CREATE PROCEDURE [dbo].[uspCreatePerson]
	@PersonId UNIQUEIDENTIFIER,
	@FirstName NVARCHAR(512),
	@MiddleName NVARCHAR(512),
	@Surname NVARCHAR(512),
	@DateOfBirth DATE
AS
BEGIN
	DECLARE @Now DATETIME = GETUTCDATE()

	INSERT INTO dbo.Persons(PersonId, FirstName, MiddleName, Surname, DateOfBirth, TimestampCreated, TimestampModified)
	VALUES(@PersonId, @FirstName, @MiddleName, @Surname, @DateOfBirth, @Now, @Now)
END
