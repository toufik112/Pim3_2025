namespace Pim3_2025.TelasDeUsuario
{
    partial class UcHistorecoEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcHistorecoEmprestimo));
            pictureBox1 = new PictureBox();
            lblHistoricoEmprestimo = new Label();
            dtgrHistoricoEmprestimo = new DataGridView();
            IDLIvro = new DataGridViewTextBoxColumn();
            TituloLivro = new DataGridViewTextBoxColumn();
            Isban = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            DataPrestar = new DataGridViewTextBoxColumn();
            DataDevolucao = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgrHistoricoEmprestimo).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // lblHistoricoEmprestimo
            // 
            lblHistoricoEmprestimo.AutoSize = true;
            lblHistoricoEmprestimo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblHistoricoEmprestimo.Location = new Point(184, 90);
            lblHistoricoEmprestimo.Name = "lblHistoricoEmprestimo";
            lblHistoricoEmprestimo.Size = new Size(348, 38);
            lblHistoricoEmprestimo.TabIndex = 46;
            lblHistoricoEmprestimo.Text = "Historeco de Emprestimo";
            // 
            // dtgrHistoricoEmprestimo
            // 
            dtgrHistoricoEmprestimo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrHistoricoEmprestimo.Columns.AddRange(new DataGridViewColumn[] { IDLIvro, TituloLivro, Isban, Autor, DataPrestar, DataDevolucao, Categoria });
            dtgrHistoricoEmprestimo.Location = new Point(22, 175);
            dtgrHistoricoEmprestimo.Name = "dtgrHistoricoEmprestimo";
            dtgrHistoricoEmprestimo.RowHeadersWidth = 51;
            dtgrHistoricoEmprestimo.Size = new Size(1312, 555);
            dtgrHistoricoEmprestimo.TabIndex = 48;
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
            Autor.HeaderText = "Categoria";
            Autor.MinimumWidth = 6;
            Autor.Name = "Autor";
            Autor.ReadOnly = true;
            Autor.Width = 210;
            // 
            // DataPrestar
            // 
            DataPrestar.HeaderText = "Data de Prestar";
            DataPrestar.MinimumWidth = 6;
            DataPrestar.Name = "DataPrestar";
            DataPrestar.ReadOnly = true;
            DataPrestar.Width = 160;
            // 
            // DataDevolucao
            // 
            DataDevolucao.HeaderText = "Data prevista de Devolução";
            DataDevolucao.MinimumWidth = 6;
            DataDevolucao.Name = "DataDevolucao";
            DataDevolucao.ReadOnly = true;
            DataDevolucao.Width = 160;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "data Real de Devolução";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 160;
            // 
            // UcHistorecoEmprestimo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgrHistoricoEmprestimo);
            Controls.Add(pictureBox1);
            Controls.Add(lblHistoricoEmprestimo);
            Name = "UcHistorecoEmprestimo";
            Size = new Size(1360, 745);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgrHistoricoEmprestimo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblHistoricoEmprestimo;
        private DataGridView dtgrHistoricoEmprestimo;
        private DataGridViewTextBoxColumn IDLIvro;
        private DataGridViewTextBoxColumn TituloLivro;
        private DataGridViewTextBoxColumn Isban;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn DataPrestar;
        private DataGridViewTextBoxColumn DataDevolucao;
        private DataGridViewTextBoxColumn Categoria;
    }
}
