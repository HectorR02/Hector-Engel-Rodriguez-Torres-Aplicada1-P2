using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TiposTelefonos
    {
        [Key]
        public int TipoId { get; set; }

        public string Descripcion { get; set; }

        public string Telefono { get; set; }

        public List<Clientes> Clientes { get; set; }

        public TiposTelefonos(string descripcion, string telf)
        {
            this.Descripcion = descripcion;
            this.Telefono = telf;
            this.Clientes = new List<Entidades.Clientes>();
        }

        public TiposTelefonos(string descripcion)
        {
            this.Descripcion = descripcion;
            this.Clientes = new List<Entidades.Clientes>();
        }

        public TiposTelefonos()
        {
            this.Clientes = new List<Entidades.Clientes>();
        }
    }
}
