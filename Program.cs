using System;

namespace Calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Qual operação deseja fazer? ");
            char op = Console.ReadKey(true).KeyChar;
            Console.WriteLine(op);
            if (op == '+')
            {
                Console.WriteLine("Seu resultado é: " + (num1 + num2));
            }
            else if (op == '-')
            {
                Console.WriteLine("Seu resultado é: " + (num1 - num2));
            }
            else if (op == '*')
            {
                Console.WriteLine("Seu resultado é: " + (num1 * num2));
            }
            else if (op == '/')
            {
                Console.WriteLine("Seu resultado é: " + (num1 / num2));
            }
            else Console.WriteLine("Você não escolheu uma operação válida");







        }
       
    }
} 
