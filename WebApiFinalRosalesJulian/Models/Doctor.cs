using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiFinalRosalesJulian.Models
{
    public class Doctor
    {
        [Key]
        public int Doctor_No { get; set; }

        [Column(TypeName ="varchar(50)")]
        public string Apellido { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Especialidad { get; set; }

        [ForeignKey("Hospital")]
        public int Hospital_Cod { get; set; }

        public Hospital Hospital { get; set; }

        

    }
}
