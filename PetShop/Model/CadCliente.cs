using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using MySql.Data.MySqlClient;

namespace PetShop.Model
{
    public class CadCliente
    {
        public int id { get; set; }
        public string nome_do_cliente { get; set; }
        public string telefone { get; set; }
        public string cep { get; set; }
        public string cpf { get; set; }


        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("INSERT INTO cliente (nome_do_cliente, telefone, cep, cpf)" +
                    "VALUES (@nome_do_cliente, @telefone, @cep, @cpf)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome_do_cliente", nome_do_cliente);
                Banco.Comando.Parameters.AddWithValue("@telefone", telefone);
                Banco.Comando.Parameters.AddWithValue("@cep", cep);
                Banco.Comando.Parameters.AddWithValue("@cpf", cpf);
                Banco.Comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("SELECT * FROM cliente", Banco.Conexao);
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);

                Banco.FecharConexao();

                return Banco.datTabela;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
