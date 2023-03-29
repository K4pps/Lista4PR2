using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXEC 1
            //Falsa. int para float  ou vice-versa, é possivel porém em uma conversão indireta 

            //EXEC 2
            //Console.ReadLine() lê o valor da linha inteira ou string e o Console.Read() irá ler apenas um unico caracter.

            //EXEC 3
            //É necessário tomar cuidado para garantir que o valor inserido seja válido e possa ser convertido com segurança para o tipo de variável desejado

            //EXEC 4
            //O prpopósito do programa é divisivel por 2. Quando entra com o numero 8 ou 27 a saída é "Mensagem 2" e quando enytramos com o número 28 a saída é "mensagem 1".
            //int num, num2, num3;
            //Console.WriteLine("Entre com um número: ");
            //num = int.Parse(Console.ReadLine());
            //num2 = num / 2;
            //num3 = num % 2;
            //if (num3 == 0 && num2 * 2 > 10)
            //    Console.WriteLine("Mensagem 1");
            //else
            //    Console.WriteLine("Mensagem 2");

            //Exec 5

            //double posi1, tempo, velo, posifinal;

            //Console.WriteLine("Qual a posição inicial: ");
            //posi1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Qual a velocidade:");
            //velo = double.Parse(Console.ReadLine());

            //Console.WriteLine("Qual o tempo:");
            //tempo = double.Parse(Console.ReadLine());

            //posifinal = posi1 + velo * tempo;
            //Console.WriteLine("A posicão final é " + posifinal);

            //Console.ReadKey();

            //Exec 6

            //int num;

            //Console.WriteLine("Digite um número inteiro: ");
            //num = int.Parse(Console.ReadLine());

            ////resolução
            //{
            //    if (num % 3 == 0 && num % 5 == 0 && num % 10 == 0)
            //        Console.WriteLine("O número é divisível por 3, 5 e 10");

            //    else if (num % 3 == 0 && num % 5 == 0)
            //        Console.WriteLine("O número é divisível por 3 e 5 ");

            //    else if (num % 3 == 0)
            //        Console.WriteLine("O número é divisível por 3");

            //    else if (num % 5 == 0)
            //        Console.WriteLine("O número é divisível por 5");

                //Exec 7

                // distância da casa do aluno até a escola (em km)
                //int distancia = 0;
                //Console.Write("Digite a distância da sua casa até a escola (em km): ");
                //distancia = int.Parse(Console.ReadLine());

                //double velocami = 5;
                //double velobike = 15;
                //double velocidade_onibus = 30;
                //double tempo_caminhada = distancia * 1.0 / velocami;
                //double tempo_bicicleta = (50 - distancia) * 1.0 / velobike;
                //double tempo_onibus = (100 - 50) * 1.0 / velocidade_onibus;
                //double tempo_total = tempo_caminhada + tempo_bicicleta + tempo_onibus;

                //Console.WriteLine("O tempo gasto para chegar na escola é de " + tempo_total + " horas.");
            }
        }

    }



