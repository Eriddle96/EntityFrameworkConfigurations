CREATE TABLE dbo.Student (
	Id int IDENTITY(1,1) NOT NULL,
	FirstName nvarchar(100) NOT NULL,
	LastName nvarchar(100) NOT NULL,
	CreatedOnUtc datetime NOT NULL ,
	CONSTRAINT PK_Student PRIMARY KEY (Id)
)
