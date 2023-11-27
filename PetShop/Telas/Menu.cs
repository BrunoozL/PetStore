using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.Telas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();

            this.Hide();
            Menu menu = new Menu();
            menu.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Show();

            this.Hide();
            Menu menu = new Menu();
            menu.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cliente cliente= new Cliente();
            cliente.Show();

            this.Hide();
            Menu menu = new Menu();
            menu.Close();
        }

        private void BtnListCliente_Click(object sender, EventArgs e)
        {
            ListagemCliente form= new ListagemCliente();
            form.Show();

            this.Hide();
            Menu menu = new Menu();
            menu.Close();
        }
    }
}
