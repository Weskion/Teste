using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class ClasseConexao
    {
        //função que permitirá a conexão da aplicação com o banco de dado SQL SERVER
        public SqlConnection Conexao()
        {
            //variável de texto conectar recebe o valor contendo o local do banco de dados, qual é o banco necessario e a forma de segurança
            string conectar = "DATA SOURCE=DESKTOP-BDH19QU\\SQLEXPRESS; INITIAL CATALOG=Teste; USER ID=SA; PASSWORD=123456";
            //inicia a conexão com o banco por meio do System.Data.SqlClient
            SqlConnection con = new SqlConnection(conectar);
            //a conexão é aberta
            con.Open();
            //e retornado o SqlConnection que mantem a conexão
            return con;
        }
        public DataTable Login_usuario(string sql)
        {
            DataTable tabela = new DataTable();
            SqlConnection conectar = Conexao();
            SqlDataAdapter script = new SqlDataAdapter(sql, conectar);
            script.Fill(tabela);

            conectar.Close();

            return tabela;
        }
        public string Cadastrar_usuario(string nome, string email, string senha)
        {
            //mensagem no caso da função ser bem sucedida
            string mensagem = "Cadastro concluido com sucesso";
            //texto com o script necessario para inserir os valores nome, email e senha na tabela usuarios
            string sql = "INSERT USUARIOS (NOME, EMAIL, SENHA) VALUES (@NOME, @EMAIL, @SENHA)";
            
            //quando a função for bem sucedida
            try
            {
                //conectar irá abrir a conexão com o banco de dados
                SqlConnection conectar = Conexao();
                //usando o script salvo em sql e a conexão sql como parâmetros pemitira a execução do comando no banco de dados
                SqlCommand comando = new SqlCommand(sql, conectar);
                //estão sendo adicionado novos parâmetros onde os valores no script sql são substituidos pelos parametros recebidos da tela de cadastro
                comando.Parameters.Add(new SqlParameter("@NOME", nome));
                comando.Parameters.Add(new SqlParameter("@EMAIL", email));
                comando.Parameters.Add(new SqlParameter("@SENHA", senha));
                //o comando esta sendo executado
                comando.ExecuteNonQuery();
                //a conexão´esta sendo fechada
                conectar.Close();
                //uma mensagem positiva é retornada
                return mensagem;
            }
            //quando a função exivir um problema
            catch
            {
                //uma mensagem negativa será retornada
                mensagem = "Erro no sistema";
                return mensagem;
            }

        }
    }
}
