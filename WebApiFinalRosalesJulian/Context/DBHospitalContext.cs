using Microsoft.EntityFrameworkCore;
using WebApiFinalRosalesJulian.Models;

namespace WebApiFinalRosalesJulian.Context
{
    public class DBHospitalContext : DbContext
    {
        public DBHospitalContext()
        {
        }

        public DBHospitalContext(DbContextOptions<DBHospitalContext> options) : base(options)
        {
        }

        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Hospital> Hospitales { get; set; }
    }
}
