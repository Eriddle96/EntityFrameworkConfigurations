CREATE TABLE dbo.Course (
	Id int IDENTITY(1,1) NOT NULL,
	Code nvarchar(100) NOT NULL,
	CreatedOnUtc datetime NOT NULL,
	CONSTRAINT PK_Course PRIMARY KEY (Id)
)
