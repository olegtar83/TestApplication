using System.Collections.Generic;
using System.Threading.Tasks;
using TestDAL.ComplexTypes;
using TestDAL.Models;

namespace TestDAL.Repositories
{
	public interface IJTIRepo
	{
		Task<IEnumerable<Departments>> GetAllDepartments();
		Task<IEnumerable<GetMostActiveEmployeesResult>> GetMostActiveEmployes();
		Task<IEnumerable<GetMostVisitedDepartmentsResult>> GetMostVisitedDepartments();
	}
}