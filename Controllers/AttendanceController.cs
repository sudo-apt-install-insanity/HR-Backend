using HrDatabaseBackend.Model.AttendanceModel;
using HrDatabaseBackend.Model.EmployeeModel;
using HrDatabaseBackend.Services.AttendanceService;
using HrDatabaseBackend.Services.EmployeeService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HrDatabaseBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendanceService attendanceService;

        public AttendanceController(IAttendanceService attendanceService)
        {
            this.attendanceService = attendanceService;
        }
        // GET: api/<AttendanceController>
        [HttpGet]
        public ActionResult<List<Attendance>> Get()
        {
            return attendanceService.Get();
        }

        // GET api/<AttendanceController>/5
        [HttpGet("{id}")]
        public ActionResult<Attendance> Get(string id)
        {

            var attendancemark = attendanceService.Get(id);
           
            if (attendancemark == null)
            {
                return NotFound($"attendance with Id={id} not found");
            }
            return attendancemark;
        }



        // POST api/<AttendanceController>
        [HttpPost]
        public ActionResult<Attendance> Post([FromBody] Attendance attendance)
        {
            attendanceService.Create(attendance);
            return CreatedAtAction(nameof(Get), new { id = attendance.Id }, attendance);
        }

        // PUT api/<AttendanceController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Attendance attendance)
        {

            var attendancemark = attendanceService.Get(id);
            if (attendancemark == null)
            {
                return NotFound($"employee with Id={id} not found");
            }
            attendanceService.Update(id, attendance);
            return NoContent();
        }

        // DELETE api/<AttendanceController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {

            var attendancemark = attendanceService.Get(id);
            if (attendancemark == null)
            {
                return NotFound($"employee with Id={id} not found");
            }
            attendanceService.Remove(id);
            return NoContent();
        }
    }
}
