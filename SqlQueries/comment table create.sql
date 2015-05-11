-- write as: "comment_*BRAND*_*MODEL_WITH_SPACES*
CREATE TABLE comment_Tesla_Model_S
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	comment varchar(5000) NOT NULL,
	commenter varchar(128) NOT NULL,
	rate int --tinyint = 1 byte    --smallint = 2 bytes
);