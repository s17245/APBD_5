using APBD_cw_3.DAL;
using Microsoft.AspNetCore.Mvc;

namespace APBD_cw_3.Controllers
{
    [ApiController]
    [Route("api/students")]

    public class StudentsController : ControllerBase
    {
        private IDbService _dbService;

        public StudentsController (IDbService dbService)
        {
            _dbService = dbService;

        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_dbService.GetStudents());
        }
       

        [HttpGet("{id}")]
        public IActionResult GetEnrollment(string id)
        {
            return Ok(_dbService.GetEnrollment(id));
        }



    }
}