CREATE TABLE [attendance]
(
    [Id]              INT IDENTITY(1,1) PRIMARY KEY, 
    [user_id]         INT NOT NULL,
    [session_id]      INT NOT NULL,
    [attendance_date] INT NOT NULL,
	CONSTRAINT [attendance_user_fk]  FOREIGN KEY ([user_id]) REFERENCES [users] ([id]),
	CONSTRAINT [attendance_session_fk]  FOREIGN KEY ([session_id]) REFERENCES [sessions] ([id])
)
