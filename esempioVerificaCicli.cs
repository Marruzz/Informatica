namespace _12_15___preparazioneVerifica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p;
            do
            {
                Console.Clear();
                Console.WriteLine("Inserisci il peso ideale del prodotto: ");
                p = double.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci lo scarto, in eccesso o in difetto, del peso del prodotto: ");
                double s = double.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci il peso del prodotto: ");
                double pesoProdotto = double.Parse(Console.ReadLine());
                if (pesoProdotto != p)
                {
                    if (pesoProdotto - s > p)
                    {
                        double pesoEccesso = pesoProdotto - p;
                        Console.WriteLine("Il peso del prodotto è troppo grande: " + pesoEccesso + " g di troppo");
                    }
                    else if (pesoProdotto + s < p)
                    {
                        double pesoDifetto = p - pesoProdotto;
                        Console.WriteLine("Il peso del prodotto è troppo piccolo: " + pesoDifetto + " g di difetto");
                    }
                }
            } while (p !=  0);
        }
    }
}
