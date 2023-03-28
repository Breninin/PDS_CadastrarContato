using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeusComponentes.Interacoes;
using System.IO;
using Aula01.RegrasDeNegocio;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Aula01.Formularios
{
    public partial class FormCadastrarContato : Form
    {
        public FormCadastrarContato()
        {
            InitializeComponent();

            Conexao.ConexaoBD();

            dtpDataDeNascimento.Format = DateTimePickerFormat.Custom;
            dtpDataDeNascimento.CustomFormat = "yyyy-MM-dd ";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            string resp = Mensagem.Pergunta("Deseja mesmo cancelar?", "CANCELAR CADASTRO");
            if (resp.ToLower() == "sim")
            {
                FormCadastrarContato form = this;
                form.Close();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (edNome.Text != "" && edSexo.Text != "" && edTelefone.Text != "" && edEmail.Text != "")
            {
                try
                {
                    var nome = edNome.Text;
                    var sexo = edSexo.Text;
                    var telefone = edTelefone.Text;
                    var email = edEmail.Text;
                    var data = dtpDataDeNascimento.Text;

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

                    FormCadastrarContato form = this;
                    form.Close();
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
