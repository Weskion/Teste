using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //botão que executará o cadastro
        private void btncadastrar_Click(object sender, EventArgs e)
        {
            //variáveis de texto que receberão os valores das caixas de texto
            string nome = tboxnome.Text;
            string email = tboxemail.Text;
            string senha = tboxsenha.Text;

            //conexao se tornou uma classe interna da ClasseConexao
            ClasseConexao conexao = new ClasseConexao();
            //mensagem recebera o resultado da função Cadastrar_usuario usando os valores recebidos das caixas de texto como parãmetros
            string mensagem = conexao.Cadastrar_usuario(nome, email, senha);
            //uma caixa de mensagem mostrando se o cadastro foi bem sucedido
            MessageBox.Show(mensagem);
            //os valores nas caixas de textos serão apagados
            tboxnome.Text = "";
            tboxemail.Text = "";
            tboxsenha.Text = "";
        }
    }
}
