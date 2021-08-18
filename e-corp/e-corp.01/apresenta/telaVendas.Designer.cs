
namespace e_corp._01.apresenta
{
    partial class telaVendas
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvtv = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.vlproucura = new System.Windows.Forms.ListView();
            this.clid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cldesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clestoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clquant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clvv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnbusca = new System.Windows.Forms.Button();
            this.lbValor = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txbQuant = new System.Windows.Forms.TextBox();
            this.clidptv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnometv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clquanttv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clvalortv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clptotalv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnadd = new System.Windows.Forms.Button();
            this.lbIDtv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "codigo do produto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txbnome
            // 
            this.txbnome.Location = new System.Drawing.Point(31, 89);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(131, 20);
            this.txbnome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ldescrisao do produto";
            // 
            // lvtv
            // 
            this.lvtv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clidptv,
            this.clnometv,
            this.clquanttv,
            this.clvalortv,
            this.clptotalv});
            this.lvtv.FullRowSelect = true;
            this.lvtv.GridLines = true;
            this.lvtv.HideSelection = false;
            this.lvtv.Location = new System.Drawing.Point(20, 263);
            this.lvtv.MultiSelect = false;
            this.lvtv.Name = "lvtv";
            this.lvtv.Size = new System.Drawing.Size(744, 154);
            this.lvtv.TabIndex = 4;
            this.lvtv.UseCompatibleStateImageBehavior = false;
            this.lvtv.View = System.Windows.Forms.View.Details;
            this.lvtv.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "vender";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "nome do cliente";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(31, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(131, 20);
            this.textBox4.TabIndex = 11;
            // 
            // vlproucura
            // 
            this.vlproucura.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clid,
            this.clnome,
            this.cldesc,
            this.clestoc,
            this.clquant,
            this.clvv});
            this.vlproucura.FullRowSelect = true;
            this.vlproucura.HideSelection = false;
            this.vlproucura.Location = new System.Drawing.Point(195, 19);
            this.vlproucura.MultiSelect = false;
            this.vlproucura.Name = "vlproucura";
            this.vlproucura.Size = new System.Drawing.Size(569, 163);
            this.vlproucura.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.vlproucura.TabIndex = 12;
            this.vlproucura.UseCompatibleStateImageBehavior = false;
            this.vlproucura.View = System.Windows.Forms.View.Details;
            this.vlproucura.SelectedIndexChanged += new System.EventHandler(this.vlproucura_SelectedIndexChanged);
            // 
            // clid
            // 
            this.clid.Text = "ID PRODUTO";
            this.clid.Width = 90;
            // 
            // clnome
            // 
            this.clnome.Text = "NOME";
            this.clnome.Width = 114;
            // 
            // cldesc
            // 
            this.cldesc.Text = "DESCRIÇÃO";
            this.cldesc.Width = 108;
            // 
            // clestoc
            // 
            this.clestoc.Text = "ESTOQUE";
            this.clestoc.Width = 95;
            // 
            // clquant
            // 
            this.clquant.Text = "QUANTIDADE";
            this.clquant.Width = 76;
            // 
            // clvv
            // 
            this.clvv.Text = "VALOR";
            // 
            // btnbusca
            // 
            this.btnbusca.Location = new System.Drawing.Point(195, 188);
            this.btnbusca.Name = "btnbusca";
            this.btnbusca.Size = new System.Drawing.Size(83, 29);
            this.btnbusca.TabIndex = 13;
            this.btnbusca.Text = "BUSCAR";
            this.btnbusca.UseVisualStyleBackColor = true;
            this.btnbusca.Click += new System.EventHandler(this.btnbusca_Click);
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbValor.Location = new System.Drawing.Point(624, 232);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(23, 15);
            this.lbValor.TabIndex = 14;
            this.lbValor.Text = "R$";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNome.Location = new System.Drawing.Point(260, 231);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(89, 15);
            this.lbNome.TabIndex = 15;
            this.lbNome.Text = "nome do produto";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotal.Location = new System.Drawing.Point(610, 202);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(37, 15);
            this.lbTotal.TabIndex = 16;
            this.lbTotal.Text = "label6";
            // 
            // txbQuant
            // 
            this.txbQuant.Location = new System.Drawing.Point(506, 228);
            this.txbQuant.Name = "txbQuant";
            this.txbQuant.Size = new System.Drawing.Size(69, 20);
            this.txbQuant.TabIndex = 17;
            // 
            // clidptv
            // 
            this.clidptv.Text = "ID_PROD";
            // 
            // clnometv
            // 
            this.clnometv.Text = "NOME DO PRODUTO";
            this.clnometv.Width = 200;
            // 
            // clquanttv
            // 
            this.clquanttv.Text = "QUANTIDADE";
            this.clquanttv.Width = 162;
            // 
            // clvalortv
            // 
            this.clvalortv.Text = "PREÇO";
            this.clvalortv.Width = 138;
            // 
            // clptotalv
            // 
            this.clptotalv.Text = "TOTAL";
            this.clptotalv.Width = 178;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(670, 223);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 24);
            this.btnadd.TabIndex = 18;
            this.btnadd.Text = "ADICIONAR";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lbIDtv
            // 
            this.lbIDtv.AutoSize = true;
            this.lbIDtv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbIDtv.Location = new System.Drawing.Point(242, 231);
            this.lbIDtv.Name = "lbIDtv";
            this.lbIDtv.Size = new System.Drawing.Size(12, 15);
            this.lbIDtv.TabIndex = 19;
            this.lbIDtv.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(7, 4);
            this.label3.TabIndex = 20;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(595, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "R$";
            // 
            // telaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 468);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbIDtv);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txbQuant);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.btnbusca);
            this.Controls.Add(this.vlproucura);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvtv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbnome);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "telaVendas";
            this.Text = "////////////////////";
            this.Load += new System.EventHandler(this.telaVendas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvtv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListView vlproucura;
        private System.Windows.Forms.ColumnHeader clid;
        private System.Windows.Forms.ColumnHeader clnome;
        private System.Windows.Forms.ColumnHeader cldesc;
        private System.Windows.Forms.ColumnHeader clestoc;
        private System.Windows.Forms.ColumnHeader clquant;
        private System.Windows.Forms.ColumnHeader clvv;
        private System.Windows.Forms.Button btnbusca;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txbQuant;
        private System.Windows.Forms.ColumnHeader clidptv;
        private System.Windows.Forms.ColumnHeader clnometv;
        private System.Windows.Forms.ColumnHeader clquanttv;
        private System.Windows.Forms.ColumnHeader clvalortv;
        private System.Windows.Forms.ColumnHeader clptotalv;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lbIDtv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}