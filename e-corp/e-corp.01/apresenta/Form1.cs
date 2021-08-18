using e_corp._01.apresenta;
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

namespace e_corp._01
{
    public partial class corp : Form
    {
        public corp()
        {
            InitializeComponent();
        }

        private void cadT1_Click(object sender, EventArgs e)
        {
            

            cadastreSe cad = new cadastreSe();
            cad.Show();
            
        }

        private void Btnentrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
                   controle.acessar(nomedeuser.Text, senhalog.Text);
            if (controle.mensagem.Equals(""))
            {
                
                if (controle.tem)
                {
                   MessageBox.Show("LOGIN EFETUADO", "ENTRANDO", MessageBoxButtons.OK , MessageBoxIcon.Information);
                    Menu1 men1 = new Menu1();
                        men1.Show();
                }
                else
                {
                    MessageBox.Show("LOGIN FALHOU USUARIO ou SENHA INCORETOS ", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        
        }
    }
}
