namespace Pim3_2025.TelasDeUsuario
{
    partial class UcResultadoBuscaLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcResultadoBuscaLivro));
            pictureBox1 = new PictureBox();
            lblresultadoBusca = new Label();
            dtgrHistoricoEmprestimo = new DataGridView();
            IDLIvro = new DataGridViewTextBoxColumn();
            TituloLivro = new DataGridViewTextBoxColumn();
            Isban = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Desponivel = new DataGridViewTextBoxColumn();
            Prateleira = new DataGridViewTextBoxColumn();
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
            // lblresultadoBusca
            // 
            lblresultadoBusca.AutoSize = true;
            lblresultadoBusca.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblresultadoBusca.Location = new Point(184, 90);
            lblresultadoBusca.Name = "lblresultadoBusca";
            lblresultadoBusca.Size = new Size(269, 38);
            lblresultadoBusca.TabIndex = 46;
            lblresultadoBusca.Text = "Resultado de Busca";
            // 
            // dtgrHistoricoEmprestimo
            // 
            dtgrHistoricoEmprestimo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrHistoricoEmprestimo.Columns.AddRange(new DataGridViewColumn[] { IDLIvro, TituloLivro, Isban, Categoria, Desponivel, Prateleira });
            dtgrHistoricoEmprestimo.Location = new Point(108, 247);
            dtgrHistoricoEmprestimo.Name = "dtgrHistoricoEmprestimo";
            dtgrHistoricoEmprestimo.RowHeadersWidth = 51;
            dtgrHistoricoEmprestimo.Size = new Size(1313, 195);
            dtgrHistoricoEmprestimo.TabIndex = 49;
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
            TituloLivro.Width = 300;
            // 
            // Isban
            // 
            Isban.HeaderText = "ISBAN";
            Isban.MinimumWidth = 6;
            Isban.Name = "Isban";
            Isban.Width = 300;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 250;
            // 
            // Desponivel
            // 
            Desponivel.HeaderText = "Desponivel";
            Desponivel.MinimumWidth = 6;
            Desponivel.Name = "Desponivel";
            Desponivel.ReadOnly = true;
            Desponivel.Width = 200;
            // 
            // Prateleira
            // 
            Prateleira.HeaderText = "Prateleira";
            Prateleira.MinimumWidth = 6;
            Prateleira.Name = "Prateleira";
            Prateleira.Width = 140;
            // 
            // UcResultadoBuscaLivro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgrHistoricoEmprestimo);
            Controls.Add(pictureBox1);
            Controls.Add(lblresultadoBusca);
            Name = "UcResultadoBuscaLivro";
            Size = new Size(1534, 745);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgrHistoricoEmprestimo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblresultadoBusca;
        private DataGridView dtgrHistoricoEmprestimo;
        private DataGridViewTextBoxColumn IDLIvro;
        private DataGridViewTextBoxColumn TituloLivro;
        private DataGridViewTextBoxColumn Isban;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Desponivel;
        private DataGridViewTextBoxColumn Prateleira;
    }
}
