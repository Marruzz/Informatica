using System.Runtime.CompilerServices;


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
    //temporanea variabile
    int temp;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            //se array[j] è maggiore di array[j + 1]
            if (array[j] > array[j + 1])
            {
                //temp ottiene il valore di array[j + 1]
                temp = array[j + 1];
                //array[j + 1] ottiene il valore di array[j]
                array[j + 1] = array[j];
                //array[j] ottiene il valore di temp
                array[j] = temp;
            }
        }
    }
}

static void insertionSort(int[] array)
{
    //key è la variabile temporanea
    int key, y;
    for (int i = 1; i < array.Length; i++)
    {
        //key ottiene il valore di array[i]
        key = array[i];
        //y ottiene il valore di i - 1
        y = i - 1;
        //finchè y è maggiore o uguale a 0 e array[y] è maggiore di key
        while (y >= 0 && array[y] > key)
        {
            //array[y + 1] ottiene il valore di array[y]
            array[y + 1] = array[y];
            //y ottiene il valore di y - 1
            y = y - 1;
        }
        //array[y + 1] ottiene il valore d[y + 1] = key;
    }
}

static void selectionSort(int[] array)
{
    //minIndex è la variabile temporanea
    int minIndex, temp1;
    for (int i = 0; i < array.Length - 1; i++)
    {
        //minIndex ottiene il valore di i
        minIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            //se array[j] è minore di array[minIndex]
            if (array[j] < array[minIndex])
            {
                //minIndex ottiene il valore di j
                minIndex = j;
            }
        }
        //temp1 ottiene il valore di array[i]
        temp1 = array[i];
        //array[i] ottiene il valore di array[minIndex]
        array[i] = array[minIndex];
        //array[minIndex] ottiene il valore di temp1
        array[minIndex] = temp1;
    }
}