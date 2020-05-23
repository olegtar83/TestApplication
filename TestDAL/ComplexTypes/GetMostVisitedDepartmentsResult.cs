using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestDAL.ComplexTypes
{
	[ComplexType]
	public class GetMostVisitedDepartmentsResult
	{
		public string Name { get; set; }
		public int Total { get; set; }
	}
}
