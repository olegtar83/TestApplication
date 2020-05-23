using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestDAL.ComplexTypes;
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
			return await _context.Departments.ToListAsync();
		}
		public async Task<IEnumerable<GetMostActiveEmployeesResult>> GetMostActiveEmployes()
		{
			return await _context.GetMostActiveEmployeesResults.FromSqlRaw("GetMostActiveEmployees").ToListAsync();						
		}
		public async Task<IEnumerable<GetMostVisitedDepartmentsResult>> GetMostVisitedDepartments()
		{
			return await _context.GetMostVisitedDepartmentsResults.FromSqlRaw("GetMostVisitedDepartments").ToListAsync();
		}
	}
}
