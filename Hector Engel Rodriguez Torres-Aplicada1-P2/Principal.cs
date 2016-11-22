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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ventana = new RegistroClientes();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ventana = new ConsultaCliente();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
