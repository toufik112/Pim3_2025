namespace Pim3_2025.TelasDeUsuario
{
    partial class TelaUsuarioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaUsuarioPrincipal));
            pnlPrincipalUsuario = new Panel();
            pictureBox2 = new PictureBox();
            btnSairUser = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            lbl = new Label();
            label10 = new Label();
            panel2 = new Panel();
            lblRegrasUser = new Label();
            lblHistoricoEmprestimoUser = new Label();
            lblDadosPessoalUser = new Label();
            lblDesconectar = new Label();
            label11 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            lblNotificasoesUser = new Label();
            lblFaqUser = new Label();
            lblLivrosFamososUser = new Label();
            lblTelaBuscaUser = new Label();
            label1 = new Label();
            pnlPrincipalUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipalUsuario
            // 
            pnlPrincipalUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipalUsuario.BackColor = SystemColors.Menu;
            pnlPrincipalUsuario.Controls.Add(label1);
            pnlPrincipalUsuario.Location = new Point(314, 240);
            pnlPrincipalUsuario.Name = "pnlPrincipalUsuario";
            pnlPrincipalUsuario.Size = new Size(1534, 745);
            pnlPrincipalUsuario.TabIndex = 5;
            pnlPrincipalUsuario.Paint += pnlPrincipalUsuario_Paint;
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
            // btnSairUser
            // 
            btnSairUser.BackColor = Color.Red;
            btnSairUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSairUser.ForeColor = Color.White;
            btnSairUser.Location = new Point(1560, 45);
            btnSairUser.Name = "btnSairUser";
            btnSairUser.Size = new Size(102, 47);
            btnSairUser.TabIndex = 7;
            btnSairUser.Text = "SAIR";
            btnSairUser.UseVisualStyleBackColor = false;
            btnSairUser.Click += btnSairUser_Click;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(19, 393);
            label8.Name = "label8";
            label8.Size = new Size(213, 23);
            label8.TabIndex = 0;
            label8.Text = "Informaçoes Da Biblioteca:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(237, 22);
            lbl.Name = "lbl";
            lbl.Size = new Size(149, 99);
            lbl.TabIndex = 0;
            lbl.Text = "Biblioteca\r\n     de \r\n   Povo";
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(4, 637);
            label10.Name = "label10";
            label10.Size = new Size(251, 115);
            label10.TabIndex = 0;
            label10.Text = "Endereço:\r\n    Av. das Nações Unidas,\r\n    1234 - Sala 501\r\n    Bairro Centro, São Paulo- SP,\r\n     04567-000, Brasil";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkViolet;
            panel2.Controls.Add(lblRegrasUser);
            panel2.Controls.Add(lblHistoricoEmprestimoUser);
            panel2.Controls.Add(lblDadosPessoalUser);
            panel2.Controls.Add(lblDesconectar);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(0, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 790);
            panel2.TabIndex = 4;
            // 
            // lblRegrasUser
            // 
            lblRegrasUser.AutoSize = true;
            lblRegrasUser.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblRegrasUser.ForeColor = Color.White;
            lblRegrasUser.Location = new Point(8, 223);
            lblRegrasUser.Name = "lblRegrasUser";
            lblRegrasUser.Size = new Size(246, 30);
            lblRegrasUser.TabIndex = 15;
            lblRegrasUser.Text = "Regras de Emprestimo";
            lblRegrasUser.Click += lblRegrasUser_Click;
            // 
            // lblHistoricoEmprestimoUser
            // 
            lblHistoricoEmprestimoUser.AutoSize = true;
            lblHistoricoEmprestimoUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHistoricoEmprestimoUser.ForeColor = Color.White;
            lblHistoricoEmprestimoUser.Location = new Point(0, 125);
            lblHistoricoEmprestimoUser.Name = "lblHistoricoEmprestimoUser";
            lblHistoricoEmprestimoUser.Size = new Size(251, 28);
            lblHistoricoEmprestimoUser.TabIndex = 14;
            lblHistoricoEmprestimoUser.Text = "Hestorico de Empréstimo";
            lblHistoricoEmprestimoUser.Click += lblHistoricoEmprestimoUser_Click;
            // 
            // lblDadosPessoalUser
            // 
            lblDadosPessoalUser.AutoSize = true;
            lblDadosPessoalUser.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDadosPessoalUser.ForeColor = Color.White;
            lblDadosPessoalUser.Location = new Point(12, 36);
            lblDadosPessoalUser.Name = "lblDadosPessoalUser";
            lblDadosPessoalUser.Size = new Size(160, 30);
            lblDadosPessoalUser.TabIndex = 12;
            lblDadosPessoalUser.Text = "Dados Pessoal";
            lblDadosPessoalUser.Click += lblDadosPessoalUser_Click;
            // 
            // lblDesconectar
            // 
            lblDesconectar.AutoSize = true;
            lblDesconectar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDesconectar.ForeColor = Color.White;
            lblDesconectar.Location = new Point(12, 310);
            lblDesconectar.Name = "lblDesconectar";
            lblDesconectar.Size = new Size(141, 30);
            lblDesconectar.TabIndex = 9;
            lblDesconectar.Text = "Desconectar";
            lblDesconectar.Click += lblDesconectar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(4, 554);
            label11.Name = "label11";
            label11.Size = new Size(252, 46);
            label11.TabIndex = 1;
            label11.Text = "E-mail:\r\nsuporte@bibliotecadepovo.com";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(12, 427);
            label9.Name = "label9";
            label9.Size = new Size(153, 92);
            label9.TabIndex = 0;
            label9.Text = "Telefone:\r\n    (11)123-456-789\r\n    (11)987-654-321\r\n    (11)159-753-852";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.Controls.Add(lblNotificasoesUser);
            panel1.Controls.Add(lblFaqUser);
            panel1.Controls.Add(lblLivrosFamososUser);
            panel1.Controls.Add(lblTelaBuscaUser);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnSairUser);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1897, 143);
            panel1.TabIndex = 3;
            // 
            // lblNotificasoesUser
            // 
            lblNotificasoesUser.AutoSize = true;
            lblNotificasoesUser.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblNotificasoesUser.ForeColor = Color.White;
            lblNotificasoesUser.Location = new Point(1051, 56);
            lblNotificasoesUser.Name = "lblNotificasoesUser";
            lblNotificasoesUser.Size = new Size(141, 30);
            lblNotificasoesUser.TabIndex = 15;
            lblNotificasoesUser.Text = "Notificaçoes";
            lblNotificasoesUser.Click += lblNotificasoesUser_Click;
            // 
            // lblFaqUser
            // 
            lblFaqUser.AutoSize = true;
            lblFaqUser.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblFaqUser.ForeColor = Color.White;
            lblFaqUser.Location = new Point(1301, 58);
            lblFaqUser.Name = "lblFaqUser";
            lblFaqUser.Size = new Size(55, 30);
            lblFaqUser.TabIndex = 11;
            lblFaqUser.Text = "FAQ";
            lblFaqUser.Click += lblFaqUser_Click;
            // 
            // lblLivrosFamososUser
            // 
            lblLivrosFamososUser.AutoSize = true;
            lblLivrosFamososUser.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblLivrosFamososUser.ForeColor = Color.White;
            lblLivrosFamososUser.Location = new Point(780, 54);
            lblLivrosFamososUser.Name = "lblLivrosFamososUser";
            lblLivrosFamososUser.Size = new Size(168, 30);
            lblLivrosFamososUser.TabIndex = 10;
            lblLivrosFamososUser.Text = "Livros Famosos";
            lblLivrosFamososUser.Click += lblLivrosFamososUser_Click;
            // 
            // lblTelaBuscaUser
            // 
            lblTelaBuscaUser.AutoSize = true;
            lblTelaBuscaUser.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTelaBuscaUser.ForeColor = Color.White;
            lblTelaBuscaUser.Location = new Point(538, 54);
            lblTelaBuscaUser.Name = "lblTelaBuscaUser";
            lblTelaBuscaUser.Size = new Size(152, 30);
            lblTelaBuscaUser.TabIndex = 8;
            lblTelaBuscaUser.Text = "Tela de Busca";
            lblTelaBuscaUser.Click += lblTelaBuscaUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("High Tower Text", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 160);
            label1.Name = "label1";
            label1.Size = new Size(980, 423);
            label1.TabIndex = 1;
            label1.Text = "     Bem Vindo\r\n            ao\r\nBiblioteca de Povo";
            // 
            // TelaUsuarioPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1897, 987);
            Controls.Add(pnlPrincipalUsuario);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TelaUsuarioPrincipal";
            Text = "TelaPrincipalUsuario";
            Load += TelaUsuarioPrincipal_Load;
            pnlPrincipalUsuario.ResumeLayout(false);
            pnlPrincipalUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal_Bibliotecario;
        private PictureBox pictureBox2;
        private Button btnSairUser;
        private PictureBox pictureBox1;
        private Label label8;
        private Label lbl;
        private Label label10;
        private Panel panel2;
        private Label label9;
        private Panel panel1;
        private Label label11;
        private Label lblHistoricoEmprestimoUser;
        private Label lblDadosPessoalUser;
        private Label lblTelaBuscaUser;
        private Label lblLivrosFamososUser;
        private Label lblDesconectar;
        private Label lblFaqUser;
        private Label lblRegrasUser;
        private Label lblNotificasoesUser;
        public Panel pnlPrincipalUsuario;
        private Guna.UI2.WinForms.Guna2TextBox tbxBuscarUsuario;
        private Label label1;
        private Button button1;
    }
}