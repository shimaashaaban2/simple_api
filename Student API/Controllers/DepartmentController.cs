using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student_API.Models;

namespace Student_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        [HttpGet]

        public List<Department> GetAll() 
        {
            return new List<Department>();
        }
    }
}
