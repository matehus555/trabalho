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
    public partial class Consltarv : Form

    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public Consltarv()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnbcod_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (txbCod.Text != "")
            {
                cmd.CommandText = "select * from arq where  codv = @nome  ";

                cmd.Parameters.AddWithValue("@nome", Convert.ToInt32(txbCod.Text));


                try
                {
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();




                    int cont = 0;

                    string[] lista = new string[6];

                    //percorre o sqldatareader para obter os dados
                    while (dr.Read())
                    {
                        //Coluna da quantidade 

                        //aparecer nome do produto na label

                        //coluna descricao
                       

                        lista[4] = Convert.ToString(dr["Cfp"]);
                        lista[0] = Convert.ToString(dr["idp"]);

                        lista[2] = Convert.ToString(dr["quantp"]);
                        lista[3] = Convert.ToString(dr["valor"]);
                        lista[5] = Convert.ToString(dr["dtc"]);


                        ListViewItem lvi = new ListViewItem(lista);
                        listView1.Items.Add(lvi);
                        cont = cont + 1;


                    }

                    cmd.Parameters.Clear();

                    con.desconectar();

                    lbcont.Text = Convert.ToString(cont);
                    dr.Close();

                    txbCod.Text = "";
                  


                    int h = 0;
                    while (cont > h)
                    {
                        cmd.CommandText = "select * from PRODUTO where  id_PROD = @id  ";

                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(listView1.Items[h].Text));


                        try
                        {
                            cmd.Connection = con.conectar();
                            dr = cmd.ExecuteReader();

                             string nome;

                            while (dr.Read())
                            {
                                //Coluna da quantidade 

                                //aparecer nome do produto na label

                                //coluna descricao

                              nome = Convert.ToString(dr["nomep"]);


                            listView1.Items[h].SubItems[1].Text = nome;
                              


                            }


                        

                            //percorre o sqldatareader para obter os dados


                            





                            cmd.Parameters.Clear();

                            con.desconectar();


                            dr.Close();






                        }
                        catch
                        {
                            MessageBox.Show("Erro Banco de dados", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        h = h + 1;
                    }
                }
                catch (SqlException)
                {

                    MessageBox.Show("CODIGO NAO EXISTE", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }



            }
        }

        private void btnbcpf_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            if (txbcpf.Text != "")
            {
                cmd.CommandText = "SELECT * FROM VENDA2 WHERE dtv BETWEEN @di AND @df  ";

                cmd.Parameters.AddWithValue("@di", dateTimePicker1);
                cmd.Parameters.AddWithValue("@df", dateTimePicker2);

                try
                {
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();




                   

                    string[] lista = new string[2];
                    string cpf;
                    //percorre o sqldatareader para obter os dados
                    while (dr.Read())
                    {
                        //Coluna da quantidade 

                        //aparecer nome do produto na label

                        cpf = Convert.ToString(dr["cfp"]);
                        //coluna descricao
                        if (txbcpf.Text == cpf)
                        {

                            lista[0] = Convert.ToString(dr["COD"]);
                            lista[1] = Convert.ToString(dr["dtv"]);
                            ListViewItem lvi = new ListViewItem(lista);
                        listView2.Items.Add(lvi);

                        }


                        



                    }

                    cmd.Parameters.Clear();

                    con.desconectar();

                    
                    dr.Close();

                    txbcpf.Text = "";

                }
                catch
                {
                    MessageBox.Show("Erro Banco de dados", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           



            }






        }
    }
    
