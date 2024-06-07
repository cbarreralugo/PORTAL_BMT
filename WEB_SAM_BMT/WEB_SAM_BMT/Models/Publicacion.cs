using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB_SAM_BMT.Models
{
    [Table("tb_bmt_publicacion")]
    public class Publicacion
    {
        [Key]
        public int id_publicacion { get; set; }

        [Required]
        [StringLength(255)]
        public string nombre_app { get; set; }

        [StringLength(255)]
        public string ruta_origen { get; set; }

        [StringLength(255)]
        public string servidor { get; set; }

        public int tipo_publicacion { get; set; }
        public int tipo_app { get; set; }
        public bool SQL { get; set; }
        public DateTime fecha_publicacion { get; set; }

        [StringLength(255)]
        public string estatus { get; set; }

        public bool activo { get; set; }
    }
}
