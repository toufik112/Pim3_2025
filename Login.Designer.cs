namespace Pim3_2025
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            fileSystemWatcher1 = new FileSystemWatcher();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblNaoTenhoCadastro = new Label();
            lblClickaAquiLogin = new Label();
            btnLogin = new Button();
            txbUsuarioLogin = new TextBox();
            txbSenhaLogin = new TextBox();
            pictureBox2 = new PictureBox();
            txbCodigoFuncionarioLogin = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = Color.Thistle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-143, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1108, 1118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkViolet;
            label1.Location = new Point(1086, 314);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkViolet;
            label2.Location = new Point(1086, 416);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 2;
            label2.Text = "SENHA";
            // 
            // lblNaoTenhoCadastro
            // 
            lblNaoTenhoCadastro.AutoSize = true;
            lblNaoTenhoCadastro.ForeColor = Color.DarkViolet;
            lblNaoTenhoCadastro.Location = new Point(1086, 532);
            lblNaoTenhoCadastro.Name = "lblNaoTenhoCadastro";
            lblNaoTenhoCadastro.Size = new Size(181, 20);
            lblNaoTenhoCadastro.TabIndex = 3;
            lblNaoTenhoCadastro.Text = "NÃO TENHO CADASTRO?";
            // 
            // lblClickaAquiLogin
            // 
            lblClickaAquiLogin.AutoSize = true;
            lblClickaAquiLogin.Cursor = Cursors.Hand;
            lblClickaAquiLogin.ForeColor = Color.Blue;
            lblClickaAquiLogin.Location = new Point(1275, 532);
            lblClickaAquiLogin.Name = "lblClickaAquiLogin";
            lblClickaAquiLogin.Size = new Size(96, 20);
            lblClickaAquiLogin.TabIndex = 4;
            lblClickaAquiLogin.Text = "CLICKA AQUI";
            lblClickaAquiLogin.Click += lblClickaAquiLogin_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Green;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(1182, 622);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 38);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txbUsuarioLogin
            // 
            txbUsuarioLogin.Location = new Point(1086, 353);
            txbUsuarioLogin.Name = "txbUsuarioLogin";
            txbUsuarioLogin.Size = new Size(275, 27);
            txbUsuarioLogin.TabIndex = 6;
            // 
            // txbSenhaLogin
            // 
            txbSenhaLogin.Location = new Point(1086, 454);
            txbSenhaLogin.Name = "txbSenhaLogin";
            txbSenhaLogin.Size = new Size(275, 27);
            txbSenhaLogin.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1131, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 124);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // txbCodigoFuncionarioLogin
            // 
            txbCodigoFuncionarioLogin.Location = new Point(1086, 248);
            txbCodigoFuncionarioLogin.Name = "txbCodigoFuncionarioLogin";
            txbCodigoFuncionarioLogin.Size = new Size(275, 27);
            txbCodigoFuncionarioLogin.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkViolet;
            label3.Location = new Point(1086, 209);
            label3.Name = "label3";
            label3.Size = new Size(166, 20);
            label3.TabIndex = 9;
            label3.Text = "CODIGO FUNCIONARIO";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1713, 816);
            Controls.Add(txbCodigoFuncionarioLogin);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(txbSenhaLogin);
            Controls.Add(txbUsuarioLogin);
            Controls.Add(btnLogin);
            Controls.Add(lblClickaAquiLogin);
            Controls.Add(lblNaoTenhoCadastro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private PictureBox pictureBox1;
        private TextBox txbSenhaLogin;
        private TextBox txbUsuarioLogin;
        private Button btnLogin;
        private Label lblClickaAquiLogin;
        private Label lblNaoTenhoCadastro;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox txbCodigoFuncionarioLogin;
        private Label label3;
    }
}
