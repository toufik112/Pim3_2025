namespace Pim3_2025.TelasDeBibliotecario
{
    partial class UcBiblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBiblioteca));
            label9 = new Label();
            pictureBox1 = new PictureBox();
            dtgrdEstoque_Bibliotecario = new DataGridView();
            idLivro = new DataGridViewTextBoxColumn();
            TituloLivro = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Editora = new DataGridViewTextBoxColumn();
            AnoPublicacao = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgrdEstoque_Bibliotecario).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.Location = new Point(188, 90);
            label9.Name = "label9";
            label9.Size = new Size(140, 38);
            label9.TabIndex = 24;
            label9.Text = "ESTOQUE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // dtgrdEstoque_Bibliotecario
            // 
            dtgrdEstoque_Bibliotecario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrdEstoque_Bibliotecario.Columns.AddRange(new DataGridViewColumn[] { idLivro, TituloLivro, Autor, Categoria, Editora, AnoPublicacao, Quantidade });
            dtgrdEstoque_Bibliotecario.Location = new Point(107, 175);
            dtgrdEstoque_Bibliotecario.Name = "dtgrdEstoque_Bibliotecario";
            dtgrdEstoque_Bibliotecario.RowHeadersWidth = 51;
            dtgrdEstoque_Bibliotecario.Size = new Size(1312, 555);
            dtgrdEstoque_Bibliotecario.TabIndex = 25;
            // 
            // idLivro
            // 
            idLivro.HeaderText = "ID Livro";
            idLivro.MinimumWidth = 6;
            idLivro.Name = "idLivro";
            idLivro.ReadOnly = true;
            idLivro.Width = 70;
            // 
            // TituloLivro
            // 
            TituloLivro.HeaderText = "Titulo Livro";
            TituloLivro.MinimumWidth = 6;
            TituloLivro.Name = "TituloLivro";
            TituloLivro.ReadOnly = true;
            TituloLivro.Width = 250;
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.MinimumWidth = 6;
            Autor.Name = "Autor";
            Autor.ReadOnly = true;
            Autor.Width = 210;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 170;
            // 
            // Editora
            // 
            Editora.HeaderText = "Editora";
            Editora.MinimumWidth = 6;
            Editora.Name = "Editora";
            Editora.ReadOnly = true;
            Editora.Width = 237;
            // 
            // AnoPublicacao
            // 
            AnoPublicacao.HeaderText = "Ano de Publicação";
            AnoPublicacao.MinimumWidth = 6;
            AnoPublicacao.Name = "AnoPublicacao";
            AnoPublicacao.ReadOnly = true;
            AnoPublicacao.Width = 170;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 6;
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            Quantidade.Width = 150;
            // 
            // UcBiblioteca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgrdEstoque_Bibliotecario);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Name = "UcBiblioteca";
            Size = new Size(1534, 745);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgrdEstoque_Bibliotecario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private PictureBox pictureBox1;
        private DataGridView dtgrdEstoque_Bibliotecario;
        private DataGridViewTextBoxColumn idLivro;
        private DataGridViewTextBoxColumn TituloLivro;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Editora;
        private DataGridViewTextBoxColumn AnoPublicacao;
        private DataGridViewTextBoxColumn Quantidade;
    }
}
