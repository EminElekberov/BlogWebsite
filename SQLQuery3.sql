create trigger AddBlogInRaytingTable
On Blogs
After insert 
as Declare @Id int
Select @Id=Id from inserted
insert into BlogRaytings(BlogReytingId,BlogTotalScore,BlogRaytingScore)
values(@Id,0,0)

create trigger AddScoreInComennt
On Comments
after insert 
as
Declare @ID int 
Declare @Score int 
Declare @RaytingCount int 
Select @ID=BlogId ,@Score=Score from inserted
Update BlogRaytings set BlogTotalScore=BlogTotalScore+@Score,BlogRaytingScore+=1
where BlogReytingId=@ID






create trigger trgAfterInsertEmployee on
dbo.[AspNetUsers]
for insert
as
declare @empID int;
declare @emp_name nvarchar(20);
declare @empSalary nvarchar(20);
declare @empPass nvarchar(20);

select  @empID=y.Id from inserted y
select  @emp_name=y.NameSurname from inserted y
select  @empSalary=y.Email from inserted y 
select  @empPass=y.PasswordHash from inserted y 

insert into Writers([Name],Email,[Password])
values (@emp_name,@empSalary,@empPass)

Print 'After Insert trigger '
go
insert into Employee values('vygbhujbjn',1500)