using namespace std;
#include <iostream>

void bubbleSort(int array[], int n);
void insertionSort(int array[], int n);
void selectionSort(int array[], int n);

int main() {
    cout << "Si inserisca la quantità di valori da ordinare: ";
    int n;
    cin >> n;
    int array[n];
    for (int i = 0; i < n; i++) {
        cout << "Inserire il valore " << (i + 1) << ": ";
        cin >> array[i];
    }
    cout << "Si inserisca su quale algoritmo si vuole ordinare: " << endl;
    cout << "1. Bubble Sort" << endl;
    cout << "2. Insertion Sort" << endl;
    cout << "3. Selection Sort" << endl;
    int scelta;
    cin >> scelta;
    switch (scelta) {
        case 1:
            bubbleSort(array, n);
            break;
        case 2:
            insertionSort(array, n);
            break;
        case 3:
            selectionSort(array, n);
            break;
        default:
            cout << "Scelta non valida" << endl;
            break;
    }
    cout << "\nArray after sorting:" << endl;
    for (int i = 0; i < n; i++) {
        cout << array[i] << " ";
    }
    cout << endl;
    return 0;
}

void bubbleSort(int array[], int n) {
    int temp;
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n - 1; j++) {
            if (array[j] > array[j + 1]) {
                temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
        }
    }
}

void insertionSort(int array[], int n) {
    int key, y;
    for (int i = 1; i < n; i++) {
        key = array[i];
        y = i - 1;
        while (y >= 0 && array[y] > key) {
            array[y + 1] = array[y];
            y = y - 1;
        }
        array[y + 1] = key;
    }
}

void selectionSort(int array[], int n) {
    int minIndex, temp1;
    for (int i = 0; i < n - 1; i++) {
        minIndex = i;
        for (int j = i + 1; j < n; j++) {
            if (array[j] < array[minIndex]) {
                minIndex = j;
            }
        }
        temp1 = array[i];
        array[i] = array[minIndex];
        array[minIndex] = temp1;
    }
}