using System


using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Calculadora
{
    class Program
    {
        static void Main (string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Resto de Divisao");
            Console.WriteLine("6 - Potenciacao");
            Console.WriteLine("0 - Sair");

            string opcao = Console.ReadLine();

            Switch(opcao)
            {
                case "1":
                    Somar();
                    break;
                case "2":
                    Subtrair();
                    break;
              /*  case "3":
                Multiplicar():
                    break;
                case "4":
                Dividir();
                    break;
                case "5":
                RestoDeDivsao();
                    break;
                case "6":
                Potenciacao();
                    break
                case "0":
                    break;*/
            }
        }
        
    }
    public static void Somar()
    {
        double valor1, valor2;

        Console.WriteLine("Entre com o primeiro valor:");
        valor1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o segunda valor:");
        valor2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"{valor1} + {valor2} = {valor1 + valor2}");
        Console.ReadLine();
        Menu();
    }
    
    public static void Subtrair();
    
        double valor1, valor2;

        Console.WriteLine("Entre com o primeiro valor:");
        valor1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o segundo valor:");
        valor2 = double.Parse(Console.ReadLine());
    

    
}