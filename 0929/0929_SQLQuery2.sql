CREATE TABLE LabTable
(
  id int NOT NULL PRIMARY KEY,
  data varchar(20)
)
GO

insert into LabTable values (1, 'data a')
insert into LabTable values (2, 'data b')
insert into LabTable values (3, 'data c')
Go

CREATE USER [Users] FOR LOGIN [BUILTIN\Users]
ALTER ROLE [db_datareader] ADD MEMBER [Users]
ALTER ROLE [db_datawriter] ADD MEMBER [Users]
GO

 select * from LabTable