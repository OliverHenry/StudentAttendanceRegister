CREATE TABLE [sessions]
(
    [Id]              INT IDENTITY(1,1) PRIMARY KEY, 
    [session_type_id] INT NOT NULL,
    [room_id]         INT NOT NULL,
    [user_id]         INT NOT NULL,
    [course_id]       INT NOT NULL,
	CONSTRAINT [session_session_type_fk]  FOREIGN KEY ([session_type_id]) REFERENCES [session_types] ([id]),
	CONSTRAINT [session_room_fk]  FOREIGN KEY ([room_id]) REFERENCES [rooms] ([id]),
	CONSTRAINT [session_user_fk]  FOREIGN KEY ([user_id]) REFERENCES [users] ([id]),
	CONSTRAINT [session_course_fk]  FOREIGN KEY ([course_id]) REFERENCES [courses] ([id])
)
