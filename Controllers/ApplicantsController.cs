using HrDatabaseBackend.Model.ApplicantsModel;
using HrDatabaseBackend.Model.EmployeeModel;
using HrDatabaseBackend.Services.ApplicantsService;
using HrDatabaseBackend.Services.EmployeeService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HrDatabaseBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantsController : ControllerBase
    {
        private readonly IApplicantsService applicantsService;

        public ApplicantsController(IApplicantsService applicantsService)
        {
            this.applicantsService = applicantsService;
        }
        // GET: api/<ApplicantsController>
        [HttpGet]
        public ActionResult<List<Applicants>> Get()
        {
            return applicantsService.Get();
        }

        // GET api/<ApplicantsController>/5
        [HttpGet("{id}")]
        public ActionResult<Applicants> Get(string id)
        {
            var applicants = applicantsService.Get(id);
            if (applicants == null)
            {
                return NotFound($"applicants with Id={id} not found");
            }
            return applicants;
        }

        // POST api/<ApplicantsController>
        [HttpPost]
        public ActionResult<Applicants> Post([FromBody]  Applicants applicants)
        {
            applicantsService.Create(applicants);
            return CreatedAtAction(nameof(Get), new { id = applicants.Id }, applicants);
        }

        // PUT api/<ApplicantsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Applicants applicants)
        {
            var existingemployee = applicantsService.Get(id);
            if (existingemployee == null)
            {
                return NotFound($"employee with Id={id} not found");
            }
            applicantsService.Update(id, applicants);
            return NoContent();
        }

        // DELETE api/<ApplicantsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var existingemployee = applicantsService.Get(id);
            if (existingemployee == null)
            {
                return NotFound($"applicants with Id={id} not found");
            }
            applicantsService.Remove(id);
            return NoContent();
        }
    }
}
