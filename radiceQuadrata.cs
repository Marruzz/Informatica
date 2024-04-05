namespace _12_13___radiceQuadrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero dal quale ne estrarrò la radice quadrata: ");
            int numero = int.Parse(Console.ReadLine());
            int i = 0;
            int counterSottrazioni = 1;
            while(numero > 0)
            {
                numero -= counterSottrazioni;
                counterSottrazioni += 2;
                i++;
            }
            if (numero < 0)
            {
                Console.WriteLine("Il numero inserito non è un quadrato perfetto");
                return;
            }
            Console.WriteLine($"La radice quadrata è: {i}");
        }
    }
}
