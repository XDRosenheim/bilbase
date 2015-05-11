use BilBase
go

-- write as: "comment_*BRAND*_*MODEL_WITH_SPACES*
CREATE TABLE comment_
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	comment varchar(5000) NOT NULL,
	commenter varchar NOT NULL,
	rate tinyint --tinyint = 1 byte    --smallint = 2 bytes
);