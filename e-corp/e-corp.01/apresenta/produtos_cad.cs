using e_corp._01.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_corp._01.apresenta
{
    
    public partial class produtos_cad : Form
    {
        public produtos_cad()
        {
            InitializeComponent();
        }
       
        

        
        private void btnCadP_Click(object sender, EventArgs e)
        {
            bool ct = true;
            string est = "1";
            if (txbNomep.Text == "")
            {
                ct = false;
            }
            if (txbDesc.Text == "")
            {
                ct = false;
            }
            if (txbforne.Text == "")
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
            if(ct == false)
            {
                MessageBox.Show("Prencha todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ct == true)
            {
               
                try
                { 
                    string ts = txbforne.Text;
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
               

            }
            if (ct == true)
            {
               
                
               
                    

                






                Controle controle = new Controle();
                string mensagem = controle.CadastrarP(txbNomep.Text, txbDesc.Text, txbforne.Text, txbpc.Text, txbpv.Text, est);





                if (controle.tem)
                {


                    txbNomep.Text = "";
                    txbDesc.Text = "";
                    txbforne.Text = "";
                    txbpc.Text = "";

                    txbpv.Text = "";






                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show(controle.mensagem);//erro
                }
             
            } 
        }

        private void txbDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
