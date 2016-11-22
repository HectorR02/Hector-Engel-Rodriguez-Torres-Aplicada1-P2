using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class ClientesBLL
    {
        public static bool Insertar(Clientes cliente)
        {
            bool resultado = false;
            using (var conexion = new Parcial2Db())
            {
                try
                {
                    var con = conexion.Cliente.Add(cliente);
                    //foreach (var tipo in cliente.TipoTelefonos)
                    //{
                    //    conexion.Entry(tipo).State = EntityState.Unchanged;
                    //}
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    throw;
                }
            }
            return resultado;
        }
        public static Clientes Buscar(int clienteId)
        {
            Clientes cliente = new Clientes();
            using (var conexion = new Parcial2Db())
            {
                try
                {
                    cliente = conexion.Cliente.Find(clienteId);
                    if (cliente != null)
                        cliente.TipoTelefonos.Count();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return cliente;
        }
        public static bool Eliminar(Clientes cliente)
        {
            bool resultado = false;
            using (var conexion = new Parcial2Db())
            {
                try
                {
                    conexion.Entry(cliente).State = EntityState.Deleted;
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    throw;
                }
            }
            return resultado;
        }
        public static List<Clientes> GetList()
        {
            List<Clientes> clientes = new List<Clientes>();
            using (var conexion = new Parcial2Db())
            {
                try
                {
                    clientes = conexion.Cliente.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return clientes;
        }
        public static Clientes Buscar(string nombres, DateTime fecha)
        {
            Clientes cliente = null;
            using (var conexion = new Parcial2Db())
            {
                try
                {
                    //var conexion
                    //cliente = from c in conexion.Cliente where(c.Nombres == nombres && DateTime.Compare(fecha, c.FechaNacimiento) >= 0) select c;
                    //return conexion.Cliente.Where(c => c.Nombres.Equals(nombres) && DateTime.Compare(fecha, c.FechaNacimiento) >= 0);
                    //cliente = conexion.Cliente.Where(c => c.Nombres == nombres && DateTime.Compare(fecha, c.FechaNacimiento) >= 0);
                    foreach (var clientes in GetList())
                    {
                        if(clientes.Nombres.Equals(nombres) && DateTime.Compare(clientes.FechaNacimiento, fecha) >= 0)
                        {
                            cliente = Buscar(clientes.ClienteId);
                            break;
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    throw;
                }
            }
            return cliente;
        }

    }
}
