using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestDAL.Models;

namespace TestDAL.Repositories
{
	public class JTIRepo : IJTIRepo
	{
		private readonly JTITestContext _context;

		public JTIRepo(JTITestContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Departments>> GetAllDepartments()
		{
			return await Task.Run(
					() => _context.Departments
				).ConfigureAwait(false);
		}
	}
}
