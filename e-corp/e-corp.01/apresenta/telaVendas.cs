using e_corp._01.dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_corp._01.apresenta
{
    public partial class telaVendas : Form
    {
        public bool igual = true;
        public bool tem = false;

        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public telaVendas()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void vlproucura_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (vlproucura.SelectedItems.Count > 0)
            {

                lbNome.Text = vlproucura.SelectedItems[0].SubItems[1].Text;
                lbValor.Text = vlproucura.SelectedItems[0].SubItems[2].Text;
                lbIDtv.Text = vlproucura.SelectedItems[0].SubItems[0].Text;


            }


        }

        

        private void btnbusca_Click(object sender, EventArgs e)
        {
            vlproucura.Items.Clear();
            string ntxb = txbnome.Text;
            if (ntxb == "")
            {
                MessageBox.Show("campo nao pode ser vasio", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cmd.CommandText = "select * from PRODUTO where  nomep like @nome  ";

                cmd.Parameters.AddWithValue("@nome", ntxb + "%");


                try
                {
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();






                    string[] lista = new string[5];

                    //percorre o sqldatareader para obter os dados
                    while (dr.Read())
                    {
                        //Coluna da quantidade 

                        //aparecer nome do produto na label

                        //coluna descricao
                        lista[0] = Convert.ToString(dr["id_PROD"]);
                        lista[1] = Convert.ToString(dr["nomep"]);
                        lista[2] = Convert.ToString(dr["descp"]);
                        
                    
                        lista[4] = Convert.ToString(dr["valorv"]);
                        lista[3] = Convert.ToString(dr["quant"]);

                        ListViewItem lvi = new ListViewItem(lista);
                        vlproucura.Items.Add(lvi);


                    }

                    cmd.Parameters.Clear();

                    con.desconectar();


                    dr.Close();

                    txbnome.Text = "";











                }
                catch (SqlException)
                {

                    MessageBox.Show("erro com banco de dados", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }





            }
        }
        
        
        

        private void btnadd_Click(object sender, EventArgs e)
        {

            if (lbIDtv.Text != "") 
            {
                string[] lista = new string[5];
                lista[0] = lbIDtv.Text;
                lista[1] = lbNome.Text;
                lista[2] = txbQuant.Text;
                lista[3] = lbValor.Text;
                double x = Convert.ToDouble(lista[2]);
                double y = Convert.ToDouble(lista[3]);
                double tl = x * y;

                lista[4] = Convert.ToString(tl);
                ListViewItem lvi = new ListViewItem(lista);
                vlproucura.Items.Add(lvi);
            }
            else
            {
                MessageBox.Show("Selecione o item ", "venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void telaVendas_Load(object sender, EventArgs e)
        {

        }
    }
    
}
