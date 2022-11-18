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

        [Required]
        public Hospital Hospital { get; set; }

    }
}
