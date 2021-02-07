using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamosCEICU.Clases_de_Dominio
{
    
    public class CargadorPortatil : Material
    {
        //Atributos de la clase.
        private string aModelo;
        private string aColor;
        private double aCapacidadCarga;
        private string aPuertoSalida;

        //Constructor de la clase.
        public CargadorPortatil(int pCodigo, string pModelo, string pColor, double pCapacidadCarga, string pPuertoSalida, string pObservacion) : base(pCodigo, pObservacion)
        {
            aModelo = pModelo;
            aColor = pColor;
            aCapacidadCarga = pCapacidadCarga;
            aPuertoSalida = pPuertoSalida;
        }

        //Getters y Setters de la clase.
        [Column("Modelo")]
        public string Modelo
        {
            get { return aModelo; }
            set { aModelo = value; }
        }

        [Column("Color")]
        public string Color
        {
            get { return aColor; }
            set { aColor = value; }
        }

        [Column("Capacidad de Carga")]
        public double CapacidadCarga
        {
            get { return aCapacidadCarga; }
            set { aCapacidadCarga = value; }
        }

        [Column("Puerto de Salida")]
        public string PuertoSalida
        {
            get { return aPuertoSalida; }
            set { aPuertoSalida = value; }
        }
    }
}
