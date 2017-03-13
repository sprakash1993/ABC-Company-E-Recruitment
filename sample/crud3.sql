--creates employee table
CREATE TABLE EMPLOYEE(EmployeeID INT IDENTITY(2000,1),
EmployeeName VARCHAR(30),
DOB DATETIME,
DOJ DATETIME,
Gender VARCHAR(10),
Division varchar(20),
CTC float,
Designation varchar(15),
UnitHeadID int,
ProjectID int,
IsHR bit,
IsNew bit)

--select*from EMPLOYEE
--delete  from EMPLOYEE WHERE EmployeeID=2002

--adding values to employee table
create procedure sp_AddEmployee
(@EmployeeName varchar(30),
@DOB datetime,
@DOJ datetime,
@Gender varchar(10),
@Division varchar(20),
@CTC float,
@Designation varchar(15),
@UnitHeadID int,
@ProjectID int,
@IsHR bit,
@IsNew bit,
@EmployeeID int out)
AS
BEGIN
insert into EMPLOYEE
values(@EmployeeName ,@DOB ,@DOJ ,@Gender ,@Division ,@CTC ,
@Designation ,@UnitHeadID ,@ProjectID ,@IsHR ,@IsNew )
set @EmployeeID=@@IDENTITY
END

declare @result int
execute sp_AddEmployee 'ramya','12/04/2014','12/04/2011','female','div',12.2,'ase',12,11,0,1,@EmployeeID=@result output
print @result

select * from EMPLOYEE
drop table EMPLOYEE
drop procedure sp_AddEmployee
--UPDATE designation and ctc in employee table
create Procedure sp_UpdateEmployee1
(@EmployeeID int,@Designation varchar(15),@CTC float)
as
begin
update EMPLOYEE
SET CTC=@CTC,Designation=@Designation
where EmployeeID=@EmployeeID
end
--drop procedure sp_UpdateEmployee1
--EXECUTE sp_UpdateEmployee1 'ramya','ase1',11.2


insert into EMPLOYEE
values('ramya','12/04/2014','12/04/2011','female','div',12.2,'ase',12,11,0,1)

use DB03HMS07

create proc sp_displayAdmin
as begin
select * from BGCAdministrator
end

select * from EMPLOYEE