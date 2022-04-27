select * from usersaccounts
truncate table usersaccounts
insert into usersaccounts values ('Shubhankar','shubh@123',1,'sk@gmail.com');
insert into usersaccounts values ('Amit','Amit@345',2,'amit@gmail.com');

desc usersaccounts

alter table usersaccounts
alter column role int