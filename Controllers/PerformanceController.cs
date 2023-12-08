using HrDatabaseBackend.Model.AttendanceModel;
using HrDatabaseBackend.Model.PerformanceModel;
using HrDatabaseBackend.Services.AttendanceService;
using HrDatabaseBackend.Services.PerformanceService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HrDatabaseBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerformanceController : ControllerBase
    {
        private readonly IPerformanceService performanceService;

        public PerformanceController(IPerformanceService performanceService)
        {
            this.performanceService = performanceService;
        }
        // GET: api/<PerformanceController>
        [HttpGet]
        public ActionResult<List<Performance>> Get()
        {
            return performanceService.Get();
        }

        // GET api/<PerformanceController>/5
        [HttpGet("{id}")]
        public ActionResult<Performance> Get(string id)
        {

            var performance = performanceService.Get(id);

            if (performance == null)
            {
                return NotFound($"performan with Id={id} not found");
            }
            return performance;
        }
        [HttpGet("/{employee_id}")]
        public ActionResult<Performance> Getbyemployeeid(string employee_id)
        {

            var performance = performanceService.Getbyemployeeid(employee_id);

            if (performance == null)
            {
                return NotFound($"performan with Id={employee_id} not found");
            }
            return performance;
        }

        // POST api/<PerformanceController>
        [HttpPost]
        public ActionResult<Performance> Post([FromBody] Performance performance)
        {
            performanceService.Create(performance);
            return CreatedAtAction(nameof(Get), new { id = performance.Id }, performance);
        }

        // PUT api/<PerformanceController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Performance performance)
        {

            var performances = performanceService.Get(id);
            if (performances == null)
            {
                return NotFound($"performance with Id={id} not found");
            }
            performanceService.Update(id, performance);
            return NoContent();
        }

        [HttpPut("/{employee_id}")]
        public ActionResult Putbyemployeeid(string employee_id, [FromBody] Performance performance)
        {

            var performances = performanceService.Getbyemployeeid(employee_id);
            if (performances == null)
            {
                return NotFound($"performance with Id={employee_id} not found");
            }
            performanceService.Updatebyemployeeid(employee_id, performance);
            return NoContent();
        }




        // DELETE api/<PerformanceController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string  id)
        {

            var performances = performanceService.Get(id);
            if (performances == null)
            {
                return NotFound($"performance with Id={id} not found");
            }
            performanceService.Remove(id);
            return NoContent();
        }
    }
}
