Console.WriteLine("Gestione Biblioteca");

Console.WriteLine("Inserimento libri");
bool continua = true;
while (continua)
{
    Console.Write("Inserisci il titolo: ");
    string titolo = Console.ReadLine();
    Console.Write("Inserisci l'autore: ");
    string autore = Console.ReadLine();
    Console.Write("Inserisci il numero di pagine: ");
    int pagine = int.Parse(Console.ReadLine());
    Console.Write("Inserisci il prezzo: ");
    decimal prezzo = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Si vuole inserire un altro libro? y/n");
    string risposta = Console.ReadLine();
    if (risposta == "n") continua = false;
}
