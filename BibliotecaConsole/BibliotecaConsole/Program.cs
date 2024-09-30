using BibliotecaConsole;

Console.WriteLine("Gestione Biblioteca");


Console.WriteLine("Inserimento libri");
bool continua = true;
while (continua)
{
    //sintassi di creazione di un oggetto da una classe
    Libro oggettoLibro = new Libro();
    Console.Write("Inserisci il titolo: ");
    oggettoLibro.Titolo = Console.ReadLine();
    Console.Write("Inserisci l'autore: ");

    oggettoLibro.Autore = Console.ReadLine();
    Console.Write("Inserisci il numero di pagine: ");

    oggettoLibro.Pagine = int.Parse(Console.ReadLine());
    Console.Write("Inserisci il prezzo: ");

    oggettoLibro.Prezzo = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Si vuole inserire un altro libro? y/n");

    string risposta = Console.ReadLine();
    if (risposta == "n") continua = false;
}
