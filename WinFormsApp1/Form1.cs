namespace WinFormsApp1
{
    public partial class form_calculo : Form
    {
        public form_calculo()
        {
            InitializeComponent();
        }
        public string nome_usuario;
        //array publico onde ser�o contidos todos os n�meros impares de 0 a 1000
        public static int[] impar = new int[1000];
        //fun��o contida no bot�o somar
        private void btn_somar_Click(object sender, EventArgs e)
        {
            int b = 0;

            //la�o de repeti��o onde "a" come�a com o valor 0
            //enquanto a for menor que 1000 ser� acresentado + 1 ao seu valor
            for (int a = 0; a < 1000; a++)
            {
                //se o resto da divis�o entre "a" e "2" for diferente de 0
                if (a % 2 != 0)
                {
                    //o valor de a ser� acresentado no array impar na posi��o que corresponde ao valor de b (o indice dos arrays come�am da posi��o 0)
                    impar[b] = a;
                    //b tera seu valor acrescentado em + 1
                    b++;
                }
            }
            //as vari�veis "x" e "y" receber�o os valores contidos nas caixas de texto correspondentes 
            var x = tboxprimeironum.Text;
            var y = tboxsegundonum.Text;
            //a vari�vel mensagem receber� o resultado da fun��o Soma usando "x" e "y" como par�metros
            var mensagem = Calculo.Soma(x, y);
            //ser� retornado uma caixa de texto com o valor da mensagem
            MessageBox.Show(mensagem);
        }
    }
}