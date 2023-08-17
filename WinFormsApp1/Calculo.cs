using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Calculo
    {
        //função que permitira o calculo
        public static string Soma(string x, string y)
        {
            //irá converter os valores string dos parâmetros x e y para números inteiros e logo dapois atribui-los a num1 e num2
            int num1 = Convert.ToInt32(x);
            int num2 = Convert.ToInt32(y);


            //será verificado se os valores de num1 e num2 estão presentes no array impar[] de números inteiros
            if (form_calculo.impar.Contains(num1 & num2))
            {
                //se estiverem presentes no array impar e os valores forem maiores que 1000 será retornado um erro
                if (num1 > 1000 ^ num2 > 1000)
                {
                    string erro = "Esta operação não aceita valores maiores que 1000";
                    return erro;
                }
                //se estiverem presentes no array impar e os valores forem menores que 1000 será retornado o valor resultado
                else
                {
                    int resultado = num1 + num2;
                    //o parametro resultado esta sendo convertido para o tipo string, pois a função só irá retornar valores string
                    return resultado.ToString();
                }
            }
            //se não estiverem no array impar sera retornado uma mensagem de erro
            else
            {
                string erro_num = "São aceitos apenas valores ímpares abaixo de 1000";
                return erro_num;
            }
        }
    }
}
