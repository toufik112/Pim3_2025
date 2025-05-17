namespace Pim3_2025.TelasDeBibliotecario
{
    partial class UcSuspenderRetomarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSuspenderRetomarCliente));
            pictureBox1 = new PictureBox();
            lblSuspenderRetomarCliente = new Label();
            btnSuspender_SuspenderRetomarCliente = new Button();
            txbLimpar_SuspenderRetomarCliente = new Button();
            btnRetomar_SuspenderRetomarCliente = new Button();
            dttmDataOperacao_SuspenderRetomarCliente = new DateTimePicker();
            label4 = new Label();
            txbCpf_SuspenderRetomarCliente = new TextBox();
            label3 = new Label();
            txbNomeCliente_SuspenderRetomarCliente = new TextBox();
            label2 = new Label();
            txbCodFuncionario_SuspenderRetomarCliente = new TextBox();
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
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // lblSuspenderRetomarCliente
            // 
            lblSuspenderRetomarCliente.AutoSize = true;
            lblSuspenderRetomarCliente.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSuspenderRetomarCliente.Location = new Point(184, 90);
            lblSuspenderRetomarCliente.Name = "lblSuspenderRetomarCliente";
            lblSuspenderRetomarCliente.Size = new Size(455, 38);
            lblSuspenderRetomarCliente.TabIndex = 46;
            lblSuspenderRetomarCliente.Text = "SUSPENDER / RETOMAR CLIENTE";
            // 
            // btnSuspender_SuspenderRetomarCliente
            // 
            btnSuspender_SuspenderRetomarCliente.BackColor = Color.Red;
            btnSuspender_SuspenderRetomarCliente.Location = new Point(1094, 627);
            btnSuspender_SuspenderRetomarCliente.Name = "btnSuspender_SuspenderRetomarCliente";
            btnSuspender_SuspenderRetomarCliente.Size = new Size(151, 49);
            btnSuspender_SuspenderRetomarCliente.TabIndex = 66;
            btnSuspender_SuspenderRetomarCliente.Text = "SUSPENDER";
            btnSuspender_SuspenderRetomarCliente.UseVisualStyleBackColor = false;
            // 
            // txbLimpar_SuspenderRetomarCliente
            // 
            txbLimpar_SuspenderRetomarCliente.BackColor = Color.Gray;
            txbLimpar_SuspenderRetomarCliente.Location = new Point(845, 627);
            txbLimpar_SuspenderRetomarCliente.Name = "txbLimpar_SuspenderRetomarCliente";
            txbLimpar_SuspenderRetomarCliente.Size = new Size(151, 49);
            txbLimpar_SuspenderRetomarCliente.TabIndex = 65;
            txbLimpar_SuspenderRetomarCliente.Text = "LIMPAR";
            txbLimpar_SuspenderRetomarCliente.UseVisualStyleBackColor = false;
            // 
            // btnRetomar_SuspenderRetomarCliente
            // 
            btnRetomar_SuspenderRetomarCliente.BackColor = Color.Green;
            btnRetomar_SuspenderRetomarCliente.Location = new Point(589, 627);
            btnRetomar_SuspenderRetomarCliente.Name = "btnRetomar_SuspenderRetomarCliente";
            btnRetomar_SuspenderRetomarCliente.Size = new Size(151, 49);
            btnRetomar_SuspenderRetomarCliente.TabIndex = 64;
            btnRetomar_SuspenderRetomarCliente.Text = "RETOMAR";
            btnRetomar_SuspenderRetomarCliente.UseVisualStyleBackColor = false;
            btnRetomar_SuspenderRetomarCliente.Click += btnCadastrar_CadastroCliente_Click;
            // 
            // dttmDataOperacao_SuspenderRetomarCliente
            // 
            dttmDataOperacao_SuspenderRetomarCliente.Location = new Point(151, 449);
            dttmDataOperacao_SuspenderRetomarCliente.Name = "dttmDataOperacao_SuspenderRetomarCliente";
            dttmDataOperacao_SuspenderRetomarCliente.Size = new Size(398, 27);
            dttmDataOperacao_SuspenderRetomarCliente.TabIndex = 63;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 407);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 58;
            label4.Text = "DATA DE OPERAÇÃO";
            label4.Click += label4_Click;
            // 
            // txbCpf_SuspenderRetomarCliente
            // 
            txbCpf_SuspenderRetomarCliente.Location = new Point(917, 244);
            txbCpf_SuspenderRetomarCliente.Name = "txbCpf_SuspenderRetomarCliente";
            txbCpf_SuspenderRetomarCliente.Size = new Size(312, 27);
            txbCpf_SuspenderRetomarCliente.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(917, 203);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 52;
            label3.Text = "CPF";
            // 
            // txbNomeCliente_SuspenderRetomarCliente
            // 
            txbNomeCliente_SuspenderRetomarCliente.Location = new Point(481, 244);
            txbNomeCliente_SuspenderRetomarCliente.Name = "txbNomeCliente_SuspenderRetomarCliente";
            txbNomeCliente_SuspenderRetomarCliente.Size = new Size(323, 27);
            txbNomeCliente_SuspenderRetomarCliente.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(481, 203);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 50;
            label2.Text = "NOME DE CLIENTE";
            // 
            // txbCodFuncionario_SuspenderRetomarCliente
            // 
            txbCodFuncionario_SuspenderRetomarCliente.Location = new Point(60, 244);
            txbCodFuncionario_SuspenderRetomarCliente.Name = "txbCodFuncionario_SuspenderRetomarCliente";
            txbCodFuncionario_SuspenderRetomarCliente.Size = new Size(318, 27);
            txbCodFuncionario_SuspenderRetomarCliente.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 203);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 48;
            label1.Text = "*CODIGODE FONCIONARIO";
            // 
            // UcSuspenderRetomarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSuspender_SuspenderRetomarCliente);
            Controls.Add(txbLimpar_SuspenderRetomarCliente);
            Controls.Add(btnRetomar_SuspenderRetomarCliente);
            Controls.Add(dttmDataOperacao_SuspenderRetomarCliente);
            Controls.Add(label4);
            Controls.Add(txbCpf_SuspenderRetomarCliente);
            Controls.Add(label3);
            Controls.Add(txbNomeCliente_SuspenderRetomarCliente);
            Controls.Add(label2);
            Controls.Add(txbCodFuncionario_SuspenderRetomarCliente);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblSuspenderRetomarCliente);
            Name = "UcSuspenderRetomarCliente";
            Size = new Size(1360, 745);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblSuspenderRetomarCliente;
        private Button btnSuspender_SuspenderRetomarCliente;
        private Button txbLimpar_SuspenderRetomarCliente;
        private Button btnRetomar_SuspenderRetomarCliente;
        private DateTimePicker dttmDataOperacao_SuspenderRetomarCliente;
        private Label label4;
        private TextBox txbCpf_SuspenderRetomarCliente;
        private Label label3;
        private TextBox txbNomeCliente_SuspenderRetomarCliente;
        private Label label2;
        private TextBox txbCodFuncionario_SuspenderRetomarCliente;
        private Label label1;
    }
}
