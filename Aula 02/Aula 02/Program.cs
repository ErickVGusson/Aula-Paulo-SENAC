using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float b;
            float a;
            float soma;
            float subtracao;
            float multiplicacao;
            float divisao;

            Console.Write( "Digite o 1º número: " );
            a = float.Parse( Console.ReadLine() );

            Console.Write( "Digite o 2º número: " );
            b = float.Parse( Console.ReadLine() );

            soma = a + b ;
            subtracao = a - b ;
            multiplicacao = a * b ;
            divisao = a / b ;
            
            Console.WriteLine( "\nA soma dos valores deu: " + soma );
            Console.WriteLine( "A subtração dos valores deu: " + subtracao );
            Console.WriteLine( "A multiplicação dos valores deu: " + multiplicacao );
            Console.WriteLine( "A divisão dos valores deu: " + divisao );





            //Console.WriteLine("Hello world");

            Console.ReadKey();

        }
    }
}