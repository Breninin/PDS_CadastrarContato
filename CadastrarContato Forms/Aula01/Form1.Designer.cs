namespace Aula01
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btListarContato = new System.Windows.Forms.Button();
            this.btCadastrarContato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Principal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btListarContato
            // 
            this.btListarContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarContato.Image = global::Aula01.Properties.Resources.Listar;
            this.btListarContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btListarContato.Location = new System.Drawing.Point(12, 130);
            this.btListarContato.Name = "btListarContato";
            this.btListarContato.Size = new System.Drawing.Size(320, 55);
            this.btListarContato.TabIndex = 2;
            this.btListarContato.Text = "Listar Contatos";
            this.btListarContato.UseVisualStyleBackColor = true;
            this.btListarContato.Click += new System.EventHandler(this.btListarContato_Click);
            // 
            // btCadastrarContato
            // 
            this.btCadastrarContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarContato.Image = global::Aula01.Properties.Resources.Adicionar_pessoa;
            this.btCadastrarContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrarContato.Location = new System.Drawing.Point(12, 69);
            this.btCadastrarContato.Name = "btCadastrarContato";
            this.btCadastrarContato.Size = new System.Drawing.Size(320, 55);
            this.btCadastrarContato.TabIndex = 1;
            this.btCadastrarContato.Text = "Cadastrar Contato";
            this.btCadastrarContato.UseVisualStyleBackColor = true;
            this.btCadastrarContato.Click += new System.EventHandler(this.btCadastrarContato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.btListarContato);
            this.Controls.Add(this.btCadastrarContato);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrarContato;
        private System.Windows.Forms.Button btListarContato;
    }
}

