﻿DELETE USERS;
DELETE USER_TYPES;

INSERT INTO USER_TYPES (NAME) VALUES ('Course Coordinator');
INSERT INTO USER_TYPES (NAME) VALUES ('Tutor');
INSERT INTO USER_TYPES (NAME) VALUES ('Student');

INSERT INTO USERS
(
 ID,
 LOGIN_ID,
 FIRST_NAME,
 LAST_NAME,
 DATE_OF_BIRTH,
 USER_TYPE_ID,
 PASSWORD_HASH
) 
VALUES
(
 000823678,
 'HO406',
 'Oliver',
 'Henry',
 '04-SEP-95',
 (SELECT ID FROM USER_TYPES WHERE NAME = 'Student'),
 '319f4d26e3c536b5dd871bb2c52e3178'
);

INSERT INTO USERS
(
 ID,
 LOGIN_ID,
 FIRST_NAME,
 LAST_NAME,
 DATE_OF_BIRTH,
 USER_TYPE_ID,
 PASSWORD_HASH
) 
VALUES
(
 000823465,
 'ADMIN',
 'Admin',
 'Admin',
 '24-DEC-90',
 (SELECT ID FROM USER_TYPES WHERE NAME = 'Course Coordinator'),
 '319f4d26e3c536b5dd871bb2c52e3178'
);

INSERT INTO USERS
(
 ID,
 LOGIN_ID,
 FIRST_NAME,
 LAST_NAME,
 DATE_OF_BIRTH,
 USER_TYPE_ID,
 PASSWORD_HASH
) 
VALUES
(
 000494367,
 'Tutor',
 'Tutor',
 'Tutor',
 '01-JAN-85',
 (SELECT ID FROM USER_TYPES WHERE NAME = 'Tutor'),
 '319f4d26e3c536b5dd871bb2c52e3178'
);