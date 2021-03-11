using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamosCEICU.Clases_de_Dominio
{
    [Table("Materiales")]
    public class Material
    {
        //Atributos de la clase.
        private int aCodigo;
        private string aObservacion;

        //Constructores de la clase.
        public Material(int pMaterialId, string pObservacion)
        {
            aCodigo = pMaterialId;
            aObservacion = pObservacion;
        }

        //Setters y Getters de la clase.
        [Key]
        [Column("MaterialId")]
        public int Codigo
        {
            set { aCodigo = value; }
            get { return aCodigo; }
        }

        [Column("Observacion")]
        public string Observacion
        {
            get { return aObservacion; }
            set { aObservacion = value; }
        }
    }
}
