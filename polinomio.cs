namespace _12_13___polinomio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = -12;
            int yMax = x;
            int yMin = x;
            int xMax = x;
            int xMin = x;
            int zero = x;
            while (x>=-12 && x<=16)
            {
                int y = x ^ 6 - 3 * x ^ 5 - 93 * x ^ 4 - 87 * x ^ 3 + 1596 * x ^ 2 - 1380 * x - 2800;
                if (y > yMax)
                {
                    yMax = y;
                    xMax = x;
                    
                }
                else if (y < yMin)
                {
                    yMin = x;
                    xMin = x;
                }
                else if (y == 0)
                { 
                zero = y;
                }
                x++;
            }
            Console.WriteLine("Il valore x con il quale la y è maggiore è = " + xMax);
            Console.WriteLine("Il valore x con il quale la y è minore è = " + xMin);
            Console.WriteLine("Il valore x con il quale il polinomio è nullo è = " + zero);
        }
    }
}
