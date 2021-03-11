using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamosCEICU.Clases_de_Dominio
{
    public class Zapatillas : Material
    {
        //Atributos de la clase.
        private int aCantidadEnchufes;

        //Constructores de la clase.
        public Zapatillas(int pCodigo, int pCantidadEnchufes, string pObservacion) : base(pCodigo, pObservacion)
        {
            aCantidadEnchufes = pCantidadEnchufes;
        }

        //Getters y Setters de la clase.
        [Column("Cantidad de Enchufes")]
        public int CantidadEnchufes
        {
            get { return aCantidadEnchufes; }
            set { aCantidadEnchufes = value; }
        }
    }
}
