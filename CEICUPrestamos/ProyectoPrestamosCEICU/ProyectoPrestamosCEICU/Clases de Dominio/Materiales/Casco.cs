using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamosCEICU.Clases_de_Dominio
{
    public class Casco : Material
    {
        //Atributos de la clase.
        private string aColor;

        //Constructor de la clase.
        public Casco(int pCodigo, string pColor, string pObservacion) : base(pCodigo, pObservacion)
        {
            aColor = pColor;
        }

        //Propiedades de la clase.
        [Column("Color")]
        public string Color
        {
            get { return aColor; }
            set { aColor = value; }
        }
    }
}
