using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PetShop.Telas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
