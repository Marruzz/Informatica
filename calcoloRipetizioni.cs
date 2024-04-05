using System;

namespace _11_29___calcoloDelleRipetizioni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il numero di elementi che vuoi visionare");
            int numeroDiElementi = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il valore da cercare");
            int valoreDaCercare = int.Parse(Console.ReadLine());
            int valoreTrovato = 0;
            for (int i = 0; i < numeroDiElementi; i++)
            {
                Console.WriteLine("Inserisci il valore");  
                int valore = int.Parse(Console.ReadLine());
                if (valore == valoreDaCercare)
                {
                    valoreTrovato++;
                }
            }
            Console.WriteLine("Il valore " + valoreDaCercare + " è stato trovato " + valoreTrovato + " volte");
        }
    }
}
