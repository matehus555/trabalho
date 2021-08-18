
namespace e_corp._01
{
    partial class corp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(corp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomedeuser = new System.Windows.Forms.TextBox();
            this.senhalog = new System.Windows.Forms.TextBox();
            this.cadT1 = new System.Windows.Forms.Button();
            this.btnentrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SENHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "AINDA NAO É UM USUARIO?";
            // 
            // nomedeuser
            // 
            this.nomedeuser.Location = new System.Drawing.Point(255, 97);
            this.nomedeuser.Name = "nomedeuser";
            this.nomedeuser.Size = new System.Drawing.Size(177, 20);
            this.nomedeuser.TabIndex = 4;
            // 
            // senhalog
            // 
            this.senhalog.Location = new System.Drawing.Point(255, 136);
            this.senhalog.Name = "senhalog";
            this.senhalog.PasswordChar = '*';
            this.senhalog.Size = new System.Drawing.Size(177, 20);
            this.senhalog.TabIndex = 5;
            // 
            // cadT1
            // 
            this.cadT1.Location = new System.Drawing.Point(23, 229);
            this.cadT1.Name = "cadT1";
            this.cadT1.Size = new System.Drawing.Size(105, 26);
            this.cadT1.TabIndex = 6;
            this.cadT1.Text = "CADASTRE-SE";
            this.cadT1.UseVisualStyleBackColor = true;
            this.cadT1.Click += new System.EventHandler(this.cadT1_Click);
            // 
            // btnentrar
            // 
            this.btnentrar.Location = new System.Drawing.Point(309, 162);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(75, 23);
            this.btnentrar.TabIndex = 7;
            this.btnentrar.Text = "ENTRAR";
            this.btnentrar.UseVisualStyleBackColor = true;
            this.btnentrar.Click += new System.EventHandler(this.Btnentrar_Click);
            // 
            // corp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(472, 273);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.cadT1);
            this.Controls.Add(this.senhalog);
            this.Controls.Add(this.nomedeuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "corp";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomedeuser;
        private System.Windows.Forms.TextBox senhalog;
        private System.Windows.Forms.Button cadT1;
        private System.Windows.Forms.Button btnentrar;
    }
}

