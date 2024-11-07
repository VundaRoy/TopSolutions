using Microsoft.AspNetCore.Mvc;
using TopSolutions.WebApi.Model;

namespace TopSolutions.WebApi.Controllers
{
    public class StaffController : Controller
    {
        private static List<Staff> staffList = new List<Staff>();
        // GET: api/Staff
        [HttpGet]
        public ActionResult<IEnumerable<Staff>> GetStaff()
        {
            return Ok(staffList);
        }

        // GET: api/Staff/5
        [HttpGet("{id}")]
        public ActionResult<Staff> GetStaff(int id)
        {
            var staff = staffList.FirstOrDefault(s => s.StaffId == id);
            if (staff == null)
            {
                return NotFound();
            }
            return Ok(staff);
        }

        // POST: api/Staff
        [HttpPost]
        public ActionResult<Staff> PostStaff(Staff staff)
        {
            staffList.Add(staff);
            return CreatedAtAction(nameof(GetStaff), new { id = staff.StaffId }, staff);
        }

        // PUT: api/Staff/5
        [HttpPut("{id}")]
        public IActionResult PutStaff(int id, Staff updatedStaff)
        {
            var staff = staffList.FirstOrDefault(s => s.StaffId == id);
            if (staff == null)
            {
                return NotFound();
            }

            staff.UserName = updatedStaff.UserName;
            staff.Address = updatedStaff.Address;
            staff.City = updatedStaff.City;
            staff.SubNationalEntity = updatedStaff.SubNationalEntity;
            staff.Country = updatedStaff.Country;

            return NoContent();
        }

        // DELETE: api/Staff/5
        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var staff = staffList.FirstOrDefault(s => s.StaffId == id);
            if (staff == null)
            {
                return NotFound();
            }

            staffList.Remove(staff);
            return NoContent();
        }

    }
}
