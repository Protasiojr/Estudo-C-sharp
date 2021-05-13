using System;
using System.Globalization;

namespace cursocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            double altura;
            char sexo;

            nome = Console.ReadLine();
            idade = int.Parse(Console.ReadLine());
            altura = double.Parse(Console.ReadLine());
            sexo = char.Parse(Console.ReadLine());

            Console.Write("Seu nome é " + nome + " ele tem " + idade + " anos de idade, mede " + altura + " de altura e seu sexo é: " + sexo);
        }
    }
}
