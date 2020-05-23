using System.Collections.Generic;
using System.Threading.Tasks;
using TestDAL.DTO;

namespace TestServices
{
	public interface IRepoServices
	{
		Task<List<DepartmentDTO>> GetAllDepartment();
		Task<List<MostActiveEmployeesDTO>> GetMostActiveEmployees();
		Task<List<MostVisitedDepartmentsDTO>> GetMostVisitedDepartments();
	}
}