using System.Collections.Generic;
using System.Threading.Tasks;
using TestDAL.DTO;

namespace TestServices
{
	public interface IRepoServices
	{
		Task<IEnumerable<DepertmentDTO>> GetAllDepartment();
	}
}