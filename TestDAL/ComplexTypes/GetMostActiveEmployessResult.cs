using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestDAL.ComplexTypes
{
	[ComplexType]
	public class GetMostActiveEmployeesResult
	{
		public int TotalVisits { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Id { get; set; }
		public int DepartmentId { get; set; }
		public string DepartmentName { get; set; }
	}
}
