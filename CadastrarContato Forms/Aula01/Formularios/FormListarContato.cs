using Aula01.RegrasDeNegocio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeusComponentes.Interacoes;

namespace Aula01.Formularios
{
    public partial class FormListarContato : Form
    {
        List<Contato> listaContato = new List<Contato>();

        public FormListarContato()
        {
            InitializeComponent();
            Conexao.ConexaoBD();

            try
            {
                dgvContato.DataSource = Conexao.CarregarDados();

                /*
                dgvContato.Columns["Nome"].Width= 216;
                dgvContato.Columns["Nascimento"].Width= 80;
                dgvContato.Columns["Sexo"].Width= 80;
                dgvContato.Columns["Email"].Width= 250;
                dgvContato.Columns["Telefone"].Width= 100;
                */
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Ocorreu um erro ao carregar as informações dos contatos. Contate a equipe de suporte do sistema. Erro: " + ex.ToString(), "ERRO!");
            }
        }
    }
}
