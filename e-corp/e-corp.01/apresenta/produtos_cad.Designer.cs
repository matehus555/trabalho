
namespace e_corp._01.apresenta
{
    partial class produtos_cad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(produtos_cad));
            this.lbNomep = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.txbVc = new System.Windows.Forms.Label();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.txbpc = new System.Windows.Forms.TextBox();
            this.txbpv = new System.Windows.Forms.TextBox();
            this.txbNomep = new System.Windows.Forms.TextBox();
            this.lbpv = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbForne = new System.Windows.Forms.Label();
            this.txbforne = new System.Windows.Forms.TextBox();
            this.btnCadP = new System.Windows.Forms.Button();
            this.btnADDI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNomep
            // 
            this.lbNomep.AutoSize = true;
            this.lbNomep.Location = new System.Drawing.Point(20, 20);
            this.lbNomep.Name = "lbNomep";
            this.lbNomep.Size = new System.Drawing.Size(115, 13);
            this.lbNomep.TabIndex = 0;
            this.lbNomep.Text = "NOME DO PRODUTO";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(20, 81);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(69, 13);
            this.lbDesc.TabIndex = 1;
            this.lbDesc.Text = "DESCRIÇAO";
            // 
            // txbVc
            // 
            this.txbVc.AutoSize = true;
            this.txbVc.Location = new System.Drawing.Point(20, 200);
            this.txbVc.Name = "txbVc";
            this.txbVc.Size = new System.Drawing.Size(102, 13);
            this.txbVc.TabIndex = 2;
            this.txbVc.Text = "PREÇO DE CUSTO";
            // 
            // txbDesc
            // 
            this.txbDesc.Location = new System.Drawing.Point(23, 102);
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(347, 20);
            this.txbDesc.TabIndex = 4;
            this.txbDesc.TextChanged += new System.EventHandler(this.txbDesc_TextChanged);
            // 
            // txbpc
            // 
            this.txbpc.Location = new System.Drawing.Point(23, 231);
            this.txbpc.Name = "txbpc";
            this.txbpc.Size = new System.Drawing.Size(230, 20);
            this.txbpc.TabIndex = 5;
            // 
            // txbpv
            // 
            this.txbpv.Location = new System.Drawing.Point(23, 302);
            this.txbpv.Name = "txbpv";
            this.txbpv.Size = new System.Drawing.Size(230, 20);
            this.txbpv.TabIndex = 6;
            // 
            // txbNomep
            // 
            this.txbNomep.Location = new System.Drawing.Point(23, 45);
            this.txbNomep.Name = "txbNomep";
            this.txbNomep.Size = new System.Drawing.Size(347, 20);
            this.txbNomep.TabIndex = 9;
            // 
            // lbpv
            // 
            this.lbpv.AutoSize = true;
            this.lbpv.Location = new System.Drawing.Point(20, 275);
            this.lbpv.Name = "lbpv";
            this.lbpv.Size = new System.Drawing.Size(102, 13);
            this.lbpv.TabIndex = 10;
            this.lbpv.Text = "PREÇO DE VENDA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(400, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lbForne
            // 
            this.lbForne.AutoSize = true;
            this.lbForne.Location = new System.Drawing.Point(20, 137);
            this.lbForne.Name = "lbForne";
            this.lbForne.Size = new System.Drawing.Size(82, 13);
            this.lbForne.TabIndex = 13;
            this.lbForne.Text = "FORNECEDOR";
            // 
            // txbforne
            // 
            this.txbforne.Location = new System.Drawing.Point(23, 162);
            this.txbforne.Name = "txbforne";
            this.txbforne.Size = new System.Drawing.Size(230, 20);
            this.txbforne.TabIndex = 14;
            // 
            // btnCadP
            // 
            this.btnCadP.Location = new System.Drawing.Point(400, 250);
            this.btnCadP.Name = "btnCadP";
            this.btnCadP.Size = new System.Drawing.Size(232, 72);
            this.btnCadP.TabIndex = 15;
            this.btnCadP.Text = "CADASTRAR";
            this.btnCadP.UseVisualStyleBackColor = true;
            this.btnCadP.Click += new System.EventHandler(this.btnCadP_Click);
            // 
            // btnADDI
            // 
            this.btnADDI.Location = new System.Drawing.Point(400, 209);
            this.btnADDI.Name = "btnADDI";
            this.btnADDI.Size = new System.Drawing.Size(232, 23);
            this.btnADDI.TabIndex = 16;
            this.btnADDI.Text = "ADD IMAGEM";
            this.btnADDI.UseVisualStyleBackColor = true;
            // 
            // produtos_cad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 354);
            this.Controls.Add(this.btnADDI);
            this.Controls.Add(this.btnCadP);
            this.Controls.Add(this.txbforne);
            this.Controls.Add(this.lbForne);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbpv);
            this.Controls.Add(this.txbNomep);
            this.Controls.Add(this.txbpv);
            this.Controls.Add(this.txbpc);
            this.Controls.Add(this.txbDesc);
            this.Controls.Add(this.txbVc);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.lbNomep);
            this.Name = "produtos_cad";
            this.Text = "produtos_cad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomep;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label txbVc;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.TextBox txbpc;
        private System.Windows.Forms.TextBox txbpv;
        private System.Windows.Forms.TextBox txbNomep;
        private System.Windows.Forms.Label lbpv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbForne;
        private System.Windows.Forms.TextBox txbforne;
        private System.Windows.Forms.Button btnCadP;
        private System.Windows.Forms.Button btnADDI;
    }
}