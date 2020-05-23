USE [JTITestDB]
GO

/****** Object:  StoredProcedure [dbo].[GetMostActiveEmployees]    Script Date: 23/05/2020 13:08:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetMostActiveEmployees]
AS
BEGIN
select top 10 result.*, d.Name as DepartmentName from(
select  COUNT(e.Id)as TotalVisits,e.FirstName,e.LastName , e.Id,
(select top 1 d.Id from Departments d inner join Visits v on v.DepartmentId = d.Id 
where v.EmployeeId = e.Id
group by d.Id
order by count(v.Id) desc
) as DepartmentID from Visits v
inner join Employees e on v.EmployeeId = e.Id
group by e.Id,e.FirstName,e.LastName
)as result
inner join Departments d on DepartmentID = d.Id
order by TotalVisits desc
END
GO


