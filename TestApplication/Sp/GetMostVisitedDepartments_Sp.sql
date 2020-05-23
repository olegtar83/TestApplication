USE [JTITestDB]
GO

/****** Object:  StoredProcedure [dbo].[GetMostVisitedDepartments]    Script Date: 23/05/2020 13:09:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetMostVisitedDepartments]
AS
BEGIN
select top 3 d.Name, COUNT(d.Id) as Total from Visits v
inner join  Departments d on d.Id = v.DepartmentId
group by d.Name
order by COUNT(d.Id) desc
END
GO


