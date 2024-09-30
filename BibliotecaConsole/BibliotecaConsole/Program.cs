using BibliotecaConsole;

Console.WriteLine("Gestione Biblioteca");

List<Libro> biblioteca = new List<Libro>();
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

    Console.Write("Inserisci il prezzo: . Ricordarsi di mettere la virgola per i prezzi nno interi, se si mette il punto il programma non funziona");
    oggettoLibro.Prezzo = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Si vuole inserire un altro libro? y/n");
    string risposta = Console.ReadLine();

    biblioteca.Add(oggettoLibro);
    if (risposta == "n") continua = false;
}
Console.WriteLine("Vuoi vedere l'elenco dei libri? si/no");
string leggereLibri = Console.ReadLine();
if (leggereLibri == "si")
{
    Console.WriteLine("\n");
    foreach (var Libro in biblioteca)
    {
        Console.WriteLine("Titolo: " + Libro.Titolo);
        Console.WriteLine("Autore: " + Libro.Autore);
        Console.WriteLine("Numero di pagine: " + Libro.Pagine);
        Console.WriteLine("Prezzo: " + Libro.Prezzo);
        Console.WriteLine("\n");
    }
}
