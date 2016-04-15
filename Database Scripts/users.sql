CREATE TABLE [users]
(
    [Id]             INT NOT NULL PRIMARY KEY, 
    [login_id]       VARCHAR(30) NOT NULL UNIQUE,
    [first_name]     VARCHAR(50) NOT NULL,
    [last_name]      VARCHAR(50) NOT NULL,
    [date_of_birth]  DATE NOT NULL,
    [user_type_id]   INT NOT NULL,
    [password_hash]  VARCHAR(255) NOT NULL,
	CONSTRAINT [FK1] FOREIGN KEY ([user_type_id]) REFERENCES [user_types] ([id])
)
