using System;
using System.Globalization;

namespace cursocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura = double.Parse(Console.ReadLine());
            double comprimento = double.Parse(Console.ReadLine());
            double area;
            double valorPorMetroQuadrado = double.Parse(Console.ReadLine());
            double preco;

            area = largura * comprimento;
            preco = area * valorPorMetroQuadrado;

            Console.Write("A área do terreno é de: " + area.ToString("F2") + " e seu valor é: " + preco.ToString("F2"));

        }
    }
}
