using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDAL.ComplexTypes;
using TestDAL.DTO;
using TestDAL.Models;
using TestDAL.Repositories;

namespace TestServices
{
	public class RepoServices : IRepoServices
	{
		IJTIRepo _JTIRepo;
		IMapper _mapper;
		public RepoServices(IJTIRepo jTIRepo, IMapper mapper)
		{
			_JTIRepo = jTIRepo;
			_mapper = mapper;
		}

		public async Task<List<DepartmentDTO>> GetAllDepartment()
		{
			return _mapper.Map<List<DepartmentDTO>>(await _JTIRepo.GetAllDepartments());
		}
		public async Task<List<MostActiveEmployeesDTO>> GetMostActiveEmployees()
		{
			return _mapper.Map<List<MostActiveEmployeesDTO>>(await _JTIRepo.GetMostActiveEmployes());
		}
		public async Task<List<MostVisitedDepartmentsDTO>> GetMostVisitedDepartments()
		{
			return _mapper.Map<List<MostVisitedDepartmentsDTO>>(await _JTIRepo.GetMostVisitedDepartments());
		}
	}
}
