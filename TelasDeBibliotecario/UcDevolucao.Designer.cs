namespace Pim3_2025.TelasDeBibliotecario
{
    partial class UcDevolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDevolucao));
            pictureBox1 = new PictureBox();
            lblCadaCliente = new Label();
            btnCancelar_DevolucaoLivro = new Button();
            txbVerificar_DevolucaoLivro = new Button();
            btnDevoluir_DevolucaoLivro = new Button();
            dttmDataDevolucao_DevolucaoLivro = new DateTimePicker();
            txbIsban_DevolucaoLivro = new TextBox();
            label7 = new Label();
            txbTituloLivro_DevolucaoLivro = new TextBox();
            label8 = new Label();
            label4 = new Label();
            txbCpf_DevolucaoLivro = new TextBox();
            label3 = new Label();
            txbNomeCliente_DevolucaoLivro = new TextBox();
            label2 = new Label();
            txbCodFuncionario_DevolucaoLivro = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // lblCadaCliente
            // 
            lblCadaCliente.AutoSize = true;
            lblCadaCliente.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCadaCliente.Location = new Point(184, 90);
            lblCadaCliente.Name = "lblCadaCliente";
            lblCadaCliente.Size = new Size(273, 38);
            lblCadaCliente.TabIndex = 42;
            lblCadaCliente.Text = "DEVOLUÇÃO LIVRO";
            // 
            // btnCancelar_DevolucaoLivro
            // 
            btnCancelar_DevolucaoLivro.BackColor = Color.Red;
            btnCancelar_DevolucaoLivro.Location = new Point(1093, 627);
            btnCancelar_DevolucaoLivro.Name = "btnCancelar_DevolucaoLivro";
            btnCancelar_DevolucaoLivro.Size = new Size(151, 49);
            btnCancelar_DevolucaoLivro.TabIndex = 41;
            btnCancelar_DevolucaoLivro.Text = "CANCELAR";
            btnCancelar_DevolucaoLivro.UseVisualStyleBackColor = false;
            // 
            // txbVerificar_DevolucaoLivro
            // 
            txbVerificar_DevolucaoLivro.BackColor = Color.Gray;
            txbVerificar_DevolucaoLivro.Location = new Point(844, 627);
            txbVerificar_DevolucaoLivro.Name = "txbVerificar_DevolucaoLivro";
            txbVerificar_DevolucaoLivro.Size = new Size(151, 49);
            txbVerificar_DevolucaoLivro.TabIndex = 40;
            txbVerificar_DevolucaoLivro.Text = "VERIFICAR";
            txbVerificar_DevolucaoLivro.UseVisualStyleBackColor = false;
            // 
            // btnDevoluir_DevolucaoLivro
            // 
            btnDevoluir_DevolucaoLivro.BackColor = Color.Green;
            btnDevoluir_DevolucaoLivro.Location = new Point(588, 627);
            btnDevoluir_DevolucaoLivro.Name = "btnDevoluir_DevolucaoLivro";
            btnDevoluir_DevolucaoLivro.Size = new Size(151, 49);
            btnDevoluir_DevolucaoLivro.TabIndex = 39;
            btnDevoluir_DevolucaoLivro.Text = "DEVOLUIR";
            btnDevoluir_DevolucaoLivro.UseVisualStyleBackColor = false;
            // 
            // dttmDataDevolucao_DevolucaoLivro
            // 
            dttmDataDevolucao_DevolucaoLivro.Location = new Point(844, 509);
            dttmDataDevolucao_DevolucaoLivro.Name = "dttmDataDevolucao_DevolucaoLivro";
            dttmDataDevolucao_DevolucaoLivro.Size = new Size(338, 27);
            dttmDataDevolucao_DevolucaoLivro.TabIndex = 38;
            // 
            // txbIsban_DevolucaoLivro
            // 
            txbIsban_DevolucaoLivro.Location = new Point(705, 389);
            txbIsban_DevolucaoLivro.Name = "txbIsban_DevolucaoLivro";
            txbIsban_DevolucaoLivro.Size = new Size(323, 27);
            txbIsban_DevolucaoLivro.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(705, 348);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 36;
            label7.Text = "ISBAN";
            // 
            // txbTituloLivro_DevolucaoLivro
            // 
            txbTituloLivro_DevolucaoLivro.Location = new Point(241, 389);
            txbTituloLivro_DevolucaoLivro.Name = "txbTituloLivro_DevolucaoLivro";
            txbTituloLivro_DevolucaoLivro.Size = new Size(318, 27);
            txbTituloLivro_DevolucaoLivro.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(241, 348);
            label8.Name = "label8";
            label8.Size = new Size(123, 20);
            label8.TabIndex = 34;
            label8.Text = "TITULO DE LIVRO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(844, 468);
            label4.Name = "label4";
            label4.Size = new Size(159, 20);
            label4.TabIndex = 33;
            label4.Text = "DATA DE DEVOLUÇÃO";
            // 
            // txbCpf_DevolucaoLivro
            // 
            txbCpf_DevolucaoLivro.Location = new Point(916, 244);
            txbCpf_DevolucaoLivro.Name = "txbCpf_DevolucaoLivro";
            txbCpf_DevolucaoLivro.Size = new Size(312, 27);
            txbCpf_DevolucaoLivro.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(916, 203);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 27;
            label3.Text = "CPF";
            // 
            // txbNomeCliente_DevolucaoLivro
            // 
            txbNomeCliente_DevolucaoLivro.Location = new Point(451, 244);
            txbNomeCliente_DevolucaoLivro.Name = "txbNomeCliente_DevolucaoLivro";
            txbNomeCliente_DevolucaoLivro.Size = new Size(323, 27);
            txbNomeCliente_DevolucaoLivro.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 203);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 25;
            label2.Text = "NOME DE CLIENTE";
            // 
            // txbCodFuncionario_DevolucaoLivro
            // 
            txbCodFuncionario_DevolucaoLivro.Location = new Point(59, 244);
            txbCodFuncionario_DevolucaoLivro.Name = "txbCodFuncionario_DevolucaoLivro";
            txbCodFuncionario_DevolucaoLivro.Size = new Size(318, 27);
            txbCodFuncionario_DevolucaoLivro.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 203);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 23;
            label1.Text = "*CODIGODE FONCIONARIO";
            // 
            // UcDevolucao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(pictureBox1);
            Controls.Add(lblCadaCliente);
            Controls.Add(btnCancelar_DevolucaoLivro);
            Controls.Add(txbVerificar_DevolucaoLivro);
            Controls.Add(btnDevoluir_DevolucaoLivro);
            Controls.Add(dttmDataDevolucao_DevolucaoLivro);
            Controls.Add(txbIsban_DevolucaoLivro);
            Controls.Add(label7);
            Controls.Add(txbTituloLivro_DevolucaoLivro);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(txbCpf_DevolucaoLivro);
            Controls.Add(label3);
            Controls.Add(txbNomeCliente_DevolucaoLivro);
            Controls.Add(label2);
            Controls.Add(txbCodFuncionario_DevolucaoLivro);
            Controls.Add(label1);
            Name = "UcDevolucao";
            Size = new Size(1360, 745);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCadaCliente;
        private Button btnCancelar_CadastroCliente;
        private Button txbLempar_CadastroCliente;
        private Button btnCadastrar_CadastroCliente;
        private DateTimePicker dttmDataCadastro_CadastroCliente;
        private TextBox txbEmail_CadastroCliente;
        private Label label7;
        private TextBox txbCpf_CadastroCliente;
        private Label label8;
        private Label label4;
        private TextBox txbTelefone_CadastroCliente;
        private Label label5;
        private TextBox txbEndereco_CadastroCliente;
        private Label label6;
        private TextBox txbRG_CadastroCliente;
        private Label label3;
        private TextBox txbNomeCliente_CadastroCliente;
        private Label label2;
        private TextBox txbCodFuncionario_CadastroCliente;
        private Label label1;
        private TextBox txbCodFuncionario_DevolucaoLivro;
        private Button btnCancelar_DevolucaoLivro;
        private Button txbVerificar_DevolucaoLivro;
        private Button btnDevoluir_DevolucaoLivro;
        private DateTimePicker dttmDataDevolucao_DevolucaoLivro;
        private TextBox txbIsban_DevolucaoLivro;
        private TextBox txbTituloLivro_DevolucaoLivro;
        private TextBox txbCpf_DevolucaoLivro;
        private TextBox txbNomeCliente_DevolucaoLivro;
    }
}
