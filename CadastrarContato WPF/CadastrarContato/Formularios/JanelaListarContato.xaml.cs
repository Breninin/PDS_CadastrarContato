using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica interna para JanelaListarContato.xaml
    /// </summary>
    public partial class JanelaListarContato : Window
    {
        public JanelaListarContato()
        {
            InitializeComponent();
            Conexao.ConexaoBD();

            try
            {
                dgContato.ItemsSource = Conexao.CarregarDados();
            }
            catch (Exception ex)
            {
                Mensagem.Erro("Ocorreu um erro ao carregar as informações dos contatos. Contate a equipe de suporte do sistema. Erro: " + ex.ToString(), "ERRO!");
            }
        }
    }
}
