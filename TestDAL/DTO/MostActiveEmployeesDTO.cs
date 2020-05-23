using System;
using System.Collections.Generic;
using System.Text;

namespace TestDAL.DTO
{
	public class MostActiveEmployeesDTO
	{
		public int TotalVisits { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Id { get; set; }
		public string DepartmentName { get; set; }
	}
}
