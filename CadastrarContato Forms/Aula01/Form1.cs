using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula01.Formularios;

namespace Aula01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrarContato_Click(object sender, EventArgs e)
        {
            FormCadastrarContato form = new FormCadastrarContato();
            form.ShowDialog();
        }

        private void btListarContato_Click(object sender, EventArgs e)
        {
            FormListarContato form = new FormListarContato();
            form.ShowDialog();
        }
    }
}
