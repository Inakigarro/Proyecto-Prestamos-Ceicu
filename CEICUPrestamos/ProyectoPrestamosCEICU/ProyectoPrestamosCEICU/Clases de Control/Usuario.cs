using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamosCEICU.Clases_de_Control
{
    public class Usuario
    {
        [Key]
        [Column("Legajo")]
        public string Legajo { get; set; }
        [Column("Contraseña")]
        public string Contraseña { get; set; }
    }
}
