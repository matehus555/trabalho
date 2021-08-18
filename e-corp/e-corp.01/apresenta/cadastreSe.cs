using e_corp._01.dal;
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
	public partial class cadastreSe : Form
	{
		public cadastreSe()
		{
			InitializeComponent();
		}

		private void CADASTRE_SE_Load(object sender, EventArgs e)
		{

		}


		public static bool IsCpf(string cpf)
		{
			int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			string tempCpf;
			string digito;
			int soma;
			int resto;
			cpf = cpf.Trim();
			cpf = cpf.Replace(".", "").Replace("-", "");
			if (cpf.Length != 11)
				return false;
			tempCpf = cpf.Substring(0, 9);
			soma = 0;

			for (int i = 0; i < 9; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = resto.ToString();
			tempCpf = tempCpf + digito;
			soma = 0;
			for (int i = 0; i < 10; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = digito + resto.ToString();
			return cpf.EndsWith(digito);
		}
		Controle controle = new Controle();

		private void btnCadastro_Click(object sender, EventArgs e)
		{
			bool tudo = true;
			if (txbNome.Text == "")
			{
				tudo = false;
			}
			if (txbUser.Text == "")
			{
				tudo = false;
			}
			if (txbSenha.Text == "")
			{
				tudo = false;
			}
			if (txbSenhaR.Text == "")
			{
				tudo = false;
			}
			if (txbEmail.Text == "")
			{
				tudo = false;
			}
			if (txbData.Text == "")
			{
				tudo = false;
			}
			string dataVeri = txbData.Text;
			if (tudo == false)
            {
				MessageBox.Show("Prencher todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			if (tudo == true)
			{
				try
				{
					Convert.ToDateTime(dataVeri);

				}
				catch
				{
					tudo = false;
					MessageBox.Show("formato da data deve ser 'DD/MM/AAAA'", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}


			if (tudo.Equals(true))
			{
				bool cpder;
				string cpf1;
				cpf1 = txbCpf.Text;
				cpder = IsCpf(cpf1);










				if (cpder.Equals(true))
				{








					Controle lo = new Controle();
					string mensagem = lo.cadastrar(txbNome.Text, txbUser.Text, txbCpf.Text, txbSenha.Text, txbData.Text, txbEmail.Text, txbSenhaR.Text);



					if (lo.tem)
					{
						MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
						
					}
					else
					{
						MessageBox.Show(lo.mensagem);//erro
					}
				}
				else
				{
					MessageBox.Show("cpf invalido", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information); //erro
				}

			}
			
		}
	}
}
