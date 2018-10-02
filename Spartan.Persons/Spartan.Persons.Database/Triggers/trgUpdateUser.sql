CREATE TRIGGER [trgUpdateUser]
	ON [dbo].[Persons]
	FOR INSERT, UPDATE
	AS
	BEGIN
		SET NOCOUNT ON
		
		DECLARE @Now DATETIME = GETUTCDATE()
		DECLARE @PersonHistoryId UNIQUEIDENTIFIER = NEWID()

		INSERT INTO dbo.PersonsHistory(PersonHistoryId, PersonId, FirstName, MiddleName, Surname, DateOfBirth, TimestampCreated)
		SELECT @PersonHistoryId, i.PersonId, i.FirstName, i.MiddleName, i.Surname, i.DateOfBirth, @Now
		FROM inserted i
	END
