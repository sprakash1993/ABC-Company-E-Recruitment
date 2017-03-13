use DB03HMS07;


create table CandidateBGCCheck
(
 BGCID int IDENTITY(10000,1),
 FromDate DateTime,
 ToDate DateTime,
 AdministratorID int)

 alter table CandidateBGCCheck
 add constraint pk_bgcCheck primary key (BGCID)

 insert into CandidateBGCCheck values('06/08/2014','09/08/2014',100)

 select * from CandidateBGCCheck

 create proc sp_insertBGCCheck
 (
 @fromDate datetime,
 @toDate datetime,
 @administratorID int,
 @bgcID int out)
 as
 begin
 insert into CandidateBGCCheck values(@fromDate,@toDate,@administratorID)
 set @bgcID=@@IDENTITY
 end

 declare @id int
 exec sp_insertBGCCheck '08/06/2014','08/09/2014',102,@bgcID=@id output 
 print @id

 create table UserLogin
 (Username varchar(20) not null,pasword varchar(20),stat int default 0 )

 insert into UserLogin(Username,pasword) values('843573','tcshyd')

 alter table UserLogin
 add constraint pk_user primary key (Username)

 select * from UserLogin
  select * from EMPLOYEE

  update EMPLOYEE set IsHR=1 where EmployeeName='zoozoo'

 drop table UserLogin

 create proc sp_LoginInsert
 (@Username varchar(10),@pasword varchar(10))
 as
 begin

 insert into UserLogin(Username,pasword) values
 (@Username,@pasword)
 end
 drop proc sp_LoginInsert
 exec sp_LoginInsert '843573','tcshyd'

  create proc sp_LoginInsert1
 (@Username varchar(10),@pasword varchar(10),@stat int)
 as
 begin

 insert into UserLogin values(@Username,@pasword,@stat)
 end

 create proc sp_getUsers
 as
 begin
 select * from UserLogin
 end


insert into UserLogin values('888888','tcshyd',1)


drop table BGCAdmin

create table BGCAdministrator
(
AdministratorID int not null IDENTITY(5001,1),
AdminStatus int,
StatusChangeTime DateTime,
EmployeeID int)

alter table BGCAdministrator
add constraint pk_bgcAdmin primary key (AdministratorID)

alter table BGCAdministrator
add constraint fk_bgcAdmin foreign key (EmployeeID) references EMPLOYEE (EmployeeID)

alter table EMPLOYEE
add constraint pk_employee primary key (EmployeeID)

create proc sp_addAdmin
(
@AdminStatus int,
@StatusChangeTime DateTime,
@EmployeeID int,
@AdministratorID int out)
as begin
insert into BGCAdministrator values(@AdminStatus,@StatusChangeTime,@EmployeeID)
set @AdministratorID=@@IDENTITY
end
select * from BGCAdministrator
declare @res int
exec sp_addAdmin 0,'08/08/2014',2002,@AdministratorID= @res output
print @res

create proc sp_approveAdmin
(
@AdministratorID int,
@AdminStatus int,
@StatusChangeTime DateTime
)
as begin
update BGCAdministrator set AdminStatus=@AdminStatus,StatusChangeTime=@StatusChangeTime where AdministratorID=@AdministratorID
end

drop proc sp_approveAdmin
exec sp_approveAdmin 5002,1
exec sp_approveAdmin 5001,0

select * from EMPLOYEE

create proc sp_changePwd
(
@Username varchar(10),@pasword varchar(10),@stat int
)
as begin
update UserLogin set pasword=@pasword,stat=@stat where Username=@Username
end

select * from UserLogin 
drop proc sp_changePwd
exec sp_changePwd '843573','sajeed',1

update UserLogin set stat=0 where Username='852724'

create proc sp_displayEmp
as begin
select * from EMPLOYEE
end

create proc sp_displayAdmin
as begin 
select * from BGCAdministrator
end

exec sp_displayAdmin

create table BGCTestSchedule
(
BGCID int IDENTITY(9000,1),
fromDate datetime,
toDate datetime,
AdministratorId int);

create proc sp_AddBGCSchedule
(
@fromDate datetime,
@toDate datetime,
@AdministratorId int,
@BGCID int out)
as begin
insert into BGCTestSchedule values(@fromDate,@toDate,@AdministratorId)
set @BGCID=@@IDENTITY
end

alter table BGCTestSchedule
add constraint pk_bgcschedule primary key(BGCID)

alter table BGCTestSchedule
add constraint fk_bgcschedule foreign key (AdministratorId) references BGCAdministrator(AdministratorID)

select * from BGCAdministrator

declare @bgc int
exec sp_AddBGCSchedule '08/11/2014','09/11/2014',5003,@BGCID=@bgc output
print @bgc
use DB03HMS07
create proc sp_displaySchedule
as begin
select * from BGCTestSchedule
end

select * from BGCTestSchedule

insert into UserLogin values 

select * from UserLogin

select * from EMPLOYEE

update EMPLOYEE set IsHR=1 where EmployeeID=2005

insert into UserLogin values('2005','tcshyd',1)