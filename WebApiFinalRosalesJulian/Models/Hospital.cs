using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiFinalRosalesJulian.Models
{
    public class Hospital
    {
        [Key]
        public int Hospital_Cod { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Direccion { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Telefono { get; set; }

        public int Num_Cama { get; set; }

    }
}
