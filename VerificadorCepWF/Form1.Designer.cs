namespace VerificadorCepWF
{
    partial class Form1
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
            Verificar_cep = new Label();
            txtCep = new TextBox();
            btnVerificarCep = new Button();
            lblResultado = new Label();
            lblLogradouro = new Label();
            txtLogradouro = new TextBox();
            lblBairro = new Label();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            lblCidade = new Label();
            lblUf = new Label();
            txtUf = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtCpf = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtNumber = new TextBox();
            txtComplemento = new TextBox();
            btnGerarExcel = new Button();
            lblContato = new Label();
            btnKangu = new Button();
            label5 = new Label();
            btnFlex = new Button();
            label6 = new Label();
            txtContato = new TextBox();
            label7 = new Label();
            txtPesquisaCpf = new TextBox();
            btnPesquisaCpf = new Button();
            SuspendLayout();
            // 
            // Verificar_cep
            // 
            Verificar_cep.AutoSize = true;
            Verificar_cep.Location = new Point(12, 9);
            Verificar_cep.Name = "Verificar_cep";
            Verificar_cep.RightToLeft = RightToLeft.Yes;
            Verificar_cep.Size = new Size(28, 15);
            Verificar_cep.TabIndex = 0;
            Verificar_cep.Text = "CEP";
            // 
            // txtCep
            // 
            txtCep.AccessibleName = "";
            txtCep.BackColor = Color.FromArgb(255, 255, 128);
            txtCep.Location = new Point(12, 27);
            txtCep.MaxLength = 10;
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "Apenas numeros";
            txtCep.Size = new Size(119, 23);
            txtCep.TabIndex = 1;
            txtCep.TextChanged += txtCep_TextChanged;
            txtCep.KeyPress += txtCep_KeyPress;
            // 
            // btnVerificarCep
            // 
            btnVerificarCep.BackColor = SystemColors.MenuBar;
            btnVerificarCep.Location = new Point(137, 27);
            btnVerificarCep.Name = "btnVerificarCep";
            btnVerificarCep.Size = new Size(75, 23);
            btnVerificarCep.TabIndex = 2;
            btnVerificarCep.Text = "Pesquisar";
            btnVerificarCep.UseVisualStyleBackColor = false;
            btnVerificarCep.Click += btnVerificarCep_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.Location = new Point(137, 53);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(7, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "\r\n";
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.BackColor = Color.Transparent;
            lblLogradouro.Location = new Point(12, 121);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 4;
            lblLogradouro.Text = "Logradouro";
            lblLogradouro.Click += label1_Click;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(12, 139);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(436, 23);
            txtLogradouro.TabIndex = 5;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.BackColor = Color.Transparent;
            lblBairro.Location = new Point(12, 174);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 6;
            lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(12, 192);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(200, 23);
            txtBairro.TabIndex = 7;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(218, 192);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(230, 23);
            txtCidade.TabIndex = 8;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.BackColor = Color.Transparent;
            lblCidade.Location = new Point(218, 174);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 9;
            lblCidade.Text = "Cidade";
            lblCidade.Click += lblCidade_Click;
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.BackColor = Color.Transparent;
            lblUf.Location = new Point(454, 174);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(21, 15);
            lblUf.TabIndex = 10;
            lblUf.Text = "UF";
            lblUf.Click += lblUf_Click;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(454, 192);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(53, 23);
            txtUf.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 12;
            label1.Text = "Nome Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(305, 65);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 13;
            label2.Text = "CPF";
            label2.Click += label2_Click;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ScrollBar;
            txtName.Location = new Point(12, 83);
            txtName.MaxLength = 70;
            txtName.Name = "txtName";
            txtName.Size = new Size(298, 23);
            txtName.TabIndex = 15;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.BackColor = SystemColors.ScrollBar;
            txtCpf.Location = new Point(316, 83);
            txtCpf.MaxLength = 11;
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "Apenas Números";
            txtCpf.Size = new Size(191, 23);
            txtCpf.TabIndex = 16;
            txtCpf.KeyPress += txtCpf_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(454, 121);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 17;
            label3.Text = "Numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(12, 242);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 18;
            label4.Text = "Complemento";
            // 
            // txtNumber
            // 
            txtNumber.BackColor = SystemColors.ScrollBar;
            txtNumber.Location = new Point(454, 139);
            txtNumber.MaxLength = 8;
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(53, 23);
            txtNumber.TabIndex = 19;
            // 
            // txtComplemento
            // 
            txtComplemento.BackColor = SystemColors.ScrollBar;
            txtComplemento.Location = new Point(12, 260);
            txtComplemento.MaxLength = 70;
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(370, 23);
            txtComplemento.TabIndex = 20;
            // 
            // btnGerarExcel
            // 
            btnGerarExcel.BackColor = Color.Green;
            btnGerarExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerarExcel.ForeColor = Color.White;
            btnGerarExcel.Location = new Point(218, 304);
            btnGerarExcel.Name = "btnGerarExcel";
            btnGerarExcel.Size = new Size(92, 23);
            btnGerarExcel.TabIndex = 21;
            btnGerarExcel.Text = "GERAR EXCEL";
            btnGerarExcel.UseVisualStyleBackColor = false;
            btnGerarExcel.Click += btnGerarExcel_Click;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.BackColor = Color.Transparent;
            lblContato.Location = new Point(388, 242);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(50, 15);
            lblContato.TabIndex = 22;
            lblContato.Text = "Contato";
            // 
            // btnKangu
            // 
            btnKangu.BackColor = Color.DarkGray;
            btnKangu.Location = new Point(12, 361);
            btnKangu.Name = "btnKangu";
            btnKangu.Size = new Size(237, 23);
            btnKangu.TabIndex = 24;
            btnKangu.Text = "Fazer cotação na Kangu";
            btnKangu.UseVisualStyleBackColor = false;
            btnKangu.Click += btnKangu_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(79, 387);
            label5.Name = "label5";
            label5.Size = new Size(107, 12);
            label5.TabIndex = 25;
            label5.Text = "*caso não atenda no Flex*";
            label5.Click += label5_Click;
            // 
            // btnFlex
            // 
            btnFlex.BackColor = Color.DarkGreen;
            btnFlex.ForeColor = SystemColors.ButtonFace;
            btnFlex.Location = new Point(270, 361);
            btnFlex.Name = "btnFlex";
            btnFlex.Size = new Size(237, 23);
            btnFlex.TabIndex = 26;
            btnFlex.Text = "Site TRACKen Flex";
            btnFlex.UseVisualStyleBackColor = false;
            btnFlex.Click += btnFlex_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(338, 387);
            label6.Name = "label6";
            label6.Size = new Size(90, 12);
            label6.TabIndex = 27;
            label6.Text = "*caso atenda no Flex*";
            // 
            // txtContato
            // 
            txtContato.BackColor = SystemColors.ScrollBar;
            txtContato.Location = new Point(387, 260);
            txtContato.Name = "txtContato";
            txtContato.PlaceholderText = "Ex:11 900000000";
            txtContato.Size = new Size(119, 23);
            txtContato.TabIndex = 23;
            txtContato.KeyPress += txtContato_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(249, 9);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 28;
            label7.Text = "Pesquisar por CPF";
            // 
            // txtPesquisaCpf
            // 
            txtPesquisaCpf.Location = new Point(249, 27);
            txtPesquisaCpf.MaxLength = 11;
            txtPesquisaCpf.Name = "txtPesquisaCpf";
            txtPesquisaCpf.Size = new Size(157, 23);
            txtPesquisaCpf.TabIndex = 29;
            // 
            // btnPesquisaCpf
            // 
            btnPesquisaCpf.Location = new Point(412, 27);
            btnPesquisaCpf.Name = "btnPesquisaCpf";
            btnPesquisaCpf.Size = new Size(75, 23);
            btnPesquisaCpf.TabIndex = 30;
            btnPesquisaCpf.Text = "Pesquisar";
            btnPesquisaCpf.UseVisualStyleBackColor = true;
            btnPesquisaCpf.Click += btnPesquisaCpf_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(524, 412);
            Controls.Add(btnPesquisaCpf);
            Controls.Add(txtPesquisaCpf);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnFlex);
            Controls.Add(label5);
            Controls.Add(btnKangu);
            Controls.Add(txtContato);
            Controls.Add(lblContato);
            Controls.Add(btnGerarExcel);
            Controls.Add(txtComplemento);
            Controls.Add(txtNumber);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCpf);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUf);
            Controls.Add(lblUf);
            Controls.Add(lblCidade);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(lblBairro);
            Controls.Add(txtLogradouro);
            Controls.Add(lblLogradouro);
            Controls.Add(lblResultado);
            Controls.Add(btnVerificarCep);
            Controls.Add(txtCep);
            Controls.Add(Verificar_cep);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verificador CEP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Verificar_cep;
        private TextBox txtCep;
        private Button btnVerificarCep;
        private Label lblResultado;
        private Label lblLogradouro;
        private TextBox txtLogradouro;
        private Label lblBairro;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private Label lblCidade;
        private Label lblUf;
        private TextBox txtUf;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtCpf;
        private Label label3;
        private Label label4;
        private TextBox txtNumber;
        private TextBox txtComplemento;
        private Button btnGerarExcel;
        private Label lblContato;
        private Button btnKangu;
        private Label label5;
        private Button btnFlex;
        private Label label6;
        private TextBox txtContato;
        private Label label7;
        private TextBox txtPesquisaCpf;
        private Button btnPesquisaCpf;
    }
}
