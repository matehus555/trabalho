
using e_corp._01.modelo;

namespace e_corp._01.apresenta
{
    partial class cadastreSe
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
            this.btnCadastro = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.txbSenhaR = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbSenhaR = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbdata = new System.Windows.Forms.Label();
            this.txbData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(519, 216);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(88, 35);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "CADASTRAR";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(23, 30);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(156, 20);
            this.txbNome.TabIndex = 1;
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(23, 67);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(156, 20);
            this.txbCpf.TabIndex = 2;
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(23, 106);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(156, 20);
            this.txbUser.TabIndex = 3;
            // 
            // txbSenhaR
            // 
            this.txbSenhaR.Location = new System.Drawing.Point(22, 192);
            this.txbSenhaR.Name = "txbSenhaR";
            this.txbSenhaR.Size = new System.Drawing.Size(156, 20);
            this.txbSenhaR.TabIndex = 4;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(22, 145);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(156, 20);
            this.txbSenha.TabIndex = 5;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(230, 30);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(156, 20);
            this.txbEmail.TabIndex = 6;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(24, 14);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(42, 13);
            this.lbNome.TabIndex = 7;
            this.lbNome.Text = "NOME:";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(24, 53);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(30, 13);
            this.lbCpf.TabIndex = 8;
            this.lbCpf.Text = "CPF:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(20, 90);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(112, 13);
            this.lbUser.TabIndex = 9;
            this.lbUser.Text = "NOME DE USUARIO:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(19, 129);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(47, 13);
            this.lbSenha.TabIndex = 10;
            this.lbSenha.Text = "SENHA:";
            // 
            // lbSenhaR
            // 
            this.lbSenhaR.AutoSize = true;
            this.lbSenhaR.Location = new System.Drawing.Point(20, 174);
            this.lbSenhaR.Name = "lbSenhaR";
            this.lbSenhaR.Size = new System.Drawing.Size(99, 13);
            this.lbSenhaR.TabIndex = 11;
            this.lbSenhaR.Text = "REPITA A SENHA:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(227, 14);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(45, 13);
            this.lbEmail.TabIndex = 12;
            this.lbEmail.Text = "E-MAIL:";
            this.lbEmail.Click += new System.EventHandler(this.CADASTRE_SE_Load);
            // 
            // lbdata
            // 
            this.lbdata.AutoSize = true;
            this.lbdata.Location = new System.Drawing.Point(227, 57);
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(131, 13);
            this.lbdata.TabIndex = 13;
            this.lbdata.Text = "DATA DE NASCIMENTO:";
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(230, 73);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(156, 20);
            this.txbData.TabIndex = 14;
            // 
            // cadastreSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 265);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.lbdata);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbSenhaR);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbSenhaR);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnCadastro);
            this.Name = "cadastreSe";
            this.Text = "cadastreSe";
            this.Load += new System.EventHandler(this.CADASTRE_SE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.TextBox txbSenhaR;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbSenhaR;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbdata;
        private System.Windows.Forms.TextBox txbData;
    }
}