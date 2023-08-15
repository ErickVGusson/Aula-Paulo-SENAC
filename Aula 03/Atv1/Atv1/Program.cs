using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv1
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
    }
}
