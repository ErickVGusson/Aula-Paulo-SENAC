using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATVs_15_08_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int menu;

            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - Média de três números");
            Console.WriteLine("2 - Troco de compra");
            Console.WriteLine("3 - Conversão de temperatura");
            Console.Write("Escolha a opção: ");
            menu = int.Parse(Console.ReadLine());

            if (menu == 1) {

                float n1, n2, n3, media;

                Console.Write("Digite o 1º valor: ");
                n1 = float.Parse(Console.ReadLine());

                Console.Write("Digite o 2º valor: ");
                n2 = float.Parse(Console.ReadLine());

                Console.Write("Digite o 3º valor: ");
                n3 = float.Parse(Console.ReadLine());

                media = (n1 + n2 + n3) / 3;

                Console.WriteLine("O valor media deu: " + media);

                Console.ReadKey();

            }

            if (menu == 2) {

                float valor, pagamento, diferenca;

                Console.Write("Digite o valor total da compra: R$");
                valor = float.Parse(Console.ReadLine());

                Console.Write("Digite o valor do pagamento: R$");
                pagamento = float.Parse(Console.ReadLine());

                diferenca = valor - pagamento;

                if (diferenca > 0)
                {

                    Console.WriteLine("Calma ai paizão, você acha mesmo que da para pegar so com isso ai?");

                }

                else
                {

                    Console.WriteLine("Pago troco de: R$" + -diferenca);

                }

                Console.ReadKey();

            }

            if (menu == 3) {

                float c, f;

                Console.WriteLine("Digite a temperatura em celsius: ");
                c = float.Parse(Console.ReadLine());

                f = (c * 9 / 5) + 32;

                Console.WriteLine("A temperatura de " + c + " ºC, é igual a: " + f);

                Console.ReadKey();

            }

        }
    }
}
