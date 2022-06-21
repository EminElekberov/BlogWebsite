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
