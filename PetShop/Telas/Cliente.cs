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
    public partial class Cliente : Form
    {
        CadCliente cliente;
        public Cliente()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            cliente = new CadCliente()
            {
                nome_do_cliente = txt_nome.Text,
                telefone = txt_telefone.Text,
                cep = txt_cep.Text,
                cpf = txt_cpf.Text
            };
            cliente.Incluir();

            Inicio inicio = new Inicio();
            inicio.Show();

            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
