using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TestDAL.DTO;
using TestDAL.Models;

namespace TestServices.Helpers
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<Departments, DepertmentDTO>().ReverseMap();
		}
	}
}
