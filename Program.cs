using System;
using Figgle;
namespace Escala_Musical
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string n1 = "Dó";
            string n2 = "Re";
            string n3 = "Mi";
            string n4 = "Fa";
            string n5 = "Sol";
            string n6 = "La";
            string n7 = "Si";

            string tonica;
            string terça = n3.ToUpper();
            string quinta = n5.ToUpper();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--- Simulador de Escala Musical ## ---\n");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("--- Descubra a escala musical tônica, terça e quinta ---\n");
            
            Console.Write("Digíte uma nota para saber sua tônica, terça e quinta..: ");
            tonica = Console.ReadLine().ToUpper();


            if(tonica == n1);

            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"A sua Tônica é..: {tonica}");
                Console.WriteLine($"A sua Terça é ..: {terça}");
                Console.WriteLine($"A sua Quinta é ..: {quinta}");
            }


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nObrigado por utilizar nosso programa!\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(FiggleFonts.Big.Render("Escala-Musical ##"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("## Pressione uma tecla para encerrar...");
            
            Console.ReadKey();
        }
    }
}
