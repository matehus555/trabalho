using e_corp._01.dal;
using e_corp._01.modelo;
using System;
using System.Collections;
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

    public partial class Estoque : Form
    {

        public bool igual = true;
        public bool tem = false;

        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;



        public Estoque()
        {
            InitializeComponent();
        }



        private void Estoque_Load(object sender, EventArgs e)
        {
            

        }
        private  void au ()
            {

        }

        private void btnbusca_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            string ntxb = txbnome.Text;
            if (ntxb == "")
            {
                MessageBox.Show("campo nao pode ser vasio", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cmd.CommandText = "select * from PRODUTO where  nomep like @nome  ";
                
                cmd.Parameters.AddWithValue( "@nome", ntxb + "%");


                try
                {
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();






                    string[] lista = new string[7];

                    //percorre o sqldatareader para obter os dados
                    while (dr.Read())
                    {
                        //Coluna da quantidade 

                        //aparecer nome do produto na label

                        //coluna descricao
                        lista[0] = Convert.ToString(dr["id_PROD"]);
                        lista[1] = Convert.ToString(dr["nomep"]);
                        lista[2] = Convert.ToString(dr["descp"]);
                        lista[3] = Convert.ToString(dr["fornep"]);
                        lista[4] = Convert.ToString(dr["valorc"]);
                        lista[5] = Convert.ToString(dr["valorv"]);
                        lista[6] = Convert.ToString(dr["quant"]);

                        ListViewItem lvi = new ListViewItem(lista);
                        list.Items.Add(lvi);


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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           
                bool ct = true;
                
                if (txbNomep.Text == "")
                {
                    ct = false;
                }
                if (txbdesc.Text == "")
                {
                    ct = false;
                }
                if (txbfornep.Text == "")
                {
                    ct = false;
                }
                if (txbpc.Text == "")
                {
                    ct = false;
                }
                if (txbpv.Text == "")
                {
                    ct = false;
                }
                if (ct == false)
                {
                    MessageBox.Show("Prencha todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (ct == true)
                {

                    try
                    {
                        string ts = txbfornep.Text;
                        Convert.ToInt64(ts);

                    }
                    catch
                    {
                        MessageBox.Show("CNPJ INCORETO use apenas numeros", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ct = false;
                    }
                    try
                    {
                        string ts = txbpc.Text;
                        Convert.ToDecimal(ts);

                    }
                    catch
                    {
                        MessageBox.Show("PREÇO DE CUSTO INCORETO USE APENAS NUMEROS E '.' PARA CEPARAR AS DECIMAIS", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ct = false;
                    }
                    try
                    {
                        string ts = txbpv.Text;
                        Convert.ToDecimal(ts);

                    }
                    catch
                    {
                        MessageBox.Show("PREÇO DE VENDA INCORETO USE APENAS NUMEROS E ',' PARA CEPARAR AS DECIMAIS", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ct = false;
                    }
                    try
                   {
                    string ts = txbquant.Text;
                    Convert.ToDecimal(ts);

                    }
                     catch
                    {
                    MessageBox.Show("QUANTIDADE INCORETO USE APENAS NUMEROS E ',' PARA CEPARAR AS DECIMAIS", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ct = false;
                    }

            }
                if (ct == true)
                {








                  string s;

                 s = list.SelectedItems[0].Text.ToString();
                




                Controle controle = new Controle();
                    string mensagem = controle.ModificP(s,txbNomep.Text, txbdesc.Text, txbfornep.Text, txbpc.Text, txbpv.Text, txbquant.Text);





                    if (controle.tem)
                    {


                        txbNomep.Text = "";
                        txbdesc.Text = "";
                        txbfornep.Text = "";
                        txbpc.Text = "";

                        txbpv.Text = "";
                      txbquant.Text = "";






                        MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show(controle.mensagem);//erro
                    }

                
                }
            return;
        }

        private void btnEX_Click(object sender, EventArgs e)
        {
           

           

        

            if (MessageBox.Show("DESEJA EXCLUIR PERMANENTE MENTE ", "Cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
             {    Controle lo = new Controle();
                  string mensagem = lo.Exp(list.SelectedItems[0].Text.ToString());
                if (lo.tem)
                {
                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
                else
                {
                    MessageBox.Show(lo.mensagem);//erro
                }
                txbNomep.Text = "";
                txbdesc.Text = "";
                txbfornep.Text = "";
                txbpc.Text = "";

                txbpv.Text = "";
                txbquant.Text = "";
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

          

        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0) {

                txbNomep.Text = list.SelectedItems[0].SubItems[1].Text;
                txbdesc.Text = list.SelectedItems[0].SubItems[2].Text;
                txbfornep.Text = list.SelectedItems[0].SubItems[3].Text;
                txbpc.Text = list.SelectedItems[0].SubItems[4].Text;
                txbpv.Text = list.SelectedItems[0].SubItems[5].Text;
                txbquant.Text = list.SelectedItems[0].SubItems[6].Text;
            }
        }

        private void btnall_Click(object sender, EventArgs e)
        {
           
            
           
            
                cmd.CommandText = "select * from PRODUTO  ";

                


                try
                {
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();






                    string[] lista = new string[7];

                    //percorre o sqldatareader para obter os dados
                    while (dr.Read())
                    {
                        //Coluna da quantidade 

                        //aparecer nome do produto na label

                        //coluna descricao
                        lista[0] = Convert.ToString(dr["id_PROD"]);
                        lista[1] = Convert.ToString(dr["nomep"]);
                        lista[2] = Convert.ToString(dr["descp"]);
                        lista[3] = Convert.ToString(dr["fornep"]);
                        lista[4] = Convert.ToString(dr["valorc"]);
                        lista[5] = Convert.ToString(dr["valorv"]);
                        lista[6] = Convert.ToString(dr["quant"]);

                        ListViewItem lvi = new ListViewItem(lista);
                        list.Items.Add(lvi);


                    }

                   

                    con.desconectar();


                    dr.Close();

                  











                }
                catch (SqlException)
                {

                    MessageBox.Show("erro com banco de dados", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            return;

            



        

        }
    }
}
