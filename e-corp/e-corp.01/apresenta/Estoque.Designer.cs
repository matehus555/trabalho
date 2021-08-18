
namespace e_corp._01.apresenta
{
    partial class Estoque
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
            this.list = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cldesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clfor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clvc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clcv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clquant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnbusca = new System.Windows.Forms.Button();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.lbNomeb = new System.Windows.Forms.Label();
            this.txbNomep = new System.Windows.Forms.TextBox();
            this.txbdesc = new System.Windows.Forms.TextBox();
            this.txbfornep = new System.Windows.Forms.TextBox();
            this.txbpc = new System.Windows.Forms.TextBox();
            this.txbpv = new System.Windows.Forms.TextBox();
            this.txbquant = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEX = new System.Windows.Forms.Button();
            this.btnall = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.clnome,
            this.cldesc,
            this.clfor,
            this.clvc,
            this.clcv,
            this.clquant});
            this.list.FullRowSelect = true;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(10, 7);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(638, 97);
            this.list.TabIndex = 0;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID_PROD";
            this.id.Width = 67;
            // 
            // clnome
            // 
            this.clnome.Text = "NOME";
            this.clnome.Width = 109;
            // 
            // cldesc
            // 
            this.cldesc.Text = "descriçao";
            this.cldesc.Width = 111;
            // 
            // clfor
            // 
            this.clfor.Text = "fornecedor";
            this.clfor.Width = 122;
            // 
            // clvc
            // 
            this.clvc.Text = "custo";
            this.clvc.Width = 56;
            // 
            // clcv
            // 
            this.clcv.Text = "venda";
            this.clcv.Width = 57;
            // 
            // clquant
            // 
            this.clquant.Text = "Quant";
            this.clquant.Width = 173;
            // 
            // btnbusca
            // 
            this.btnbusca.Location = new System.Drawing.Point(557, 111);
            this.btnbusca.Name = "btnbusca";
            this.btnbusca.Size = new System.Drawing.Size(75, 23);
            this.btnbusca.TabIndex = 1;
            this.btnbusca.Text = "busca";
            this.btnbusca.UseVisualStyleBackColor = true;
            this.btnbusca.Click += new System.EventHandler(this.btnbusca_Click);
            // 
            // txbnome
            // 
            this.txbnome.Location = new System.Drawing.Point(396, 114);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(142, 20);
            this.txbnome.TabIndex = 2;
            // 
            // lbNomeb
            // 
            this.lbNomeb.AutoSize = true;
            this.lbNomeb.Location = new System.Drawing.Point(282, 116);
            this.lbNomeb.Name = "lbNomeb";
            this.lbNomeb.Size = new System.Drawing.Size(108, 13);
            this.lbNomeb.TabIndex = 3;
            this.lbNomeb.Text = "BUSCAR PRODUTO";
            // 
            // txbNomep
            // 
            this.txbNomep.Location = new System.Drawing.Point(13, 254);
            this.txbNomep.Name = "txbNomep";
            this.txbNomep.Size = new System.Drawing.Size(117, 20);
            this.txbNomep.TabIndex = 4;
            // 
            // txbdesc
            // 
            this.txbdesc.Location = new System.Drawing.Point(136, 254);
            this.txbdesc.Name = "txbdesc";
            this.txbdesc.Size = new System.Drawing.Size(362, 20);
            this.txbdesc.TabIndex = 5;
            // 
            // txbfornep
            // 
            this.txbfornep.Location = new System.Drawing.Point(504, 254);
            this.txbfornep.Name = "txbfornep";
            this.txbfornep.Size = new System.Drawing.Size(133, 20);
            this.txbfornep.TabIndex = 6;
            // 
            // txbpc
            // 
            this.txbpc.Location = new System.Drawing.Point(164, 174);
            this.txbpc.Name = "txbpc";
            this.txbpc.Size = new System.Drawing.Size(84, 20);
            this.txbpc.TabIndex = 7;
            // 
            // txbpv
            // 
            this.txbpv.Location = new System.Drawing.Point(309, 174);
            this.txbpv.Name = "txbpv";
            this.txbpv.Size = new System.Drawing.Size(99, 20);
            this.txbpv.TabIndex = 8;
            // 
            // txbquant
            // 
            this.txbquant.Location = new System.Drawing.Point(12, 174);
            this.txbquant.Name = "txbquant";
            this.txbquant.Size = new System.Drawing.Size(106, 20);
            this.txbquant.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnall);
            this.panel1.Controls.Add(this.lbNomeb);
            this.panel1.Controls.Add(this.txbnome);
            this.panel1.Controls.Add(this.btnbusca);
            this.panel1.Controls.Add(this.list);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 151);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "QUANTIDADE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "NOME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "DESCRIÇÃO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "FORNECEDOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "PREÇO DE CUSTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "PREÇO DE VENDA";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(562, 161);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEX
            // 
            this.btnEX.Location = new System.Drawing.Point(562, 190);
            this.btnEX.Name = "btnEX";
            this.btnEX.Size = new System.Drawing.Size(75, 23);
            this.btnEX.TabIndex = 18;
            this.btnEX.Text = "EXCLUIR";
            this.btnEX.UseVisualStyleBackColor = true;
            this.btnEX.Click += new System.EventHandler(this.btnEX_Click);
            // 
            // btnall
            // 
            this.btnall.Location = new System.Drawing.Point(29, 114);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(109, 23);
            this.btnall.TabIndex = 19;
            this.btnall.Text = "EXIBIR TUDO";
            this.btnall.UseVisualStyleBackColor = true;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 300);
            this.Controls.Add(this.btnEX);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbquant);
            this.Controls.Add(this.txbpv);
            this.Controls.Add(this.txbpc);
            this.Controls.Add(this.txbfornep);
            this.Controls.Add(this.txbdesc);
            this.Controls.Add(this.txbNomep);
            this.Name = "Estoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader clfor;
        private System.Windows.Forms.ColumnHeader clvc;
        private System.Windows.Forms.ColumnHeader clcv;
        private System.Windows.Forms.Button btnbusca;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.Label lbNomeb;
        private System.Windows.Forms.TextBox txbNomep;
        private System.Windows.Forms.TextBox txbdesc;
        private System.Windows.Forms.TextBox txbfornep;
        private System.Windows.Forms.TextBox txbpc;
        private System.Windows.Forms.TextBox txbpv;
        private System.Windows.Forms.TextBox txbquant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEX;
        public System.Windows.Forms.ColumnHeader id;
        public System.Windows.Forms.ColumnHeader clnome;
        public System.Windows.Forms.ColumnHeader cldesc;
        public System.Windows.Forms.ColumnHeader clquant;
        private System.Windows.Forms.Button btnall;
    }
}