namespace Pim3_2025.Telas_De_Administrador
{
    partial class TelaAdminPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAdminPrincipal));
            pnlPrincipalAdm = new Panel();
            label1 = new Label();
            lblCadastroLivros_TelaAdm = new Label();
            pictureBox2 = new PictureBox();
            btnSair_TelaAdm = new Button();
            lblEstoque_TelaAdm = new Label();
            lblDevolucao_TelaAdm = new Label();
            lblEmprestimo_TelaAdm = new Label();
            lblCadastroPessoa_TelaAdm = new Label();
            pictureBox1 = new PictureBox();
            lblSuspenderRetomarLivrosAdm = new Label();
            lblSuspenderRetomarClienteAdm = new Label();
            lblLivrosCadastradosAdm = new Label();
            lblBiblioteca = new Label();
            panel2 = new Panel();
            lblDesconectarAdm = new Label();
            lblLivrosEmprestadosAdm = new Label();
            lblSistemaAdm = new Label();
            lblPermissoesAdm = new Label();
            lblPerfiesAdm = new Label();
            lblClientesCadastradosAdm = new Label();
            panel1 = new Panel();
            pnlPrincipalAdm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipalAdm
            // 
            pnlPrincipalAdm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipalAdm.BackColor = SystemColors.Menu;
            pnlPrincipalAdm.Controls.Add(label1);
            pnlPrincipalAdm.Location = new Point(314, 240);
            pnlPrincipalAdm.Name = "pnlPrincipalAdm";
            pnlPrincipalAdm.Size = new Size(1534, 745);
            pnlPrincipalAdm.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("High Tower Text", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 160);
            label1.Name = "label1";
            label1.Size = new Size(980, 423);
            label1.TabIndex = 0;
            label1.Text = "     Bem Vindo\r\n            ao\r\nBiblioteca de Povo";
            // 
            // lblCadastroLivros_TelaAdm
            // 
            lblCadastroLivros_TelaAdm.AutoSize = true;
            lblCadastroLivros_TelaAdm.Cursor = Cursors.Hand;
            lblCadastroLivros_TelaAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblCadastroLivros_TelaAdm.ForeColor = Color.White;
            lblCadastroLivros_TelaAdm.Location = new Point(738, 58);
            lblCadastroLivros_TelaAdm.Name = "lblCadastroLivros_TelaAdm";
            lblCadastroLivros_TelaAdm.Size = new Size(168, 31);
            lblCadastroLivros_TelaAdm.TabIndex = 8;
            lblCadastroLivros_TelaAdm.Text = "Cadastro Livro";
            lblCadastroLivros_TelaAdm.Click += lblCadastroLivros_TelaAdm_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1744, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnSair_TelaAdm
            // 
            btnSair_TelaAdm.BackColor = Color.Red;
            btnSair_TelaAdm.Cursor = Cursors.Hand;
            btnSair_TelaAdm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair_TelaAdm.ForeColor = Color.White;
            btnSair_TelaAdm.Location = new Point(1559, 45);
            btnSair_TelaAdm.Name = "btnSair_TelaAdm";
            btnSair_TelaAdm.Size = new Size(102, 47);
            btnSair_TelaAdm.TabIndex = 7;
            btnSair_TelaAdm.Text = "SAIR";
            btnSair_TelaAdm.UseVisualStyleBackColor = false;
            // 
            // lblEstoque_TelaAdm
            // 
            lblEstoque_TelaAdm.AutoSize = true;
            lblEstoque_TelaAdm.Cursor = Cursors.Hand;
            lblEstoque_TelaAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblEstoque_TelaAdm.ForeColor = Color.White;
            lblEstoque_TelaAdm.Location = new Point(1391, 58);
            lblEstoque_TelaAdm.Name = "lblEstoque_TelaAdm";
            lblEstoque_TelaAdm.Size = new Size(99, 31);
            lblEstoque_TelaAdm.TabIndex = 6;
            lblEstoque_TelaAdm.Text = "Estoque";
            // 
            // lblDevolucao_TelaAdm
            // 
            lblDevolucao_TelaAdm.AutoSize = true;
            lblDevolucao_TelaAdm.Cursor = Cursors.Hand;
            lblDevolucao_TelaAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblDevolucao_TelaAdm.ForeColor = Color.White;
            lblDevolucao_TelaAdm.Location = new Point(1191, 58);
            lblDevolucao_TelaAdm.Name = "lblDevolucao_TelaAdm";
            lblDevolucao_TelaAdm.Size = new Size(127, 31);
            lblDevolucao_TelaAdm.TabIndex = 4;
            lblDevolucao_TelaAdm.Text = "Devolução";
            // 
            // lblEmprestimo_TelaAdm
            // 
            lblEmprestimo_TelaAdm.AutoSize = true;
            lblEmprestimo_TelaAdm.Cursor = Cursors.Hand;
            lblEmprestimo_TelaAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblEmprestimo_TelaAdm.ForeColor = Color.White;
            lblEmprestimo_TelaAdm.Location = new Point(975, 58);
            lblEmprestimo_TelaAdm.Name = "lblEmprestimo_TelaAdm";
            lblEmprestimo_TelaAdm.Size = new Size(143, 31);
            lblEmprestimo_TelaAdm.TabIndex = 3;
            lblEmprestimo_TelaAdm.Text = "Emprestimo";
            lblEmprestimo_TelaAdm.Click += lblEmprestimo_TelaAdm_Click;
            // 
            // lblCadastroPessoa_TelaAdm
            // 
            lblCadastroPessoa_TelaAdm.AutoSize = true;
            lblCadastroPessoa_TelaAdm.Cursor = Cursors.Hand;
            lblCadastroPessoa_TelaAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblCadastroPessoa_TelaAdm.ForeColor = Color.White;
            lblCadastroPessoa_TelaAdm.Location = new Point(482, 58);
            lblCadastroPessoa_TelaAdm.Name = "lblCadastroPessoa_TelaAdm";
            lblCadastroPessoa_TelaAdm.Size = new Size(185, 31);
            lblCadastroPessoa_TelaAdm.TabIndex = 1;
            lblCadastroPessoa_TelaAdm.Text = "Cadastro Pessoa";
            lblCadastroPessoa_TelaAdm.Click += lblCadastroCliente_TelaAdm_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblSuspenderRetomarLivrosAdm
            // 
            lblSuspenderRetomarLivrosAdm.AutoSize = true;
            lblSuspenderRetomarLivrosAdm.Cursor = Cursors.Hand;
            lblSuspenderRetomarLivrosAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblSuspenderRetomarLivrosAdm.ForeColor = Color.White;
            lblSuspenderRetomarLivrosAdm.Location = new Point(15, 640);
            lblSuspenderRetomarLivrosAdm.Name = "lblSuspenderRetomarLivrosAdm";
            lblSuspenderRetomarLivrosAdm.Size = new Size(227, 62);
            lblSuspenderRetomarLivrosAdm.TabIndex = 11;
            lblSuspenderRetomarLivrosAdm.Text = "Suspender/Retomar\r\n            Livro";
            // 
            // lblSuspenderRetomarClienteAdm
            // 
            lblSuspenderRetomarClienteAdm.AutoSize = true;
            lblSuspenderRetomarClienteAdm.Cursor = Cursors.Hand;
            lblSuspenderRetomarClienteAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblSuspenderRetomarClienteAdm.ForeColor = Color.White;
            lblSuspenderRetomarClienteAdm.Location = new Point(12, 546);
            lblSuspenderRetomarClienteAdm.Name = "lblSuspenderRetomarClienteAdm";
            lblSuspenderRetomarClienteAdm.Size = new Size(233, 62);
            lblSuspenderRetomarClienteAdm.TabIndex = 10;
            lblSuspenderRetomarClienteAdm.Text = "Suspender/Retomar \r\n          Cliente";
            // 
            // lblLivrosCadastradosAdm
            // 
            lblLivrosCadastradosAdm.AutoSize = true;
            lblLivrosCadastradosAdm.Cursor = Cursors.Hand;
            lblLivrosCadastradosAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblLivrosCadastradosAdm.ForeColor = Color.White;
            lblLivrosCadastradosAdm.Location = new Point(15, 456);
            lblLivrosCadastradosAdm.Name = "lblLivrosCadastradosAdm";
            lblLivrosCadastradosAdm.Size = new Size(214, 31);
            lblLivrosCadastradosAdm.TabIndex = 9;
            lblLivrosCadastradosAdm.Text = "Livros Cadastrados";
            // 
            // lblBiblioteca
            // 
            lblBiblioteca.AutoSize = true;
            lblBiblioteca.Cursor = Cursors.Hand;
            lblBiblioteca.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBiblioteca.ForeColor = Color.White;
            lblBiblioteca.Location = new Point(237, 18);
            lblBiblioteca.Name = "lblBiblioteca";
            lblBiblioteca.Size = new Size(161, 111);
            lblBiblioteca.TabIndex = 0;
            lblBiblioteca.Text = "Biblioteca\r\n     de \r\n   Povo";
            lblBiblioteca.TextAlign = ContentAlignment.MiddleLeft;
            lblBiblioteca.Click += lblBiblioteca_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkViolet;
            panel2.Controls.Add(lblDesconectarAdm);
            panel2.Controls.Add(lblLivrosEmprestadosAdm);
            panel2.Controls.Add(lblSistemaAdm);
            panel2.Controls.Add(lblPermissoesAdm);
            panel2.Controls.Add(lblPerfiesAdm);
            panel2.Controls.Add(lblSuspenderRetomarLivrosAdm);
            panel2.Controls.Add(lblSuspenderRetomarClienteAdm);
            panel2.Controls.Add(lblLivrosCadastradosAdm);
            panel2.Controls.Add(lblClientesCadastradosAdm);
            panel2.Location = new Point(0, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 790);
            panel2.TabIndex = 4;
            // 
            // lblDesconectarAdm
            // 
            lblDesconectarAdm.AutoSize = true;
            lblDesconectarAdm.Cursor = Cursors.Hand;
            lblDesconectarAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesconectarAdm.ForeColor = Color.White;
            lblDesconectarAdm.Location = new Point(19, 731);
            lblDesconectarAdm.Name = "lblDesconectarAdm";
            lblDesconectarAdm.Size = new Size(145, 31);
            lblDesconectarAdm.TabIndex = 16;
            lblDesconectarAdm.Text = "Desconectar";
            // 
            // lblLivrosEmprestadosAdm
            // 
            lblLivrosEmprestadosAdm.AutoSize = true;
            lblLivrosEmprestadosAdm.Cursor = Cursors.Hand;
            lblLivrosEmprestadosAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLivrosEmprestadosAdm.ForeColor = Color.White;
            lblLivrosEmprestadosAdm.Location = new Point(19, 292);
            lblLivrosEmprestadosAdm.Name = "lblLivrosEmprestadosAdm";
            lblLivrosEmprestadosAdm.Size = new Size(221, 31);
            lblLivrosEmprestadosAdm.TabIndex = 15;
            lblLivrosEmprestadosAdm.Text = "Livros Emprestados";
            // 
            // lblSistemaAdm
            // 
            lblSistemaAdm.AutoSize = true;
            lblSistemaAdm.Cursor = Cursors.Hand;
            lblSistemaAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSistemaAdm.ForeColor = Color.White;
            lblSistemaAdm.Location = new Point(19, 44);
            lblSistemaAdm.Name = "lblSistemaAdm";
            lblSistemaAdm.Size = new Size(98, 31);
            lblSistemaAdm.TabIndex = 14;
            lblSistemaAdm.Text = "Sistema";
            // 
            // lblPermissoesAdm
            // 
            lblPermissoesAdm.AutoSize = true;
            lblPermissoesAdm.Cursor = Cursors.Hand;
            lblPermissoesAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPermissoesAdm.ForeColor = Color.White;
            lblPermissoesAdm.Location = new Point(19, 207);
            lblPermissoesAdm.Name = "lblPermissoesAdm";
            lblPermissoesAdm.Size = new Size(132, 31);
            lblPermissoesAdm.TabIndex = 13;
            lblPermissoesAdm.Text = "Permissoes";
            // 
            // lblPerfiesAdm
            // 
            lblPerfiesAdm.AutoSize = true;
            lblPerfiesAdm.Cursor = Cursors.Hand;
            lblPerfiesAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerfiesAdm.ForeColor = Color.White;
            lblPerfiesAdm.Location = new Point(19, 123);
            lblPerfiesAdm.Name = "lblPerfiesAdm";
            lblPerfiesAdm.Size = new Size(87, 31);
            lblPerfiesAdm.TabIndex = 12;
            lblPerfiesAdm.Text = "Perfies";
            // 
            // lblClientesCadastradosAdm
            // 
            lblClientesCadastradosAdm.AutoSize = true;
            lblClientesCadastradosAdm.Cursor = Cursors.Hand;
            lblClientesCadastradosAdm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientesCadastradosAdm.ForeColor = Color.White;
            lblClientesCadastradosAdm.Location = new Point(15, 374);
            lblClientesCadastradosAdm.Name = "lblClientesCadastradosAdm";
            lblClientesCadastradosAdm.Size = new Size(235, 31);
            lblClientesCadastradosAdm.TabIndex = 8;
            lblClientesCadastradosAdm.Text = "Clientes Cadastrados";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.Controls.Add(lblCadastroLivros_TelaAdm);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnSair_TelaAdm);
            panel1.Controls.Add(lblEstoque_TelaAdm);
            panel1.Controls.Add(lblDevolucao_TelaAdm);
            panel1.Controls.Add(lblEmprestimo_TelaAdm);
            panel1.Controls.Add(lblCadastroPessoa_TelaAdm);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblBiblioteca);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1897, 143);
            panel1.TabIndex = 3;
            // 
            // TelaAdminPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1897, 987);
            Controls.Add(pnlPrincipalAdm);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TelaAdminPrincipal";
            Text = "TelaAdminPrincipal";
            pnlPrincipalAdm.ResumeLayout(false);
            pnlPrincipalAdm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipalAdm;
        private Label lblCadastroLivros_TelaAdm;
        private PictureBox pictureBox2;
        private Button btnSair_TelaAdm;
        private Label lblEstoque_TelaAdm;
        private Label lblDevolucao_TelaAdm;
        private Label lblEmprestimo_TelaAdm;
        private Label lblCadastroCliente_TelaAdm;
        private PictureBox pictureBox1;
        private Label lblSuspenderRetomarLivrosAdm;
        private Label lblSuspenderRetomarClienteAdm;
        private Label lblLivrosCadastradosAdm;
        private Label lblBiblioteca;
        private Panel panel2;
        private Label lblClientesCadastradosAdm;
        private Panel panel1;
        private Label lblSistemaAdm;
        private Label lblPermissoesAdm;
        private Label lblPerfiesAdm;
        private Label lblLivrosEmprestadosAdm;
        private Label label1;
        private Label lblDesconectarAdm;
        private Label lblCadastroPessoa_TelaAdm;
    }
}