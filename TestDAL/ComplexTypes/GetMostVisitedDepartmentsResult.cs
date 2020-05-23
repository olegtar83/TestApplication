using System.ComponentModel.DataAnnotations.Schema;

namespace TestDAL.ComplexTypes
{
	[ComplexType]
	public class GetMostVisitedDepartmentsResult
	{
		public string Name { get; set; }
		public int Total { get; set; }
	}
}
