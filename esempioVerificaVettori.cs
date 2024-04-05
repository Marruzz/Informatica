Console.WriteLine("Quanti valori deve avere il vettore?");
int grandezzaVettore = int.Parse(Console.ReadLine());
double[] vettorePrezzi = new double[grandezzaVettore];
double[] frequenzePrezzi = new double[grandezzaVettore];
double somma = 0;
int i = 0;
double[] secondoVettore = new double[grandezzaVettore];
double valoreScontato;
int y = 0;
double[] vettoreOrdineDecrescente = new double[grandezzaVettore];


//inserimento  di un nuovo prezzo
for (i = 0; i < vettorePrezzi.Length; i++)
{
    Console.WriteLine("Inserisci un prezzo");
    vettorePrezzi[i] = int.Parse(Console.ReadLine());
    //calcolo somma se vettorePrezzi[i] > 10
    if (vettorePrezzi[i] > 10)
    {
        somma += vettorePrezzi[i];
    }
}

//trova il prezzo dato l'indice
Console.WriteLine("Inserisci l'indice di cui vuoi trovare il prezzo");
int prezzoIndice = int.Parse(Console.ReadLine());
Console.WriteLine("Il prezzo dell'indice " + prezzoIndice + " è " + vettorePrezzi[prezzoIndice]);


//media prezzo>10
double media = (double)somma / i;
Console.WriteLine("La media è " + media);

//prezzo minimo e massimo
double prezzoMinimo = vettorePrezzi[0];
double prezzoMassimo = vettorePrezzi[0];
for (i = 0; i < vettorePrezzi.Length; i++)
{
    if (vettorePrezzi[i] > prezzoMassimo)
    {
        prezzoMassimo = vettorePrezzi[i];
    }
    if (vettorePrezzi[i] < prezzoMinimo)
    {
        prezzoMinimo = vettorePrezzi[i];
    }
}
Console.WriteLine("Il prezzo minimo è " + prezzoMinimo + " e il prezzo massimo è " + prezzoMassimo);


//ordinamento in ordine crescente
for (i = 0; i < vettorePrezzi.Length - 1; i++)
{
    for (y = i + 1; y < vettorePrezzi.Length; y++)
    {
        if (vettorePrezzi[i] > vettorePrezzi[y])
        {
            double temp = vettorePrezzi[i];
            vettorePrezzi[i] = vettorePrezzi[y];
            vettorePrezzi[y] = temp;
        }
    }
}

for (i = 0; i < vettorePrezzi.Length; i++)
{
    Console.WriteLine(vettorePrezzi[i]);
}

//prodotti con lo stesso prezzo
for (i = 1; i < vettorePrezzi.Length - 1; i++)
{
    if (vettorePrezzi[i] == vettorePrezzi[i - 1])
    {
        frequenzePrezzi[i]++;
    }
}
for (i = 0; i < vettorePrezzi.Length; i++)
{
    Console.WriteLine("");
}

//Creazione di un secondo vettore con sconto del 10% sui prezzi maggiori di 20
for (y = 0; i < secondoVettore.Length; i++)
{
    secondoVettore[y] = 0;
}
int dimensioneScontato = 0;

for (y = 0; y < vettorePrezzi.Length; y++)
{
    if (vettorePrezzi[y] > 20)
    {
        valoreScontato = (double)vettorePrezzi[y] / 100 * 10;
        secondoVettore[dimensioneScontato] = vettorePrezzi[dimensioneScontato] - valoreScontato;
        dimensioneScontato++;
        Console.WriteLine("Il prezzo del valore " + vettorePrezzi[dimensioneScontato] + " scontato del 20% è " + secondoVettore[dimensioneScontato]);
    }
}

//Creazione di un terzo vettore con prezzi ordinati in ordine decrescente
double[] PrezziDecrescente = new double[grandezzaVettore];
int IndiceDecrescente = 0;

for (i = vettorePrezzi.Length - 1; i < vettorePrezzi.Length && i >= 0; i--)
{
    PrezziDecrescente[IndiceDecrescente] = vettorePrezzi[i];
    Console.WriteLine(PrezziDecrescente[IndiceDecrescente]);
}

//Inserimento ordinato nel terzo vettore
