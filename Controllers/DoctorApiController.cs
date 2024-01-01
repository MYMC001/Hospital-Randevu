using Hospital_Randevu.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Hospital_Randevu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorApiController : ControllerBase
    {
        public HospitalDbContext _Context;
        public DoctorApiController(HospitalDbContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetDoctors()
        {
            var GetDoctors = await _Context.Doctors.ToListAsync();

            return Ok(GetDoctors);

        }
        //Get Travel By ID 

        [HttpGet("{id}")]

        public async Task<ActionResult> GetTravel(int? id)
        {
            var GetDoctor= await _Context.Doctors.FindAsync(id);

            return Ok(GetDoctor);

        }

        //Post Travel 
        //iejgikjfi
        [HttpPost]
        public async Task<ActionResult> PostTravel(Doctor doctor)
        {
            _Context.Doctors.Add(doctor);
            await _Context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTravel), new { id = doctor.DoctorID }, doctor);
        }


        //Put Travel

        [HttpPut("{id}")]

        public async Task<ActionResult> PutTravel(int id, Doctor doctor)
        {
            _Context.Entry(doctor).State = EntityState.Modified;
            await _Context.SaveChangesAsync();

            return NoContent();
        }


        [HttpDelete("{id}")]


        public async Task<ActionResult> DeleteTravel(int id)
        {
            var doctor= await _Context.Doctors.FindAsync(id);

            _Context.Doctors.Remove(doctor);
            await _Context.SaveChangesAsync();

            return NoContent();
        }

    }
}
