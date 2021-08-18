using e_corp._01.apresenta;
using e_corp._01.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_corp._01.dal
{
    class LoginDaoControle
    {

        public bool igual = true;
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarlogin(string user, string senha)
        {//  comando pra verificar o login
            cmd.CommandText = "select * from USUARIO where usuario = @usuario and senha = @senha ";
            cmd.Parameters.AddWithValue("@usuario", user);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                cmd.Parameters.Clear();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de dados!";

            }
            return tem;
        }

        public string cadasatrar(string nome, string user, string cpf, string senha, string idade, string email, string senhar)
        {

            igual = false;
            if (senha.Equals(senhar))
            {

                Convert.ToInt64(cpf);
                cmd.CommandText = "select * from USUARIO where usuario = @usuario or cpf = @cpf ";
                cmd.Parameters.AddWithValue("@usuario", user);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                try
                {
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        igual = true;
                    }
                    con.desconectar();

                    dr.Close();
                }
                catch (SqlException)
                {
                    this.mensagem = "erro com Banco de Dados";
                }


                if (igual == false)
                {
                    Convert.ToDateTime(idade);
                    Convert.ToInt64(cpf);


                    cmd.CommandText = "insert into USUARIO values ( @nome , @usuario , @cpf , @email ,@senha , @dnsc );";
                    cmd.Parameters.AddWithValue("@nome", nome);

                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@dnsc", idade);


                    // cadstrar usuario no banco


                    try
                    {

                        cmd.Connection = con.conectar();
                        cmd.ExecuteNonQuery();
                        con.desconectar();
                        this.mensagem = "cadastro efetuado";
                        tem = true;

                        dr.Close();
                        MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cadastreSe c = new cadastreSe();
                        c.Close();
                    }
                    catch (SqlException)
                    {
                        this.mensagem = "erro com Banco de Dados";
                    }


                }
                else
                {
                    this.mensagem = "usuario ou cpf ja cadastrado";
                }
            }
            else
            {
                this.mensagem = "senhas não corepondem";
            }
            return mensagem;
        }
        public string CadastrarP(string nomep, string descp, string fornep, string vc, string vv, string est)
        {
            vc = vc.Replace(',', '.');
            vv = vv.Replace(',', '.');
            est = est.Replace(',', '.');
            Convert.ToInt64(fornep);
            Convert.ToDouble(vc);
            Convert.ToDouble(vv);
            Convert.ToDouble(est);



            cmd.CommandText = "insert into PRODUTO values ( @nomep , @descp , @fornep , @valorc , @valorv , @quant );";
            cmd.Parameters.AddWithValue("@nomep", nomep);
            cmd.Parameters.AddWithValue("@descp", descp);
            cmd.Parameters.AddWithValue("@fornep", fornep);
            cmd.Parameters.AddWithValue("@valorc", vc);
            cmd.Parameters.AddWithValue("@valorv", vv);
            cmd.Parameters.AddWithValue("@quant", est);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();

                cmd.Parameters.Clear();

                this.mensagem = "cadastro efetuado";
                tem = true;






            }
            catch (SqlException)
            {

                this.mensagem = "erro com Banco de Dados";
            }
            return mensagem;



        }
        public string ModificP(string id, string nomep, string descp, string fornep, string vc, string vv, string est)
        {
            vc = vc.Replace(',', '.');
            vv = vv.Replace(',', '.');
            est = est.Replace(',', '.');
            Convert.ToInt64(fornep);
            Convert.ToDouble(vc);
            Convert.ToDouble(vv);
            Convert.ToDouble(est);
            Convert.ToInt16(id);



            cmd.CommandText = " update PRODUTO set nomep = @nomep  where id_PROD = @id  ; update PRODUTO set descp = @descp  where id_PROD = @id  ; update PRODUTO set fornep = @fornep  where id_PROD = @id  ; update PRODUTO set valorc = @valorc  where id_PROD = @id  ; update PRODUTO set valorv = @valorv  where id_PROD = @id  ; update PRODUTO set quant = @quant  where id_PROD = @id ;  ";




            cmd.Parameters.AddWithValue("@nomep", nomep);
            cmd.Parameters.AddWithValue("@descp", descp);
            cmd.Parameters.AddWithValue("@fornep", fornep);
            cmd.Parameters.AddWithValue("@valorc", vc);
            cmd.Parameters.AddWithValue("@valorv", vv);
            cmd.Parameters.AddWithValue("@quant", est);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                cmd.Parameters.Clear();


                this.mensagem = "cadastro atualizado";
                tem = true;






            }
            catch (SqlException)
            {

                this.mensagem = "erro com Banco de Dados";
            }
            return mensagem;



        }
        public string Exp(string id)
        {
;
            
            

                Convert.ToInt32(id);
                cmd.CommandText = " delete PRODUTO  where id_PROD = @id ; ";
                cmd.Parameters.AddWithValue("@id", id);
               
                try
                {
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        igual = true;
                    }
                    con.desconectar();
                
                    dr.Close();
                this.mensagem = "EXCLUIDO !";
                }
                catch (SqlException)
                {
                    this.mensagem = "erro com Banco de Dados";
                }

            
            return mensagem;
        }
        public string cadasatrarC(string nome, string cpf, string idade, string endr, string tel)
        {

            igual = false;
          
            

                Convert.ToInt64(cpf);
                cmd.CommandText = "select * from CLIENTE where cpf   = @cpf ";
             
                cmd.Parameters.AddWithValue("@cpf", cpf);
                try
                {
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        igual = true;
                    }
                    con.desconectar();

                    dr.Close();
                }
                catch (SqlException)
                {
                    this.mensagem = "erro com Banco de Dados";
                }


                if (igual == false)
                {
                    Convert.ToDateTime(idade);
                    Convert.ToInt64(cpf);


                    cmd.CommandText = "insert into CLIENTE values ( @nome ,  @cpf , @tel ,@dt , @end );";
                    cmd.Parameters.AddWithValue("@nome", nome);

                    cmd.Parameters.AddWithValue("@end", endr);


                cmd.Parameters.AddWithValue("@tel", tel);

                cmd.Parameters.AddWithValue("@dt", idade);


                    // cadstrar usuario no banco


                    try
                    {

                        cmd.Connection = con.conectar();
                        cmd.ExecuteNonQuery();
                        con.desconectar();
                        this.mensagem = "cadastro efetuado";
                        tem = true;

                       
                        MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    catch (SqlException)
                    {
                        this.mensagem = "erro com Banco de Dados";
                    }


                }
                else
                {
                    this.mensagem = " cpf ja cadastrado";
                }
            
        
            
            return mensagem;
        }
        public string Conslta( string cpf )
        {
            
            Convert.ToInt64(cpf);
            cmd.CommandText = "select * from CLIENTE where cpf   = @cpf ";
            string tem = "n";
            cmd.Parameters.AddWithValue("@cpf", cpf);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //Coluna da quantidade 

                        //aparecer nome do produto na label

                        //coluna descricao
                        tem = Convert.ToString(dr["nome"]);



                        


                    }
                }
                con.desconectar();

                dr.Close();
            }
            catch (SqlException)
            {
                // "erro com Banco de Dados";
            }
            return tem;
        }
    } 
 }
