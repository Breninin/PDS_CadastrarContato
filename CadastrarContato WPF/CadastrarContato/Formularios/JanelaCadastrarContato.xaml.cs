using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CadastrarContato.RegrasDeNegocio;
using MeusComponentes.Interacoes;
using MySql.Data.MySqlClient;

namespace CadastrarContato.Formularios
{
    /// <summary>
    /// Lógica interna para JanelaCadastrarContato.xaml
    /// </summary>
    public partial class JanelaCadastrarContato : Window
    {
        public JanelaCadastrarContato()
        {
            InitializeComponent();
            Conexao.ConexaoBD();
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            string resp = Mensagem.Pergunta("Deseja mesmo cancelar?", "CANCELAR CADASTRO");
            if (resp.ToLower() == "sim")
            {
                this.Close();
            }
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (edNome.Text != "" && edSexo.Text != "" && edTelefone.Text != "" && edEmail.Text != "")
            {
                try
                {
                    var nome = edNome.Text;
                    var sexo = edSexo.Text;
                    var telefone = edTelefone.Text;
                    var email = edEmail.Text;
                    var data = Convert.ToDateTime(dtNascimento.Text).ToString("yyyy-MM-dd");

                    var sql = "insert into contato (con_nome, con_sexo, con_email, con_telefone, con_data_nasc) values (@_nome, @_sexo, @_email, @_telefone, @_data)";
                    var comando = new MySqlCommand(sql, Conexao._conexao);

                    comando.Parameters.AddWithValue("@_nome", nome);
                    comando.Parameters.AddWithValue("@_sexo", sexo);
                    comando.Parameters.AddWithValue("@_telefone", telefone);
                    comando.Parameters.AddWithValue("@_email", email);
                    comando.Parameters.AddWithValue("@_data", data);
                    comando.ExecuteNonQuery();

                    Conexao._conexao.Close();

                    Mensagem.Informacao("O cadastro foi concluido com sucesso", "SUCESSO");

                    this.Close();
                }
                catch (Exception ex)
                {
                    Mensagem.Erro("Ocorreu um erro durante o cadastro. Contate a equipe de suporte do sistema. Erro: " + ex.ToString(), "ERRO");
                }
            }
            else
            {
                Mensagem.Erro("Ocorreu um erro durante o cadastro. Preencha todos os campos para realizar o cadastro.", "ERRO");
            }
        }
    }
}
