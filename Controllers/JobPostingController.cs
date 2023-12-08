using HrDatabaseBackend.Model.JobPostingModel;
using HrDatabaseBackend.Services.JobPostingService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HrDatabaseBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPostingController : ControllerBase
    {
        private readonly IJobPostingService jobPostingService;

        public JobPostingController(IJobPostingService jobPostingService)
        {
            this.jobPostingService = jobPostingService;
        }
        // GET: api/<JobPostingController>
        [HttpGet]
        public ActionResult<List<JobPosting>> Get()
        {
            var results = jobPostingService.Get();
            return Ok(results);
        }

        // GET api/<JobPostingController>/5
        [HttpGet("{id}")]
        public ActionResult<JobPosting> Get(string id)
        {
            var jobposting = jobPostingService.Get(id);
            if (jobposting == null)
            {
                return NotFound($"jobposting with Id={id} not found");
            }
            return jobposting;
        }


        // POST api/<JobPostingController>
        [HttpPost]
        public ActionResult<JobPosting> Post([FromBody] JobPosting jobposting)
        {
            jobPostingService.Create(jobposting);
            return CreatedAtAction(nameof(Get), new { id = jobposting.Id }, jobposting);
        }

        // PUT api/<JobPostingController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] JobPosting jobposting)
        {
            var existingjobposting = jobPostingService.Get(id);
            if (existingjobposting == null)
            {
                return NotFound($"jobposting with Id={id} not found");
            }
            jobPostingService.Update(id, jobposting);
            return NoContent();
        }

        // DELETE api/<JobPostingController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {

            var existingjobposting = jobPostingService.Get(id);
            if (existingjobposting == null)
            {
                return NotFound($"jobposting with Id={id} not found");
            }
            jobPostingService.Remove(id);
            return NoContent();
        }
    }
}
