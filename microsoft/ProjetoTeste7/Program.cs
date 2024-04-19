using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Aula15();
        }

        static void Aula0()
        {
            var texto = "Testando " + " ";
            var texto2 = $"Testando {texto}";
            var texto3 = $"Testando {1 + 1}";
            var texto4 = @"\Testando \\";
            Console.WriteLine(texto);
            Console.WriteLine(texto2);
            Console.WriteLine(texto3);
            Console.WriteLine(texto4);
        }

        static void Aula1()
        {
            var texto = "Testando";
            Console.WriteLine(texto.CompareTo("Testando")); // Retorna 1 - Verdadeiro
            Console.WriteLine(texto.CompareTo("testando")); // Retorna 0
            Console.WriteLine(texto.CompareTo("")); // Retorna 0
            Console.WriteLine(texto.CompareTo(null)); // Retorna 0
        }