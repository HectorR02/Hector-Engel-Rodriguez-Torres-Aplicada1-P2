using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hector_Engel_Rodriguez_Torres_Aplicada1_P2
{
    public partial class RegistroClientes : Form
    {
        Clientes nuevo;
        List<TiposTelefonos> tipos;
        public RegistroClientes()
        {
            InitializeComponent();
            GenerarTipos();
            nuevo = new Clientes();
            tipos = new List<TiposTelefonos>();
        }

        public void GenerarTipos()
        {
            TiposTelefonos tt = new TiposTelefonos("Celular");
            TiposTelefonos tt1 = new TiposTelefonos("Fijo");
            TiposTelefonos tt2 = new TiposTelefonos("Oficina");
            TiposTelefonos tt3 = new TiposTelefonos("Internacional");

            BLL.TiposTelefonosBLL.Insertar(tt);
            BLL.TiposTelefonosBLL.Insertar(tt1);
            BLL.TiposTelefonosBLL.Insertar(tt2);
            BLL.TiposTelefonosBLL.Insertar(tt3);

            TiposTelefonoscomboBox.DataSource = BLL.TiposTelefonosBLL.GetList();
            TiposTelefonoscomboBox.ValueMember = "TipoId";
            TiposTelefonoscomboBox.DisplayMember = "Descripcion";
        }

        private Double ToDouble(string texto)
        {
            Double numero;
            Double.TryParse(texto, out numero);

            return numero;
        }

        private int ToInt(string texto)
        {
            int numero;
            int.TryParse(texto, out numero);
            return numero;
        }

        public Clientes GenerarCliente()
        {
            Clientes cliente = new Clientes();
            if(!string.IsNullOrEmpty(NombrestextBox.Text))
            {
                if(!string.IsNullOrEmpty(LimiteCreditotextBox.Text))
                {
                    cliente.Nombres = NombrestextBox.Text;
                    cliente.FechaNacimiento = FechaNacimientodateTimePicker1.Value;
                    cliente.LimiteCredito = ToDouble(LimiteCreditotextBox.Text);
                    cliente.TipoTelefonos = tipos;
                }
                else
                {
                    LimiteCreditotextBox.Focus();
                }
            }
            else
            {
                NombrestextBox.Focus();
            }
            return cliente;
        }

        public void LimpiarCampos()
        {
            nuevo = new Clientes();
            tipos = new List<TiposTelefonos>();
            IdtextBox1.Clear();
            NombrestextBox.Clear();
            FechaNacimientodateTimePicker1.Value = DateTime.Today;
            LimiteCreditotextBox.Clear();
            TiposTelefonosdataGridView1.DataSource = null;
            NombrestextBox.Focus();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            nuevo = GenerarCliente();
            if (nuevo != null)
            {
                if (BLL.ClientesBLL.Insertar(nuevo))
                    MessageBox.Show("Cliente registrado con exito...", "-- Transaccion Exitosa --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo registrar", "-- Transaccion Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimpiarCampos();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdtextBox1.Text))
            {
                Clientes cliente = BLL.ClientesBLL.Buscar(ToInt(IdtextBox1.Text));
                if (cliente != null)
                {
                    if (BLL.ClientesBLL.Eliminar(cliente))
                    {
                        MessageBox.Show("El cliente ha sido eliminado", "-- Transaccion Exitosa --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("No se pudo eliminar", "-- Transaccion Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El cliente no existe", "-- COnsulta Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                IdtextBox1.Focus();
            LimpiarCampos();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdtextBox1.Text))
            {
                Clientes cliente = BLL.ClientesBLL.Buscar(ToInt(IdtextBox1.Text));
                if (cliente != null)
                {
                    CargarDatos(cliente);
                }
                else
                    MessageBox.Show("El cliente no existe");
            }
            else
                IdtextBox1.Focus();
        }

        private void CargarDatos(Clientes cliente)
        {
            NombrestextBox.Text = cliente.Nombres;
            FechaNacimientodateTimePicker1.Value = cliente.FechaNacimiento;
            LimiteCreditotextBox.Text = cliente.LimiteCredito.ToString();
            TiposTelefonosdataGridView1.DataSource = null;
            TiposTelefonosdataGridView1.DataSource = cliente.TipoTelefonos;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            tipos.Add(new TiposTelefonos(TiposTelefonoscomboBox.Text, TelefonomaskedTextBox.Text));
            TiposTelefonosdataGridView1.DataSource = null;
            TiposTelefonosdataGridView1.DataSource = tipos;
        }

        private void RegistroClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
