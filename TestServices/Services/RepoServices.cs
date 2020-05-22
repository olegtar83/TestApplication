using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

		public async Task<IEnumerable<DepertmentDTO>> GetAllDepartment()
		{
			return _mapper.Map<IEnumerable<DepertmentDTO>>(await _JTIRepo.GetAllDepartments());
		}
	}
}
