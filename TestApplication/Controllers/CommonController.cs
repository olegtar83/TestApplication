using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        // GET: api/Common/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepertmentDTO>>> GetDepartments()
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

    }
}
