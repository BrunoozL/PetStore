using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PetShop.Model;

namespace PetShop.Telas
{
    public partial class ListagemCliente : Form
    {
        public ListagemCliente()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Hide();

            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void ListagemCliente_Load(object sender, EventArgs e)
        {
            CadCliente cliente = new CadCliente();
            dgv_cliente.DataSource = cliente.Consultar();
        }
    }
}
