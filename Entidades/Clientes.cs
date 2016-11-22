using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        [Key] 
        public int ClienteId { get; set; }

        public string Nombres { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public Double LimiteCredito { get; set; }

        public virtual List<TiposTelefonos> TipoTelefonos { get; set; }

        public Clientes(string nombres, DateTime fechaNacimiento, Double limiteCredito)
        {
            this.Nombres = nombres;
            this.FechaNacimiento = fechaNacimiento;
            this.LimiteCredito = limiteCredito;
            this.TipoTelefonos = new List<Entidades.TiposTelefonos>();
        }

        public Clientes()
        {
            this.TipoTelefonos = new List<Entidades.TiposTelefonos>();
        }
    }
}
