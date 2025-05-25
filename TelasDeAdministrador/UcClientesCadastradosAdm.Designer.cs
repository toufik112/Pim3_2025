namespace Pim3_2025.Telas_De_Administrador
{
    partial class UcClientesCadastradosAdm
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcClientesCadastradosAdm));
            dtgrClientesCadastrados = new DataGridView();
            IDLIvro = new DataGridViewTextBoxColumn();
            TituloLivro = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            DataDevolucao = new DataGridViewTextBoxColumn();
            Isban = new DataGridViewTextBoxColumn();
            DataPrestar = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            lblCadaCliente = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgrClientesCadastrados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgrClientesCadastrados
            // 
            dtgrClientesCadastrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrClientesCadastrados.Columns.AddRange(new DataGridViewColumn[] { IDLIvro, TituloLivro, Autor, DataDevolucao, Isban, DataPrestar, Categoria });
            dtgrClientesCadastrados.Location = new Point(107, 175);
            dtgrClientesCadastrados.Name = "dtgrClientesCadastrados";
            dtgrClientesCadastrados.RowHeadersWidth = 51;
            dtgrClientesCadastrados.Size = new Size(1312, 555);
            dtgrClientesCadastrados.TabIndex = 52;
            // 
            // IDLIvro
            // 
            IDLIvro.HeaderText = "ID Cliente";
            IDLIvro.MinimumWidth = 6;
            IDLIvro.Name = "IDLIvro";
            IDLIvro.ReadOnly = true;
            IDLIvro.Width = 70;
            // 
            // TituloLivro
            // 
            TituloLivro.HeaderText = "Nome Cliente";
            TituloLivro.MinimumWidth = 6;
            TituloLivro.Name = "TituloLivro";
            TituloLivro.ReadOnly = true;
            TituloLivro.Width = 260;
            // 
            // Autor
            // 
            Autor.HeaderText = "CPF";
            Autor.MinimumWidth = 6;
            Autor.Name = "Autor";
            Autor.ReadOnly = true;
            Autor.Width = 200;
            // 
            // DataDevolucao
            // 
            DataDevolucao.HeaderText = "RG/RNE";
            DataDevolucao.MinimumWidth = 6;
            DataDevolucao.Name = "DataDevolucao";
            DataDevolucao.ReadOnly = true;
            DataDevolucao.Width = 204;
            // 
            // Isban
            // 
            Isban.HeaderText = "Endereço";
            Isban.MinimumWidth = 6;
            Isban.Name = "Isban";
            Isban.Width = 227;
            // 
            // DataPrestar
            // 
            DataPrestar.HeaderText = "Telefone";
            DataPrestar.MinimumWidth = 6;
            DataPrestar.Name = "DataPrestar";
            DataPrestar.ReadOnly = true;
            DataPrestar.Width = 125;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Data Cadastro";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 170;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // lblCadaCliente
            // 
            lblCadaCliente.AutoSize = true;
            lblCadaCliente.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCadaCliente.Location = new Point(183, 90);
            lblCadaCliente.Name = "lblCadaCliente";
            lblCadaCliente.Size = new Size(355, 38);
            lblCadaCliente.TabIndex = 50;
            lblCadaCliente.Text = "CLIENTES CADASTRADOS";
            // 
            // UcClientesCadastradosAdm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgrClientesCadastrados);
            Controls.Add(pictureBox1);
            Controls.Add(lblCadaCliente);
            Name = "UcClientesCadastradosAdm";
            Size = new Size(1534, 745);
            ((System.ComponentModel.ISupportInitialize)dtgrClientesCadastrados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgrClientesCadastrados;
        private DataGridViewTextBoxColumn IDLIvro;
        private DataGridViewTextBoxColumn TituloLivro;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn DataDevolucao;
        private DataGridViewTextBoxColumn Isban;
        private DataGridViewTextBoxColumn DataPrestar;
        private DataGridViewTextBoxColumn Categoria;
        private PictureBox pictureBox1;
        private Label lblCadaCliente;
    }
}
