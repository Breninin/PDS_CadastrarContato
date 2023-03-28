using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.RegrasDeNegocio
{
    internal class Conexao
    {
        public static MySqlConnection _conexao;

        public static void ConexaoBD()
        {
            string conexaoString = "server=localhost;database=app_contato_bd_breno;user=root;password=root;port=3306";

            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();
        }

        public static DataTable CarregarDados()
        {
            string query = "select * from contato";
            var comando = new MySqlCommand(query, _conexao);
            var adaptador = new MySqlDataAdapter(comando);

            DataTable tabela = new DataTable();

            adaptador.Fill(tabela);

            tabela.Columns.Remove("con_id");

            tabela.Columns["con_nome"].ColumnName = "Nome";
            tabela.Columns["con_data_nasc"].ColumnName = "Nascimento";
            tabela.Columns["con_sexo"].ColumnName = "Sexo";
            tabela.Columns["con_email"].ColumnName = "Email";
            tabela.Columns["con_telefone"].ColumnName = "Telefone";

            return tabela;
        }
    }
}
