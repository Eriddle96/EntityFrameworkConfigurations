CREATE TABLE dbo.StudentCourses (
	StudentId int NOT NULL,
	CourseId int NOT NULL,
	CONSTRAINT PK_StudentCourses PRIMARY KEY (StudentId, CourseId),
	CONSTRAINT FK_Student FOREIGN KEY (StudentId) REFERENCES dbo.Student (Id),
	CONSTRAINT FK_Course FOREIGN KEY (CourseId) REFERENCES dbo.Course (Id)
)
