namespace WinFormsApp1
{
    public partial class form_calculo : Form
    {
        public form_calculo()
        {
            InitializeComponent();
        }
        public string nome_usuario;
        //array publico onde serão contidos todos os números impares de 0 a 1000
        public static int[] impar = new int[1000];
        //função contida no botão somar
        private void btn_somar_Click(object sender, EventArgs e)
        {
            int b = 0;

            //laço de repetição onde "a" começa com o valor 0
            //enquanto a for menor que 1000 será acresentado + 1 ao seu valor
            for (int a = 0; a < 1000; a++)
            {
                //se o resto da divisão entre "a" e "2" for diferente de 0
                if (a % 2 != 0)
                {
                    //o valor de a será acresentado no array impar na posição que corresponde ao valor de b (o indice dos arrays começam da posição 0)
                    impar[b] = a;
                    //b tera seu valor acrescentado em + 1
                    b++;
                }
            }
            //as variáveis "x" e "y" receberão os valores contidos nas caixas de texto correspondentes 
            var x = tboxprimeironum.Text;
            var y = tboxsegundonum.Text;
            //a variável mensagem receberá o resultado da função Soma usando "x" e "y" como parâmetros
            var mensagem = Calculo.Soma(x, y);
            //será retornado uma caixa de texto com o valor da mensagem
            MessageBox.Show(mensagem);
        }
    }
}