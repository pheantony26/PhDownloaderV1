namespace PhDownloaderV1
{
    partial class FormLogin
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.painelLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textboxLogin = new System.Windows.Forms.TextBox();
            this.textboxSenha = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblTopoLogin = new System.Windows.Forms.Label();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.lblEsqueceuSenha = new System.Windows.Forms.Label();
            this.lblInscrevase = new System.Windows.Forms.Label();
            this.lblNaoTemConta = new System.Windows.Forms.Label();
            this.lblLoginCom = new System.Windows.Forms.Label();
            this.pictureLoginApple = new System.Windows.Forms.PictureBox();
            this.pictureLoginGoogle = new System.Windows.Forms.PictureBox();
            this.pictureLoginFacebook = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoginApple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoginGoogle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoginFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // painelLogin
            // 
            this.painelLogin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.painelLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelLogin.Location = new System.Drawing.Point(0, 0);
            this.painelLogin.Name = "painelLogin";
            this.painelLogin.Size = new System.Drawing.Size(266, 404);
            this.painelLogin.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(349, 214);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(215, 25);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // textboxLogin
            // 
            this.textboxLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxLogin.Location = new System.Drawing.Point(349, 86);
            this.textboxLogin.Name = "textboxLogin";
            this.textboxLogin.Size = new System.Drawing.Size(215, 25);
            this.textboxLogin.TabIndex = 4;
            // 
            // textboxSenha
            // 
            this.textboxSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSenha.Location = new System.Drawing.Point(349, 140);
            this.textboxSenha.Name = "textboxSenha";
            this.textboxSenha.Size = new System.Drawing.Size(215, 25);
            this.textboxSenha.TabIndex = 5;
            this.textboxSenha.TextChanged += new System.EventHandler(this.textboxSenha_TextChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(346, 70);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 15);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(346, 124);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(39, 15);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "Senha";
            // 
            // lblTopoLogin
            // 
            this.lblTopoLogin.AutoSize = true;
            this.lblTopoLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopoLogin.Location = new System.Drawing.Point(433, 37);
            this.lblTopoLogin.Name = "lblTopoLogin";
            this.lblTopoLogin.Size = new System.Drawing.Size(53, 20);
            this.lblTopoLogin.TabIndex = 8;
            this.lblTopoLogin.Text = "LOGIN";
            // 
            // checkBoxRemember
            // 
            this.checkBoxRemember.AutoSize = true;
            this.checkBoxRemember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxRemember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRemember.Location = new System.Drawing.Point(349, 174);
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.Size = new System.Drawing.Size(92, 19);
            this.checkBoxRemember.TabIndex = 9;
            this.checkBoxRemember.Text = "Lembrar-me";
            this.checkBoxRemember.UseVisualStyleBackColor = true;
            // 
            // lblEsqueceuSenha
            // 
            this.lblEsqueceuSenha.AutoSize = true;
            this.lblEsqueceuSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEsqueceuSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsqueceuSenha.ForeColor = System.Drawing.Color.Blue;
            this.lblEsqueceuSenha.Location = new System.Drawing.Point(458, 174);
            this.lblEsqueceuSenha.Name = "lblEsqueceuSenha";
            this.lblEsqueceuSenha.Size = new System.Drawing.Size(106, 15);
            this.lblEsqueceuSenha.TabIndex = 10;
            this.lblEsqueceuSenha.Text = "Esqueceu a Senha?";
            // 
            // lblInscrevase
            // 
            this.lblInscrevase.AutoSize = true;
            this.lblInscrevase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInscrevase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscrevase.ForeColor = System.Drawing.Color.Blue;
            this.lblInscrevase.Location = new System.Drawing.Point(483, 253);
            this.lblInscrevase.Name = "lblInscrevase";
            this.lblInscrevase.Size = new System.Drawing.Size(70, 15);
            this.lblInscrevase.TabIndex = 11;
            this.lblInscrevase.Text = "Inscrever-se";
            this.lblInscrevase.Click += new System.EventHandler(this.lblInscrevase_Click);
            // 
            // lblNaoTemConta
            // 
            this.lblNaoTemConta.AutoSize = true;
            this.lblNaoTemConta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaoTemConta.Location = new System.Drawing.Point(346, 253);
            this.lblNaoTemConta.Name = "lblNaoTemConta";
            this.lblNaoTemConta.Size = new System.Drawing.Size(131, 15);
            this.lblNaoTemConta.TabIndex = 12;
            this.lblNaoTemConta.Text = "Não possui uma conta?";
            // 
            // lblLoginCom
            // 
            this.lblLoginCom.AutoSize = true;
            this.lblLoginCom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginCom.Location = new System.Drawing.Point(423, 301);
            this.lblLoginCom.Name = "lblLoginCom";
            this.lblLoginCom.Size = new System.Drawing.Size(73, 15);
            this.lblLoginCom.TabIndex = 13;
            this.lblLoginCom.Text = "LOGIN COM";
            // 
            // pictureLoginApple
            // 
            this.pictureLoginApple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLoginApple.Image = global::PhDownloaderV1.Properties.Resources.Login_Apple;
            this.pictureLoginApple.Location = new System.Drawing.Point(503, 331);
            this.pictureLoginApple.Name = "pictureLoginApple";
            this.pictureLoginApple.Size = new System.Drawing.Size(37, 37);
            this.pictureLoginApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLoginApple.TabIndex = 16;
            this.pictureLoginApple.TabStop = false;
            // 
            // pictureLoginGoogle
            // 
            this.pictureLoginGoogle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLoginGoogle.Image = global::PhDownloaderV1.Properties.Resources.Login_Google;
            this.pictureLoginGoogle.Location = new System.Drawing.Point(443, 331);
            this.pictureLoginGoogle.Name = "pictureLoginGoogle";
            this.pictureLoginGoogle.Size = new System.Drawing.Size(37, 37);
            this.pictureLoginGoogle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLoginGoogle.TabIndex = 15;
            this.pictureLoginGoogle.TabStop = false;
            // 
            // pictureLoginFacebook
            // 
            this.pictureLoginFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLoginFacebook.Image = global::PhDownloaderV1.Properties.Resources.Login_Facebook;
            this.pictureLoginFacebook.Location = new System.Drawing.Point(376, 331);
            this.pictureLoginFacebook.Name = "pictureLoginFacebook";
            this.pictureLoginFacebook.Size = new System.Drawing.Size(40, 40);
            this.pictureLoginFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLoginFacebook.TabIndex = 14;
            this.pictureLoginFacebook.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = global::PhDownloaderV1.Properties.Resources.Botao_Fechar;
            this.btnFechar.Location = new System.Drawing.Point(620, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(26, 26);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 3;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 404);
            this.Controls.Add(this.pictureLoginApple);
            this.Controls.Add(this.pictureLoginGoogle);
            this.Controls.Add(this.pictureLoginFacebook);
            this.Controls.Add(this.lblLoginCom);
            this.Controls.Add(this.lblNaoTemConta);
            this.Controls.Add(this.lblInscrevase);
            this.Controls.Add(this.lblEsqueceuSenha);
            this.Controls.Add(this.checkBoxRemember);
            this.Controls.Add(this.lblTopoLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.textboxSenha);
            this.Controls.Add(this.textboxLogin);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.painelLogin);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoginApple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoginGoogle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoginFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painelLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.TextBox textboxLogin;
        private System.Windows.Forms.TextBox textboxSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblTopoLogin;
        private System.Windows.Forms.CheckBox checkBoxRemember;
        private System.Windows.Forms.Label lblEsqueceuSenha;
        private System.Windows.Forms.Label lblInscrevase;
        private System.Windows.Forms.Label lblNaoTemConta;
        private System.Windows.Forms.Label lblLoginCom;
        private System.Windows.Forms.PictureBox pictureLoginFacebook;
        private System.Windows.Forms.PictureBox pictureLoginGoogle;
        private System.Windows.Forms.PictureBox pictureLoginApple;
    }
}

