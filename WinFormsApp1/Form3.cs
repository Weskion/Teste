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

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void btn_login_Click(object sender, EventArgs e)
        {
            //os valores das caixas de texto esta sendo transferido para a variáveis de texto correspondentes
            string nome = tbox_nome.Text;
            string email = tbox_email.Text;
            string senha = tbox_senha.Text;

            //comando de bisca no banco sql com os valores nome, email e senha atribuidos
            string sql = "SELECT ID, NOME, EMAIL, SENHA FROM USUARIOS WHERE NOME = '" + nome + "' AND EMAIL = '" + email + "' AND SENHA = '" + senha + "'";

            //a conexão com o banco esta sendo aberta
            ClasseConexao con = new ClasseConexao();
            //o objeto DataTable tabela receberá os valores do banco de dados
            DataTable tabela = con.Login_usuario(sql);
            //se a contagem de linhas de dados no DataTable tabela for diferente de 0
            if (tabela.Rows.Count != 0)
            {
                //mensagem de aviso monstrando que o login foi bem sucedido
                MessageBox.Show("Login efetuado com sucesso");
                //for1 se torna uma classe interna da class form_calculo (calculadora)
                var form1 = new form_calculo();
                //essa janela é fechada
                this.Close();
                //o formulário form1 (claculadora) é aberto
                form1.Show();
            }
            //se a contagem de linhas de tabela for igual a 0, ou seja, esteja vazia
            else
            {
                //mensagem de aviso mostrando que os dados registrados não trouxeram retorno
                MessageBox.Show("Erro: Dados da conta errados ou inexistente");
            }

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //var form2 se torna uma classe interna da classe Form2 (classe do formulário cadastrar)
            var form2 = new Form2();
            //formulário é fechado
            this.Close();
            //o formulário de cadastro é mostrado novamente
            form2.Show();
        }
    }
}
