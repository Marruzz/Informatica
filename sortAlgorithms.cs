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
    int temp;
    for (int i = 0; i < arrayBubble.Length; i++)
    {
        for (int j = 0; j < arrayBubble.Length - 1; j++)
        {
            if (arrayBubble[j] > arrayBubble[j + 1])
            {
                temp = arrayBubble[j + 1];
                arrayBubble[j + 1] = arrayBubble[j];
                arrayBubble[j] = temp;
            }
        }
    }
}

static void insertionSort(int[] arrayInsertion)
{
    int key, y;
    for (int i = 1; i < arrayInsertion.Length; i++)
    {
        key = arrayInsertion[i];
        y = i - 1;
        while (y >= 0 && arrayInsertion[y] > key)
        {
            arrayInsertion[y + 1] = arrayInsertion[y];
            y = y - 1;
        }
        arrayInsertion[y + 1] = key;
    }
}

static void selectionSort(int[] arraySelection)
{
    int minIndex, temp1;
    for (int i = 0; i < arraySelection.Length - 1; i++)
    {
        minIndex = i;
        for (int j = i + 1; j < arraySelection.Length; j++)
        {
            if (arraySelection[j] < arraySelection[minIndex])
            {
                minIndex = j;
            }
        }
        temp1 = arraySelection[i];
        arraySelection[i] = arraySelection[minIndex];
        arraySelection[minIndex] = temp1;
    }
}