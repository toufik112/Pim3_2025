namespace Pim3_2025.Telas_De_Administrador
{
    partial class UcLivrosEmprestadosAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcLivrosEmprestadosAdm));
            dtgrLivrosEmprestados = new DataGridView();
            IDLIvro = new DataGridViewTextBoxColumn();
            TituloLivro = new DataGridViewTextBoxColumn();
            Isban = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            DataPrestar = new DataGridViewTextBoxColumn();
            DataDevolucao = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            lblCadaCliente = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgrLivrosEmprestados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgrLivrosEmprestados
            // 
            dtgrLivrosEmprestados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrLivrosEmprestados.Columns.AddRange(new DataGridViewColumn[] { IDLIvro, TituloLivro, Isban, Autor, Categoria, DataPrestar, DataDevolucao });
            dtgrLivrosEmprestados.Location = new Point(96, 175);
            dtgrLivrosEmprestados.Name = "dtgrLivrosEmprestados";
            dtgrLivrosEmprestados.RowHeadersWidth = 51;
            dtgrLivrosEmprestados.Size = new Size(1312, 555);
            dtgrLivrosEmprestados.TabIndex = 49;
            // 
            // IDLIvro
            // 
            IDLIvro.HeaderText = "ID Livro";
            IDLIvro.MinimumWidth = 6;
            IDLIvro.Name = "IDLIvro";
            IDLIvro.ReadOnly = true;
            IDLIvro.Width = 70;
            // 
            // TituloLivro
            // 
            TituloLivro.HeaderText = "Titulo de Livro";
            TituloLivro.MinimumWidth = 6;
            TituloLivro.Name = "TituloLivro";
            TituloLivro.ReadOnly = true;
            TituloLivro.Width = 270;
            // 
            // Isban
            // 
            Isban.HeaderText = "ISBAN";
            Isban.MinimumWidth = 6;
            Isban.Name = "Isban";
            Isban.Width = 227;
            // 
            // Autor
            // 
            Autor.HeaderText = "Nome Cliente";
            Autor.MinimumWidth = 6;
            Autor.Name = "Autor";
            Autor.ReadOnly = true;
            Autor.Width = 270;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "CPF";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 170;
            // 
            // DataPrestar
            // 
            DataPrestar.HeaderText = "Data de Prestar";
            DataPrestar.MinimumWidth = 6;
            DataPrestar.Name = "DataPrestar";
            DataPrestar.ReadOnly = true;
            DataPrestar.Width = 125;
            // 
            // DataDevolucao
            // 
            DataDevolucao.HeaderText = "Data de Devolução";
            DataDevolucao.MinimumWidth = 6;
            DataDevolucao.Name = "DataDevolucao";
            DataDevolucao.ReadOnly = true;
            DataDevolucao.Width = 125;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // lblCadaCliente
            // 
            lblCadaCliente.AutoSize = true;
            lblCadaCliente.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCadaCliente.Location = new Point(184, 90);
            lblCadaCliente.Name = "lblCadaCliente";
            lblCadaCliente.Size = new Size(306, 38);
            lblCadaCliente.TabIndex = 47;
            lblCadaCliente.Text = "LIVROS EMPRESTADO";
            // 
            // UcLivrosEmprestadosAdm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgrLivrosEmprestados);
            Controls.Add(pictureBox1);
            Controls.Add(lblCadaCliente);
            Name = "UcLivrosEmprestadosAdm";
            Size = new Size(1534, 745);
            ((System.ComponentModel.ISupportInitialize)dtgrLivrosEmprestados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgrLivrosEmprestados;
        private DataGridViewTextBoxColumn IDLIvro;
        private DataGridViewTextBoxColumn TituloLivro;
        private DataGridViewTextBoxColumn Isban;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn DataPrestar;
        private DataGridViewTextBoxColumn DataDevolucao;
        private PictureBox pictureBox1;
        private Label lblCadaCliente;
    }
}
