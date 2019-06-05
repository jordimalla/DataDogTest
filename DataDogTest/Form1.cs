using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataDogTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarGrid();
        }

        private void RefrescarGrid()
        {
            Negocio.ClienteBLL clienteBLL = new Negocio.ClienteBLL();
            List<Objetos.Cliente> clientes = clienteBLL.ObtenerTodosLosClientes();

            dgvClients.DataSource = clientes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefrescarGrid();
        }
    }
}
