using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiFinalRosalesJulian.Context;
using WebApiFinalRosalesJulian.Models;
using System.Linq;

namespace WebApiFinalRosalesJulian.Controllers
{
    [Route("api/hospital")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly DBHospitalContext context;
        public HospitalController(DBHospitalContext context)
        {
            this.context = context;
        }

        //GET /api/hospital
        [HttpGet]
        public dynamic GetAll()
        {
            dynamic hospitales = (from h in context.Hospitales
                                         select new { h.Nombre, h.Telefono, h.Num_Cama });

            return hospitales;
        }

        //GET /api/hospital/{Num_Cama}
        [HttpGet("{NumCama}")]
        public dynamic GetByNumCam(int NumCama)
        {
            dynamic hospitales = (from h in context.Hospitales
                                  where h.Num_Cama >= NumCama
                                  select new { h.Nombre, h.Telefono, h.Num_Cama });

            return hospitales;
        }

    }
}
