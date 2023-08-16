using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int menu;

            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - Verificação de Número Par ou Ímpar");
            Console.WriteLine("2 - Verificação de Maior Idade");
            Console.WriteLine("3 - Classificação de Números");
            Console.WriteLine("4 - Calculadora de IMC");
            Console.WriteLine("5 - Conversão de Nota em Letra");
            Console.WriteLine("6 - Verificação de Triângulo");
            Console.WriteLine("7 - Verificação de Ano Bissexto");
            Console.WriteLine("8 - Classificação de Faixa Etária");
            Console.Write("Escolha a opção: ");
            menu = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            if (menu == 1) 
            {

                Console.Clear();

                int numero;

                Console.Write("Digite o número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {

                    Console.WriteLine(numero + " é um número par");

                }

                else
                {

                    Console.WriteLine(numero + " não é par");

                }

                Console.ReadKey();

            }

            if (menu == 2) 
            {

                Console.Clear();

                int idade;

                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade < 18)
                {

                    Console.WriteLine("Não é de maior");
                }


                else
                {

                    Console.WriteLine("É de maior");

                }
                Console.ReadKey();
            }

            if (menu == 3)
            {

                Console.Clear();

                int n1, n2, n3;

                Console.Write("Digite o 1º número: ");
                n1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o 2º número: ");
                n2 = int.Parse(Console.ReadLine());
                
                Console.Write("Digite o 3º número: ");
                n3 = int.Parse(Console.ReadLine());

                if (n1 < n2 )
                {
                    if (n2 < n3)
                    {
                        Console.WriteLine(n1 + " " + n2 + " " + n3);
                    }
                    else
                    {
                        Console.WriteLine(n1 + " " + n3 + " " + n2);
                    }
                }
                else
                {
                    if(n2 < n3)
                    {
                        Console.WriteLine(n2 + " " + n1 + " " + n3);
                    }
                    else
                    {
                        Console.WriteLine(n3 + " " + n2 + " " + n1);
                    }
                }

                Console.ReadKey();

            }

            if (menu == 4)
            {

                Console.Clear();

                double peso, altura, imc;

                Console.Write("Digite o seu peso: ");
                peso = double.Parse(Console.ReadLine());

                Console.Write("Digite a sua altura: ");
                altura = double.Parse(Console.ReadLine());

                imc = peso / Math.Pow(altura, 2);

                Console.WriteLine("IMC: " + imc);

                if (imc < 18.5)
                {

                    Console.WriteLine("Baixo peso");

                }

                if (imc >= 18.5 && imc < 25 )
                {

                    Console.WriteLine("Peso normal");

                }

                if (imc >= 25 && imc < 30 )
                {

                    Console.WriteLine("Sobrepeso");

                }

                if (imc >= 30 && imc < 35 )
                {

                    Console.WriteLine("Obeso 1");

                }

                if(imc >= 35 &&  imc < 40)
                {

                    Console.WriteLine("Obeso 2");

                }

                if (imc >= 40)
                {

                    Console.WriteLine("obeso 3");

                }

                Console.ReadKey();

            }

            if (menu == 5)
            {

                Console.Clear();

                float nota;

                Console.WriteLine("Digite a nota: ");
                nota = float.Parse(Console.ReadLine());

                if (nota < 3 )
                {
                 
                    Console.WriteLine("Nota: F");
                    
                }
                
                if (nota >= 3 && nota < 6)
                {
                 
                    Console.WriteLine("Nota: D");
                    
                }
                
                if (nota >= 6 && nota < 8)
                {
                 
                    Console.WriteLine("Nota: C");
                    
                }
                
                if (nota >= 8 && nota < 10)
                {
                 
                    Console.WriteLine("Nota: B");
                    
                }
                
                if (nota == 10)
                {
                 
                    Console.WriteLine("Nota: A");
                    
                }

                Console.ReadKey();

            }

            if (menu == 6)
            {

                Console.Clear();

                float l1, l2, l3;

                Console.Write("Digite o 1º lado: ");
                l1 = float.Parse(Console.ReadLine());

                Console.Write("Digite o 2º lado: ");
                l2 = float.Parse(Console.ReadLine());

                Console.Write("Digite o 3º lado: ");
                l3 = float.Parse(Console.ReadLine());
                
                if (l1 == l2 && l2 == l3) 
                {
                    Console.WriteLine("Equiliatero");
                }

                else if (l1 != l2 && l1 != l3 && l2 != l3)
                {
                    Console.WriteLine("Escaleno");
                }
                else 
                {
                    Console.WriteLine("Isoceles");
                }
                
                Console.ReadKey();

            }

            if (menu == 7)
            {

                Console.Clear();

                int ano;

                Console.Write("Digite o ano: ");
                ano = int.Parse(Console.ReadLine());

                if (ano % 4 == 0 && ano % 100 != 0 || ano % 400 ==0)
                {
                    Console.WriteLine("Bissexto");
                }
                else
                {
                    Console.WriteLine("Normal");
                }

                Console.ReadKey();
            }

            if(menu == 8)
            {

                Console.Clear();

                int idade;

                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade >= 60)
                {

                    Console.WriteLine("Idoso");

                }
                else if (idade >= 18)
                {

                    Console.WriteLine("Adulto");

                }

                else if (idade >= 12)
                {

                    Console.WriteLine("Adolescente");

                }
                else
                {

                    Console.WriteLine("Criança");

                }



                Console.ReadKey ();
            }

        }
    }
}
