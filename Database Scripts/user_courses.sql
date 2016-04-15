CREATE TABLE [user_courses]
(
    [Id]        INT IDENTITY(1,1) PRIMARY KEY, 
    [user_id]   INT NOT NULL,
    [course_id] INT NOT NULL,
	[temp_user] BIT NOT NULL,
	CONSTRAINT [user_fk]  FOREIGN KEY ([user_id]) REFERENCES [users] ([id]),
	CONSTRAINT [course_fk]  FOREIGN KEY ([course_id]) REFERENCES [courses] ([id]),
	CONSTRAINT [user_course_cuk] UNIQUE (user_id, course_id)
)
