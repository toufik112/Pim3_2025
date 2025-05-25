﻿namespace Pim3_2025.TelasDeBibliotecario
{
    partial class UcLivrosCadastrados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcLivrosCadastrados));
            dtgrdEstoque_Bibliotecario = new DataGridView();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            idLivro = new DataGridViewTextBoxColumn();
            TituloLivro = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            AnoPublicacao = new DataGridViewTextBoxColumn();
            CodigoFuncionario = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            DataCadastro = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgrdEstoque_Bibliotecario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgrdEstoque_Bibliotecario
            // 
            dtgrdEstoque_Bibliotecario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrdEstoque_Bibliotecario.Columns.AddRange(new DataGridViewColumn[] { idLivro, TituloLivro, Autor, AnoPublicacao, CodigoFuncionario, Quantidade, DataCadastro });
            dtgrdEstoque_Bibliotecario.Location = new Point(108, 175);
            dtgrdEstoque_Bibliotecario.Name = "dtgrdEstoque_Bibliotecario";
            dtgrdEstoque_Bibliotecario.RowHeadersWidth = 51;
            dtgrdEstoque_Bibliotecario.Size = new Size(1312, 555);
            dtgrdEstoque_Bibliotecario.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.Location = new Point(189, 90);
            label9.Name = "label9";
            label9.Size = new Size(261, 38);
            label9.TabIndex = 27;
            label9.Text = "Livros Cadastrados";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
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
            // AnoPublicacao
            // 
            AnoPublicacao.HeaderText = "Ano de Publicação";
            AnoPublicacao.MinimumWidth = 6;
            AnoPublicacao.Name = "AnoPublicacao";
            AnoPublicacao.ReadOnly = true;
            AnoPublicacao.Width = 170;
            // 
            // CodigoFuncionario
            // 
            CodigoFuncionario.HeaderText = "Codigo Funcionario";
            CodigoFuncionario.MinimumWidth = 6;
            CodigoFuncionario.Name = "CodigoFuncionario";
            CodigoFuncionario.ReadOnly = true;
            CodigoFuncionario.Width = 237;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 6;
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            Quantidade.Width = 150;
            // 
            // DataCadastro
            // 
            DataCadastro.HeaderText = "Data Cadastro";
            DataCadastro.MinimumWidth = 6;
            DataCadastro.Name = "DataCadastro";
            DataCadastro.ReadOnly = true;
            DataCadastro.Width = 170;
            // 
            // UcLivrosCadastrados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgrdEstoque_Bibliotecario);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Name = "UcLivrosCadastrados";
            Size = new Size(1534, 745);
            ((System.ComponentModel.ISupportInitialize)dtgrdEstoque_Bibliotecario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgrdEstoque_Bibliotecario;
        private Label label9;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn idLivro;
        private DataGridViewTextBoxColumn TituloLivro;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn AnoPublicacao;
        private DataGridViewTextBoxColumn CodigoFuncionario;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn DataCadastro;
    }
}
