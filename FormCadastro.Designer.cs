
namespace WFCadastrarCliente
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            lblNome = new System.Windows.Forms.Label();
            txtNome = new System.Windows.Forms.TextBox();
            txtSobreNome = new System.Windows.Forms.TextBox();
            lblSobreNome = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtTelefone = new System.Windows.Forms.TextBox();
            lblTelefone = new System.Windows.Forms.Label();
            gbxSexo = new System.Windows.Forms.GroupBox();
            rdbFeminino = new System.Windows.Forms.RadioButton();
            rdbMasculino = new System.Windows.Forms.RadioButton();
            lblEscolaridade = new System.Windows.Forms.Label();
            cbxEscolaridade = new System.Windows.Forms.ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnCadastrar = new System.Windows.Forms.Button();
            lblDataNascimento = new System.Windows.Forms.Label();
            dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            gbxSexo.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new System.Drawing.Point(15, 17);
            lblNome.Name = "lblNome";
            lblNome.Size = new System.Drawing.Size(53, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new System.Drawing.Point(15, 43);
            txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new System.Drawing.Size(255, 27);
            txtNome.TabIndex = 1;
            // 
            // txtSobreNome
            // 
            txtSobreNome.Location = new System.Drawing.Point(319, 43);
            txtSobreNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSobreNome.Name = "txtSobreNome";
            txtSobreNome.Size = new System.Drawing.Size(199, 27);
            txtSobreNome.TabIndex = 3;
            // 
            // lblSobreNome
            // 
            lblSobreNome.AutoSize = true;
            lblSobreNome.Location = new System.Drawing.Point(319, 17);
            lblSobreNome.Name = "lblSobreNome";
            lblSobreNome.Size = new System.Drawing.Size(89, 20);
            lblSobreNome.TabIndex = 2;
            lblSobreNome.Text = "Sobrenome:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(15, 136);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(255, 27);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(15, 108);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(55, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-mail:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new System.Drawing.Point(15, 228);
            txtTelefone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new System.Drawing.Size(255, 27);
            txtTelefone.TabIndex = 7;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new System.Drawing.Point(15, 203);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new System.Drawing.Size(69, 20);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone:";
            // 
            // gbxSexo
            // 
            gbxSexo.Controls.Add(rdbFeminino);
            gbxSexo.Controls.Add(rdbMasculino);
            gbxSexo.Location = new System.Drawing.Point(342, 189);
            gbxSexo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbxSexo.Name = "gbxSexo";
            gbxSexo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbxSexo.Size = new System.Drawing.Size(177, 140);
            gbxSexo.TabIndex = 8;
            gbxSexo.TabStop = false;
            gbxSexo.Text = "Sexo:";
            // 
            // rdbFeminino
            // 
            rdbFeminino.AutoSize = true;
            rdbFeminino.Location = new System.Drawing.Point(18, 91);
            rdbFeminino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            rdbFeminino.Name = "rdbFeminino";
            rdbFeminino.Size = new System.Drawing.Size(91, 24);
            rdbFeminino.TabIndex = 1;
            rdbFeminino.TabStop = true;
            rdbFeminino.Text = "Feminino";
            rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new System.Drawing.Point(18, 39);
            rdbMasculino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new System.Drawing.Size(97, 24);
            rdbMasculino.TabIndex = 0;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblEscolaridade
            // 
            lblEscolaridade.AutoSize = true;
            lblEscolaridade.Location = new System.Drawing.Point(15, 293);
            lblEscolaridade.Name = "lblEscolaridade";
            lblEscolaridade.Size = new System.Drawing.Size(97, 20);
            lblEscolaridade.TabIndex = 9;
            lblEscolaridade.Text = "Escolaridade:";
            // 
            // cbxEscolaridade
            // 
            cbxEscolaridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxEscolaridade.FormattingEnabled = true;
            cbxEscolaridade.Items.AddRange(new object[] { "Ensino Fundamental ", "Ensino Médio ", "Ensino Técnico", "Ensino Superior Incompleto", "Ensino Superior", "Pós-Graduação" });
            cbxEscolaridade.Location = new System.Drawing.Point(15, 317);
            cbxEscolaridade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbxEscolaridade.Name = "cbxEscolaridade";
            cbxEscolaridade.Size = new System.Drawing.Size(255, 28);
            cbxEscolaridade.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Image = (System.Drawing.Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.Location = new System.Drawing.Point(385, 468);
            btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new System.Drawing.Size(133, 44);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new System.Drawing.Point(319, 108);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new System.Drawing.Size(148, 20);
            lblDataNascimento.TabIndex = 12;
            lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new System.Drawing.Point(319, 132);
            dtpDataNascimento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dtpDataNascimento.Size = new System.Drawing.Size(199, 27);
            dtpDataNascimento.TabIndex = 13;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(559, 547);
            Controls.Add(dtpDataNascimento);
            Controls.Add(lblDataNascimento);
            Controls.Add(btnCadastrar);
            Controls.Add(cbxEscolaridade);
            Controls.Add(lblEscolaridade);
            Controls.Add(gbxSexo);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtSobreNome);
            Controls.Add(lblSobreNome);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FormCadastro";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes";
            gbxSexo.ResumeLayout(false);
            gbxSexo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobreNome;
        private System.Windows.Forms.Label lblSobreNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Label lblEscolaridade;
        private System.Windows.Forms.ComboBox cbxEscolaridade;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
    }
}