﻿
DELETE SESSIONS;
DELETE COURSES;
DELETE ROOMS;
DELETE SESSION_TYPES;
DELETE USERS;
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
 000776421,
 'student1',
 'Mike',
 'Asiku',
 '16-JUL-93',
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
 000785292,
 'student2',
 'Steven',
 'Ngo',
 '24-AUG-94',
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
 000830271,
 'student3',
 'Marvin',
 'Osei',
 '22-FEB-95',
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
 001836087,
 'student4',
 'Abdul',
 'Younas',
 '12-JAN-94',
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
 000831587,
 'student5',
 'Lisa',
 'West',
 '20-JAN-92',
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
 000836087,
 'student6',
 'Greg',
 'Phil',
 '12-DEC-92',
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
 000830321,
 'student7',
 'Peter',
 'Cole',
 '17-APR-94',
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
 000777532,
 'student8',
 'Lucy',
 'James',
 '12-JUL-93',
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
 000901087,
 'student9',
 'Alan',
 'Lalana',
 '10-NOV-92',
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
 000911117,
 'student10',
 'David',
 'Mitch',
 '22-NOV-94',
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
 000494367,
 'Tutor',
 'Tutor',
 'Tutor',
 '01-JAN-85',
 (SELECT ID FROM USER_TYPES WHERE NAME = 'Tutor'),
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
 000490060,
 'Tutor1',
 'Jess',
 'Lind',
 '16-NOV-85',
 (SELECT ID FROM USER_TYPES WHERE NAME = 'Tutor'),
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
 000983367,
 'Tutor2',
 'Mark',
 'Marco',
 '21-JUL-85',
 (SELECT ID FROM USER_TYPES WHERE NAME = 'Tutor'),
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
 000116167,
 'Tutor3',
 'Tom',
 'Davis',
 '29-JUN-90',
 (SELECT ID FROM USER_TYPES WHERE NAME = 'Tutor'),
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
 001494367,
 'Tutor4',
 'Stephanie',
 'Dawson',
 '09-SEP-85',
 (SELECT ID FROM USER_TYPES WHERE NAME = 'Tutor'),
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
 000123456,
 'admin1',
 'Will',
 'Queen',
 '21-FEB-89',
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
 000654321,
 'admin2',
 'Sarah',
 'Taylor',
 '21-JUN-89',
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
 000102756,
 'admin3',
 'Ashley',
 'Terry',
 '19-APR-90',
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
 003123456,
 'admin4',
 'Robert',
 'Luke',
 '11-DEC-79',
 (SELECT ID FROM USER_TYPES WHERE NAME = 'Course Coordinator'),
 '319f4d26e3c536b5dd871bb2c52e3178'
);

INSERT INTO COURSES (CODE, NAME) VALUES ('COMP1632', 'Systems Development Project');
INSERT INTO COURSES (CODE, NAME) VALUES ('COMP1287', 'Games Design and Devlopment');
INSERT INTO COURSES (CODE, NAME) VALUES ('COMP1718', 'C++ Game Programming');

INSERT INTO ROOMS (NAME) VALUES ('KW315');
INSERT INTO ROOMS (NAME) VALUES ('QA003');
INSERT INTO ROOMS (NAME) VALUES ('QA235');
INSERT INTO ROOMS (NAME) VALUES ('KW016');
INSERT INTO ROOMS (NAME) VALUES ('KW216');
INSERT INTO ROOMS (NAME) VALUES ('QM446');

INSERT INTO SESSION_TYPES (NAME) VALUES ('Lecture');
INSERT INTO SESSION_TYPES (NAME) VALUES ('Tutorial');
INSERT INTO SESSION_TYPES (NAME) VALUES ('Lab');

WITH SESSION_DATA AS
(
 SELECT 'Lecture' session_type, 'KW315' room, 'COMP1632' course, 'tutor1' tutor UNION ALL
 SELECT 'Lab', 'QM446', 'COMP1632', 'tutor1' UNION ALL
 SELECT 'Tutorial', 'KW016', 'COMP1632', 'tutor1' UNION ALL
 
 SELECT 'Lecture', 'KW315', 'COMP1287', 'admin3' UNION ALL
 SELECT 'Lab', 'KW216', 'COMP1287', 'Tutor4' UNION ALL
 SELECT 'Tutorial', 'QA235', 'COMP1287', 'Tutor4' UNION ALL

 SELECT 'Lecture', 'QA003', 'COMP1718', 'admin4' UNION ALL
 SELECT 'Lab', 'KW216', 'COMP1718', 'Tutor3' UNION ALL
 SELECT 'Tutorial', 'KW016', 'COMP1718', 'Tutor2'
)
INSERT INTO SESSIONS
(
 session_type_id,
 room_id,
 user_id,
 course_id
)
SELECT st.Id session_type_id,
       r.Id room_id,
	   u.Id user_d,
	   c.Id course_id
  FROM session_types st
CROSS JOIN rooms r
CROSS JOIN users u 
CROSS JOIN courses c
  JOIN session_data sd 
    ON sd.course = c.code
   AND sd.room = r.name
   AND sd.tutor = u.login_id
   AND sd.session_type = st.name;

