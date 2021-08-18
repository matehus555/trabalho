using e_corp._01.apresenta;
using e_corp._01.dal;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_corp._01.modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";
        public static void CamposVazios(Control _ctrl)
        {
            foreach (Control c in _ctrl.Controls)
            {
                if (c.HasChildren)
                {
                    CamposVazios(c);
                }
                else if (c is TextBox)
                {
                    if (String.IsNullOrEmpty(((TextBox)c).Text))
                    {
                        throw new Exception("Campo " + c.Name + " está vazio");
                    }
                }
                else if (c is ComboBox)
                {
                    if (((ComboBox)c).SelectedValue == null)
                    {
                        throw new Exception("Campo " + c.Name + " está vazio");
                    }
                }
            }
        }


        public bool acessar(string user, string senha)
        {
            LoginDaoControle loginDao = new LoginDaoControle();
            tem = loginDao.verificarlogin(user, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;

            }
            return tem;
        }
        public string cadastrar(string nome, string user, string cpf, string senha, string idade, string email, string senhar)
        {
            LoginDaoControle log = new LoginDaoControle();
            this.mensagem = log.cadasatrar(nome, user, cpf, senha, idade, email, senhar);

            if (log.tem)//mensagem de sucess
            {
                this.tem = true;
                cadastreSe o = new cadastreSe();
                o.Close();
            }

            return mensagem;
        }
        public string CadastrarP(string nomep, string descp, string fornep, string vc, string vv, string est)
        {
            est = "1";
            LoginDaoControle logp = new LoginDaoControle();
            this.mensagem = logp.CadastrarP(nomep, descp, fornep, vc, vv, est);
            if (logp.tem)//mensagem de sucess
            {
                this.tem = true;
               
            }
            return mensagem;
        }

        public string ModificP(string id,string nomep, string descp, string fornep, string vc, string vv, string quant)
        {
           
            LoginDaoControle logp = new LoginDaoControle();
            this.mensagem = logp.ModificP(id ,nomep, descp, fornep, vc, vv, quant);
            if (logp.tem)//mensagem de sucess
            {
                this.tem = true;

            }
            return mensagem;
        }
        public string Exp(string id)
        {

            LoginDaoControle logp = new LoginDaoControle();
            this.mensagem = logp.Exp(id);
            if (logp.tem)//mensagem de sucess
            {
                this.tem = true;

            }
            return mensagem;
        }
        public string cadastrarC(string nome,  string cpf,  string idade, string endr, string tel)
        {
            LoginDaoControle log = new LoginDaoControle();
            this.mensagem = log.cadasatrarC(nome,cpf, idade, endr ,tel);

            if (log.tem)//mensagem de sucess
            {
                this.tem = true;
               
            }

            return mensagem;
        }
    }
}  

