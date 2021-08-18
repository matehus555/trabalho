
namespace e_corp._01.apresenta
{
    partial class Consltarv
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
            this.btnbcpf = new System.Windows.Forms.Button();
            this.txbcpf = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txbCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbcod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.clcod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cldata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.blkk = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbcont = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbvlt = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnbcpf
            // 
            this.btnbcpf.Location = new System.Drawing.Point(656, 10);
            this.btnbcpf.Name = "btnbcpf";
            this.btnbcpf.Size = new System.Drawing.Size(75, 23);
            this.btnbcpf.TabIndex = 0;
            this.btnbcpf.Text = "BUSCAR";
            this.btnbcpf.UseVisualStyleBackColor = true;
            this.btnbcpf.Click += new System.EventHandler(this.btnbcpf_Click);
            // 
            // txbcpf
            // 
            this.txbcpf.Location = new System.Drawing.Point(550, 13);
            this.txbcpf.Name = "txbcpf";
            this.txbcpf.Size = new System.Drawing.Size(100, 20);
            this.txbcpf.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clcod,
            this.columnHeader1,
            this.columnHeader2,
            this.colValor,
            this.clCpf,
            this.cldata});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 41);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(468, 280);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // txbCod
            // 
            this.txbCod.Location = new System.Drawing.Point(73, 12);
            this.txbCod.Name = "txbCod";
            this.txbCod.Size = new System.Drawing.Size(100, 20);
            this.txbCod.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "COD:";
            // 
            // btnbcod
            // 
            this.btnbcod.Location = new System.Drawing.Point(196, 12);
            this.btnbcod.Name = "btnbcod";
            this.btnbcod.Size = new System.Drawing.Size(75, 23);
            this.btnbcod.TabIndex = 5;
            this.btnbcod.Text = "BUSCAR";
            this.btnbcod.UseVisualStyleBackColor = true;
            this.btnbcod.Click += new System.EventHandler(this.btnbcod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CPF:";
            // 
            // clcod
            // 
            this.clcod.Text = "COD";
            // 
            // clCpf
            // 
            this.clCpf.DisplayIndex = 5;
            this.clCpf.Text = "CPF";
            this.clCpf.Width = 102;
            // 
            // cldata
            // 
            this.cldata.DisplayIndex = 4;
            this.cldata.Text = "Data de compra";
            this.cldata.Width = 108;
            // 
            // colValor
            // 
            this.colValor.Text = "VALOR";
            this.colValor.Width = 68;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(531, 253);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(531, 301);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // blkk
            // 
            this.blkk.AutoSize = true;
            this.blkk.Location = new System.Drawing.Point(616, 237);
            this.blkk.Name = "blkk";
            this.blkk.Size = new System.Drawing.Size(22, 13);
            this.blkk.TabIndex = 9;
            this.blkk.Text = "DE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ATE";
            // 
            // lbcont
            // 
            this.lbcont.AutoSize = true;
            this.lbcont.Location = new System.Drawing.Point(12, 328);
            this.lbcont.Name = "lbcont";
            this.lbcont.Size = new System.Drawing.Size(13, 13);
            this.lbcont.TabIndex = 11;
            this.lbcont.Text = "0";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "quantia";
            // 
            // lbvlt
            // 
            this.lbvlt.AutoSize = true;
            this.lbvlt.Location = new System.Drawing.Point(367, 328);
            this.lbvlt.Name = "lbvlt";
            this.lbvlt.Size = new System.Drawing.Size(24, 13);
            this.lbvlt.TabIndex = 12;
            this.lbvlt.Text = "R$:";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader5});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(497, 41);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(251, 193);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "cod venda";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Data";
            // 
            // Consltarv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 350);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.lbvlt);
            this.Controls.Add(this.lbcont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blkk);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnbcod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCod);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txbcpf);
            this.Controls.Add(this.btnbcpf);
            this.Name = "Consltarv";
            this.Text = "Consltarv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbcpf;
        private System.Windows.Forms.TextBox txbcpf;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txbCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbcod;
        private System.Windows.Forms.ColumnHeader clcod;
        private System.Windows.Forms.ColumnHeader clCpf;
        private System.Windows.Forms.ColumnHeader cldata;
        private System.Windows.Forms.ColumnHeader colValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label blkk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lbcont;
        private System.Windows.Forms.Label lbvlt;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}