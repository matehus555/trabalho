
namespace e_corp._01.apresenta
{
    partial class cadcli
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
            this.button1 = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.txbEnd = new System.Windows.Forms.TextBox();
            this.txbtel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.txbData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(59, 43);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(267, 20);
            this.txbNome.TabIndex = 1;
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(57, 83);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(269, 20);
            this.txbCpf.TabIndex = 2;
            // 
            // txbEnd
            // 
            this.txbEnd.Location = new System.Drawing.Point(57, 127);
            this.txbEnd.Name = "txbEnd";
            this.txbEnd.Size = new System.Drawing.Size(269, 20);
            this.txbEnd.TabIndex = 3;
            // 
            // txbtel
            // 
            this.txbtel.Location = new System.Drawing.Point(57, 163);
            this.txbtel.Name = "txbtel";
            this.txbtel.Size = new System.Drawing.Size(269, 20);
            this.txbtel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOME DO CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ENDEREÇO";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(62, 150);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(63, 13);
            this.lab.TabIndex = 8;
            this.lab.Text = "TELEFONE";
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(57, 202);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(105, 20);
            this.txbData.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "DATA DE NASCIMENTO";
            // 
            // cadcli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 311);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbtel);
            this.Controls.Add(this.txbEnd);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.button1);
            this.Name = "cadcli";
            this.Text = "cadcli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.TextBox txbEnd;
        private System.Windows.Forms.TextBox txbtel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.Label label5;
    }
}