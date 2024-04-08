using System.Runtime.CompilerServices;


//bubble sort
int[] arrayBubble = new int[] { 4, 1, 6, 2, 9, 3, 7, 5, 8 };
Console.WriteLine("Array before bubble sorting:");
foreach (int i in arrayBubble)
{
    Console.Write(i + " ");
}

bubbleSort(arrayBubble);
Console.WriteLine("\nArray after bubble sorting:");
foreach (int i in arrayBubble)
{
    Console.Write(i + " ");
}



//Insertion Sort
int[] arrayInsertion = new int[] { 4, 1, 6, 2, 9, 3, 7, 5, 8 };
Console.WriteLine("\nArray before sorting:");
foreach (int i in arrayInsertion)
{
    Console.Write(i + " ");
}

insertionSort(arrayInsertion);
Console.WriteLine("\nArray after sorting:");
foreach (int i in arrayInsertion)
{
    Console.Write(i + " ");
}



//Selection Sort
int[] arraySelection = new int[] { 4, 1, 6, 2, 9, 3, 7, 5, 8 };
Console.WriteLine("\nArray before selection sorting:");
foreach (int i in arraySelection)
{
    Console.Write(i + " ");
}

selectionSort(arraySelection);
Console.WriteLine("\nArray after sorting:");
foreach (int i in arraySelection)
{
    Console.Write(i + " ");
}




//metodi
static void bubbleSort(int[] arrayBubble)
{
    //temporanea variabile
    int temp;
    for (int i = 0; i < arrayBubble.Length; i++)
    {
        for (int j = 0; j < arrayBubble.Length - 1; j++)
        {
            //se arrayBubble[j] è maggiore di arrayBubble[j + 1]
            if (arrayBubble[j] > arrayBubble[j + 1])
            {
                //temp ottiene il valore di arrayBubble[j + 1]
                temp = arrayBubble[j + 1];
                //arrayBubble[j + 1] ottiene il valore di arrayBubble[j]
                arrayBubble[j + 1] = arrayBubble[j];
                //arrayBubble[j] ottiene il valore di temp
                arrayBubble[j] = temp;
            }
        }
    }
}

static void insertionSort(int[] arrayInsertion)
{
    //key è la variabile temporanea
    int key, y;
    for (int i = 1; i < arrayInsertion.Length; i++)
    {
        //key ottiene il valore di arrayInsertion[i]
        key = arrayInsertion[i];
        //y ottiene il valore di i - 1
        y = i - 1;
        //finchè y è maggiore o uguale a 0 e arrayInsertion[y] è maggiore di key
        while (y >= 0 && arrayInsertion[y] > key)
        {
            //arrayInsertion[y + 1] ottiene il valore di arrayInsertion[y]
            arrayInsertion[y + 1] = arrayInsertion[y];
            //y ottiene il valore di y - 1
            y = y - 1;
        }
        //arrayInsertion[y + 1] ottiene il valore di key
        arrayInsertion[y + 1] = key;
    }
}

static void selectionSort(int[] arraySelection)
{
    //minIndex è la variabile temporanea
    int minIndex, temp1;
    for (int i = 0; i < arraySelection.Length - 1; i++)
    {
        //minIndex ottiene il valore di i
        minIndex = i;
        for (int j = i + 1; j < arraySelection.Length; j++)
        {
            //se arraySelection[j] è minore di arraySelection[minIndex]
            if (arraySelection[j] < arraySelection[minIndex])
            {
                //minIndex ottiene il valore di j
                minIndex = j;
            }
        }
        //temp1 ottiene il valore di arraySelection[i]
        temp1 = arraySelection[i];
        //arraySelection[i] ottiene il valore di arraySelection[minIndex]
        arraySelection[i] = arraySelection[minIndex];
        //arraySelection[minIndex] ottiene il valore di temp1
        arraySelection[minIndex] = temp1;
    }
}