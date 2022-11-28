create table tbl_Questions(
    QuestionID varchar(10) primary key,
	QuestionName nvarchar(max)
)
Insert into tbl_Questions values('Q1',N'Tại sao bạn muốn học lập trình?')
Insert into tbl_Questions values('Q2',N'Bạn muốn kiếm tiền như thế nào?')
Insert into tbl_Questions values('Q3',N'Bạn muốn làm việc trong lĩnh vực nào?')
Insert into tbl_Questions values('Q4',N'Bạn muốn làm nền tảng nào trong web?')
Insert into tbl_Questions values('Q5',N'Bạn muốn làm với hệ điều hành nào?')
Insert into tbl_Questions values('Q6',N'Bạn muốn làm trong công ty nào?')
Insert into tbl_Questions values('Q7',N'Bạn có ý tưởng nào trong đầu chưa?')
Insert into tbl_Questions values('Q8',N'Bạn muốn học mọi thứ theo cách nào?')

drop table tbl_Results

create table tbl_Answers(
	AnswerID varchar(10) primary key,
	CurrentQuestion varchar(10),
	NextQuestion varchar(10),   
	AnswerName nvarchar(max)
)

Delete from tbl_Answers where AnswerID = 'A1'

Insert into tbl_Answers values('A1','Q1','Q2',N'Kiếm tiền')
Insert into tbl_Answers values('A2','Q1','Q7',N'Sở thích, Phát triển bản thân')
Insert into tbl_Answers values('A3','Q2','Q3',N'Tìm việc làm')
Insert into tbl_Answers values('A4','Q2','Q3',N'Start up')
Insert into tbl_Answers values('A5','Q3','Q4',N'Web')
Insert into tbl_Answers values('A6','Q3','Q5',N'App Mobile')
Insert into tbl_Answers values('A7','Q3','Q6',N'Làm trong công ty công nghệ lớn')
Insert into tbl_Answers values('A8','Q3',null,N'Game')
Insert into tbl_Answers values('A9','Q3',null,N'Trí tuệ nhân tạo')
Insert into tbl_Answers values('A10','Q4',null,N'Front-End')
Insert into tbl_Answers values('A11','Q4','Q6',N'Back-end')
Insert into tbl_Answers values('A12','Q5',null,N'IOS')
Insert into tbl_Answers values('A13','Q5',null,N'Android')
Insert into tbl_Answers values('A14','Q6',null,N'FPT')
Insert into tbl_Answers values('A15','Q6',null,N'CMC')
Insert into tbl_Answers values('A16','Q6',null,N'Viettinlab')
Insert into tbl_Answers values('A17','Q6',null,N'Ngân hàng')
Insert into tbl_Answers values('A18','Q7','Q3',N'Đã có')
Insert into tbl_Answers values('A19','Q7','Q8',N'Chưa có, muốn bắt đầu học mọi thứ')
Insert into tbl_Answers values('A20','Q8',null,N'Cách dễ dàng')
Insert into tbl_Answers values('A21','Q8',null,N'Cách tốt nhất')
Insert into tbl_Answers values('A22','Q8',null,N'Cách hơi khó một chút')
Insert into tbl_Answers values('A23','Q8',null,N'Cách khó nhưng giúp bạn học các ngôn ngữ khác trong tương lai')



create table tbl_Results(
	ResultID varchar(10) primary key,
	Description nvarchar(max),
	ResultName nvarchar(max)
)
Insert into tbl_Results values('R1',null,'C#')
Insert into tbl_Results values('R2',null,'Javascript')
Insert into tbl_Results values('R3',null,'Objective C')
Insert into tbl_Results values('R4',null,'Java')
Insert into tbl_Results values('R5',null,'Python')
Insert into tbl_Results values('R6',null,'C++')




Insert into tbl_Rules values('Ru1','')

create table tbl_Rules(
	RuleID varchar(10) primary key,
	ResultID int,
	Rules nvarchar(max)
) 

