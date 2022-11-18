using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApiFinalRosalesJulian.Context;
using Microsoft.EntityFrameworkCore;
using WebApiFinalRosalesJulian.Models;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace WebApiFinalRosalesJulian.Controllers
{
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly DBHospitalContext context;
        public DoctorController(DBHospitalContext context)
        {
            this.context = context;
        }

        //GET /api/doctor
        [HttpGet]
        public ActionResult<IEnumerable<Doctor>> Get()
        {
            return context.Doctores.ToList();
        }

        //GET /api/doctor/DoctorNo/{Doctor_No}
        [HttpGet("DoctorNo/{Doctor_No}")]
        public ActionResult<Doctor> GetByDoctorNo(int Doctor_No)
        {
            Doctor doc = context.Doctores.Find(Doctor_No);

            if (doc == null)
            {
                return NotFound();
            }

            return doc;
        }

        //GET /api/doctor/especialidad/{especialidad}
        [HttpGet("especialidad/{especialidad}")]
        public ActionResult<IEnumerable<Doctor>> GetByEspecialidad(string especialidad)
        {
            List<Doctor> doctores = (from d in context.Doctores
                                     where d.Especialidad == especialidad
                                     select d).ToList();

            return doctores;
        }

        //POST /api/doctor
        [HttpPost]
        public ActionResult Post([FromBody] Doctor doctor)
        {
            if (!ModelState.IsValid)
            {
                return Conflict();
            }

            context.Doctores.Add(doctor);
            context.SaveChanges();

            return Ok();
        }

        //PUT /api/doctor/{Doctor_No}
        [HttpPut("{Doctor_No}")]
        public ActionResult Put(int Doctor_No, [FromBody] Doctor doctor)
        {
            if (Doctor_No != doctor.Doctor_No)
            {
                return BadRequest();
            }

            context.Entry(doctor).State = EntityState.Modified;
            context.SaveChanges();

            return Ok();
        }


        //DELETE /api/doctor/{Doctor_No}
        [HttpDelete("{Doctor_No}")]
        public ActionResult Delete(int Doctor_No)
        {
            var doctor = context.Doctores.Find(Doctor_No);
            if (doctor == null)
            {
                return NotFound();
            }

            context.Remove(doctor);
            context.SaveChanges();

            return Ok();
        }
    }
}
