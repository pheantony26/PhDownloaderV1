namespace PhDownloaderV1
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
            this.btnFecharCadastro = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblJaCadastrado = new System.Windows.Forms.Label();
            this.lblSenhaNaoConfere = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnFecharCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFecharCadastro
            // 
            this.btnFecharCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharCadastro.Image = global::PhDownloaderV1.Properties.Resources.Botao_Fechar;
            this.btnFecharCadastro.Location = new System.Drawing.Point(285, 3);
            this.btnFecharCadastro.Name = "btnFecharCadastro";
            this.btnFecharCadastro.Size = new System.Drawing.Size(26, 26);
            this.btnFecharCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFecharCadastro.TabIndex = 4;
            this.btnFecharCadastro.TabStop = false;
            this.btnFecharCadastro.Click += new System.EventHandler(this.btnFecharCadastro_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(49, 400);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(215, 25);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.Location = new System.Drawing.Point(46, 103);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(96, 15);
            this.lblNomeCompleto.TabIndex = 8;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCompleto.Location = new System.Drawing.Point(49, 119);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(215, 25);
            this.txtNomeCompleto.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(46, 155);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 15);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(49, 171);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(215, 25);
            this.txtEmail.TabIndex = 9;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(46, 211);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(98, 15);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Nome de usuário";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(49, 227);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(215, 25);
            this.txtNomeUsuario.TabIndex = 11;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(46, 264);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(66, 15);
            this.lblSenha.TabIndex = 14;
            this.lblSenha.Text = "Criar senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(49, 280);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(215, 25);
            this.txtSenha.TabIndex = 13;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmaSenha.Location = new System.Drawing.Point(46, 317);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(95, 15);
            this.lblConfirmaSenha.TabIndex = 16;
            this.lblConfirmaSenha.Text = "Confirmar senha";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.Location = new System.Drawing.Point(49, 333);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(215, 25);
            this.txtConfirmarSenha.TabIndex = 15;
            this.txtConfirmarSenha.TextChanged += new System.EventHandler(this.txtConfirmarSenha_TextChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Blue;
            this.lblLogin.Location = new System.Drawing.Point(191, 440);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(37, 15);
            this.lblLogin.TabIndex = 17;
            this.lblLogin.Text = "Login";
            // 
            // lblJaCadastrado
            // 
            this.lblJaCadastrado.AutoSize = true;
            this.lblJaCadastrado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJaCadastrado.Location = new System.Drawing.Point(78, 440);
            this.lblJaCadastrado.Name = "lblJaCadastrado";
            this.lblJaCadastrado.Size = new System.Drawing.Size(107, 15);
            this.lblJaCadastrado.TabIndex = 18;
            this.lblJaCadastrado.Text = "Já possui cadastro?";
            // 
            // lblSenhaNaoConfere
            // 
            this.lblSenhaNaoConfere.AutoSize = true;
            this.lblSenhaNaoConfere.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaNaoConfere.ForeColor = System.Drawing.Color.Red;
            this.lblSenhaNaoConfere.Location = new System.Drawing.Point(46, 361);
            this.lblSenhaNaoConfere.Name = "lblSenhaNaoConfere";
            this.lblSenhaNaoConfere.Size = new System.Drawing.Size(105, 15);
            this.lblSenhaNaoConfere.TabIndex = 19;
            this.lblSenhaNaoConfere.Text = "Senha nao confere";
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 489);
            this.Controls.Add(this.lblSenhaNaoConfere);
            this.Controls.Add(this.lblJaCadastrado);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblConfirmaSenha);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnFecharCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastro";
            this.Text = "FormCadastro";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormCadastro_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormCadastro_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormCadastro_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btnFecharCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnFecharCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblJaCadastrado;
        private System.Windows.Forms.Label lblSenhaNaoConfere;
    }
}