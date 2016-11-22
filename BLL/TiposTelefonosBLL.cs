using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TiposTelefonosBLL
    {
        public static bool Insertar(TiposTelefonos tipoTelefono)
        {
            bool resultado = false;
            using (var conexion = new Parcial2Db())
            {
                try
                {
                    conexion.TipoTelefono.Add(tipoTelefono);
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
        public static TiposTelefonos Buscar(int tipoId)
        {
            TiposTelefonos tipo = new TiposTelefonos();
            using (var conexion = new Parcial2Db())
            {
                try
                {
                    tipo = conexion.TipoTelefono.Find(tipoId);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return tipo;
        }
        public static bool Eliminar(TiposTelefonos tipoTelefono)
        {
            bool resultado = false;
            using (var conexion = new Parcial2Db())
            {
                try
                {
                    conexion.TipoTelefono.Remove(tipoTelefono);
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
        public static List<TiposTelefonos> GetList()
        {
            List<TiposTelefonos> tipos = new List<TiposTelefonos>();
            using (var conexion = new Parcial2Db())
            {
                try
                {
                    tipos = conexion.TipoTelefono.Where(tt => tt.Telefono == null).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return tipos;
        }
    }
}
