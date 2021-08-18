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
    public partial class Menu1 : Form
    {
        public Menu1()
        {
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            produtos_cad produtos_Cad1 = new produtos_cad();
            produtos_Cad1.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque l = new Estoque();
            l.Show();
        }

        private void manutençaoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadcli l = new cadcli();
            l.Show();
        }

        private void Menu1_Load(object sender, EventArgs e)
        {

        }

        private void btnvenda_Click(object sender, EventArgs e)
        {
            telaVendas h = new telaVendas();
            h.Show();
        }

        private void btnconsultarv_Click(object sender, EventArgs e)
        {
            Consltarv h = new Consltarv();
            h.Show();
        }
    }
}
