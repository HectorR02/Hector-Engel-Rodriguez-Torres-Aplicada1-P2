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
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Nombres.Text))
            {
                var cliente = BLL.ClientesBLL.Buscar(NombrestextBox.Text, FechadateTimePicker.Value);
                if (cliente != null)
                {
                    TelefonosdataGridView1.DataSource = null;
                    TelefonosdataGridView1.DataSource = cliente.TipoTelefonos;
                }
                else
                {
                    MessageBox.Show("No existe");
                    NombrestextBox.Clear();
                    NombrestextBox.Focus();
                }
            }
            else
                NombrestextBox.Focus();
        }
    }
}
