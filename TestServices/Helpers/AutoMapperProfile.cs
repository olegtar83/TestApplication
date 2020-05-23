using AutoMapper;
using TestDAL.ComplexTypes;
using TestDAL.DTO;
using TestDAL.Models;

namespace TestServices.Helpers
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<Departments, DepartmentDTO>();
			CreateMap<GetMostActiveEmployeesResult, MostActiveEmployeesDTO>();
			CreateMap<GetMostVisitedDepartmentsResult, MostVisitedDepartmentsDTO>();
		}
	}
}
