using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestDAL.DTO;
using TestServices;

namespace TestApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        private readonly IRepoServices _repoServices;

        public CommonController(IRepoServices repoServices)
        {
            _repoServices = repoServices;
        }

        // GET: api/Common/getDepartments
        [HttpGet,Route("getDepartments")]
        public async Task<ActionResult<IEnumerable<DepartmentDTO>>> GetDepartments()
        {
            try
            {
                var departments = await _repoServices.GetAllDepartment();
                return new OkObjectResult(departments);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    code = 400,
                    title = ex.Message
                });
            }
        }
        // GET: api/Common/getMostVisitedDepartments
        [HttpGet, Route("getMostVisitedDepartments")]
        public async Task<ActionResult<IEnumerable<MostVisitedDepartmentsDTO>>> GetMostVisitedDepartments()
        {
            try
            {
                var result = await _repoServices.GetMostVisitedDepartments();
                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    code = 400,
                    title = ex.Message
                });
            }
        }

    // GET: api/Common/getMostActiveEmployees
    [HttpGet, Route("getMostActiveEmployees")]
        public async Task<ActionResult<IEnumerable<MostActiveEmployeesDTO>>> GetMostActiveEmployees()
        {
            try
            {
                var result = await _repoServices.GetMostActiveEmployees();
                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    code = 400,
                    title = ex.Message
                });
            }
        }

    }
}

