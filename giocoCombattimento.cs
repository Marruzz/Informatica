using System;

namespace _12_01___giocoCombattimento
{
    internal class Program
    {
        static void Main()
        {
            Random r = new();
            int player1HP = 100;
            int player2HP = 100;
            bool turno = r.Next(0, 2) == 0; // Scelta casuale del primo giocatore
            bool difesa = false;

            Console.WriteLine("Inizia il combattimento!");

            while (player1HP > 0 && player2HP > 0)
            {
                if (turno)
                {
                    Console.WriteLine("Punti vita rimanenti: Giocatore 1 = " + player1HP + ", Giocatore 2 = " + player2HP);
                    Console.WriteLine("Turno del Giocatore 1 (Attacco o Difesa?)");
                    Console.WriteLine("1. Attaccare - si infligge un danno all'altro giocatore compreso tra 1 e 20");
                    Console.WriteLine("2. Difendere - si dimezza il prossimo danno subito");
                    int scelta = int.Parse(Console.ReadLine());
                    

                    if (scelta == 1)
                    {
                        int damage = r.Next(1, 21);
                        if (difesa)
                        {
                            damage /= 2;
                            difesa = false;
                            Console.WriteLine("Invece di infliggere " + damage*2 + " il giocatore 1 infligge " + damage + " al Giocatore 2");
                        }
                        player2HP -= damage;
                        
                    }
                    else if (scelta == 2)
                    {
                        Console.WriteLine("Il Giocatore 1 si difende.");
                        difesa = true;
                    }
                }
                else
                {
                    Console.WriteLine("Punti vita rimanenti: Giocatore 1 = " + player1HP + ", Giocatore 2 = " + player2HP);
                    Console.WriteLine("Turno del Giocatore 2 (Attacco o Difesa?)");
                    Console.WriteLine("1. Attaccare - si infligge un danno all'altro giocatore compreso tra 1 e 20");
                    Console.WriteLine("2. Difendersi - si dimezza il prossimo danno subito");
                    int scelta = int.Parse(Console.ReadLine());

                    if (scelta == 1)
                    {
                        int damage = r.Next(1, 21);
                        if (difesa)
                        {
                            damage /= 2;
                            difesa = false;
                            Console.WriteLine("Invece di infliggere " + damage * 2 + " il Giocatore 2 infligge " + damage + " al Giocatore 1");
                        }
                        player1HP -= damage;
                    }
                    else if (scelta == 2)
                    {
                        Console.WriteLine("Il Giocatore 2 si difende.");
                        difesa = true;
                    }
                }

                // Controllo della vittoria
                if (player1HP <= 0)
                {
                    Console.WriteLine("Il Giocatore 2 ha vinto il combattimento!");
                }
                else if (player2HP <= 0)
                {
                    Console.WriteLine("Il Giocatore 1 ha vinto il combattimento!");
                }
                else
                {
                    Console.WriteLine("Punti vita rimanenti: Giocatore 1 = " + player1HP +", Giocatore 2 = " + player2HP);
                }

                turno = !turno; // Cambio del turno
            }
        }
    }
}
