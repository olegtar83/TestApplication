using System.Collections.Generic;
using System.Threading.Tasks;
using TestDAL.Models;

namespace TestDAL.Repositories
{
	public interface IJTIRepo
	{
		Task<IEnumerable<Departments>> GetAllDepartments();
	}
}