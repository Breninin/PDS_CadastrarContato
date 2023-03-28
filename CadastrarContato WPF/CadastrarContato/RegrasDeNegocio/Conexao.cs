using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Documents;

namespace CadastrarContato.RegrasDeNegocio
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

        public static List<Contato> CarregarDados()
        {
            string query = "select * from contato";
            var comando = new MySqlCommand(query, _conexao);
            var reader = comando.ExecuteReader();

            var lista = new List<Contato>();

            while (reader.Read())
            {
                Contato contato = new Contato();

                contato.Id = reader.GetInt32(0);
                contato.Nome = reader.GetString(1);
                contato.Nascimento = reader.GetDateTime(2);
                contato.Sexo = reader.GetString(3);
                contato.Email = reader.GetString(4);
                contato.Telefone = reader.GetString(5);

                lista.Add(contato);
            }

            return lista;
        }
    }
}
