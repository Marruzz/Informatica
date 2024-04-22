using System.Runtime.CompilerServices;

/*
 * Commento semplice
 ! Commento importante
 ? Domanda
 TODO: Da fare
 //? Domanda importante Fatta
 // Già fatto
 @param nomeParametro descrizione
 */

Console.WriteLine("Si inserisca la quantità di valori da ordinare: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Inserire il valore " + (i + 1) + ": ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Si inserisca su quale algoritmo si vuole ordinare: ");
Console.WriteLine("1. Bubble Sort \n 2. Insertion Sort \n 3. Selection Sort");
int scelta = int.Parse(Console.ReadLine());
switch (scelta)
{
    case 1:
        bubbleSort(array);
        break;
    case 2:
        insertionSort(array);
        break;
    case 3:
        selectionSort(array);
        break;
    default:
        Console.WriteLine("Scelta non valida");
        break;
}
bubbleSort(arrayBubble);
Console.WriteLine("\nArray after bubble sorting:");
foreach (int i in arrayBubble)
{
    Console.Write(i + " ");
}




//metodi
static void bubbleSort(int[] array)
{
    int temp; //TODO: temp è la variabile temporanea
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                temp = array[j]; //!temp ottiene il valore di array[j]
                array[j] = array[j + 1]; //?array[j] ottiene il valore di array[j + 1]
                array[j + 1] = temp; //*array[j + 1] ottiene il valore di temp
            }
        }
    }
}


static void insertionSort(int[] array)
{
    for (int i = 1; i < array.length; i++)
    {
        int temp = array[i]; //TODO: temp è la variabile temporanea
        int j = i - 1;  //TODO: j è un contatore

        while (j >= 0 && array[j] > temp)
        {
            array[j + 1] = array[j]; //?array[j + 1] ottiene il valore di array[j]
            j--; //!j viene decrementato
        }
        array[j + 1] = temp; //*array[j + 1] ottiene il valore di temp
    }
}


/*
Inizia dal primo elemento dell'array e lo considera come il minimo valore.
Poi, attraversa il resto dell'array alla ricerca di un elemento più piccolo del minimo corrente.
Se trova un elemento più piccolo, aggiorna il minimo.
Dopo aver attraversato tutto l'array, scambia il minimo trovato con il primo elemento dell'array.
Ora, il primo elemento dell'array è il più piccolo e può essere considerato ordinato.
L'algoritmo si sposta al secondo elemento e ripete i passaggi da 1 a 4, ma ora considera solo il
sotto-array non ordinato (cioè, esclude gli elementi già ordinati).
Continua a ripetere il processo fino a quando tutti gli elementi dell'array non sono ordinati.
*/
static void selectionSort(int[] array)
{
    for (int i = 0; i < array.length - 1; i++)
    {
        int min = i; //TODO: min è il minimo
        for (int j = i + 1; j < array.length; j++)
        {
            if (array[min] > array[j])
            {
                min = j; //!min ottiene il valore di j
            }
        }

        int temp = array[i]; //TODO: temp è la variabile temporanea e assume  il valore di array[i]
        array[i] = array[min]; //?array[i] ottiene il valore di array[min]
        array[min] = temp; //*array[min] ottiene il valore di temp
    }

}
}