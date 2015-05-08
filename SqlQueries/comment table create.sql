use bilbase
go

-- write as: "comment_*BRAND*_*MODEL_WITH_SPACES*
CREATE TABLE comment_Honda_Jazz
(
	comment varchar(5000) NOT NULL,
	commenter varchar NOT NULL,
	rate tinyint --tinyint = 1 byte    --smallint = 2 bytes
);