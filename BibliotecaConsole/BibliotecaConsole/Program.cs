using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Gestione Biblioteca");

Console.WriteLine("Inserimento libri: ");
Console.Write("Inserisci il titolo: ");
string titolo = Console.ReadLine(); 
Console.Write("Inserisci l'autore: ");
string autore = Console.ReadLine(); 
Console.Write("Inserisci il numero di pagine: ");
int pagine =int.Parse(Console.ReadLine());
Console.Write("Inserisci il prezzo: ");
decimal prezzo = decimal.Parse(Console.ReadLine());
