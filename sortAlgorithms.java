import java.util.Scanner;

public class sortAlgorithms {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Si inserisca la quantità di valori da ordinare: ");
        int n = scanner.nextInt();
        int[] array = new int[n];
        for (int i = 0; i < n; i++) {
            System.out.println("Inserire il valore " + (i + 1) + ": ");
            array[i] = scanner.nextInt();
        }
        System.out.println("Si inserisca su quale algoritmo si vuole ordinare: ");
        System.out.println("1. Bubble Sort \n2. Insertion Sort \n3. Selection Sort");
        int scelta = scanner.nextInt();
        scanner.close();
        switch (scelta) {
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
                System.out.println("Scelta non valida");
                break;
        }
        System.out.println("\nArray dopo l'ordinamento:");
        for (int i : array) {
            System.out.print(i + " ");
        }
        System.out.println("\nArray after sorting:");
        for (int i : array) {
            System.out.print(i + " ");
        }
    }
    static void bubbleSort(int[] array) {
        int temp;
        for (int i = 0; i < array.length; i++) {
            for (int j = 0; j < array.length - 1; j++) {
                if (array[j] > array[j + 1]) {
                    temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
    static void insertionSort(int[] array) {
        int key, y;
        for (int i = 1; i < array.length; i++) {
            key = array[i];
            y = i - 1;
            while (y >= 0 && array[y] > key) {
                array[y + 1] = array[y];
                y = y - 1;
            }
            array[y + 1] = key;
        }
    }
    static void selectionSort(int[] array) {
        int minIndex, temp1;
        for (int i = 0; i < array.length - 1; i++) {
            minIndex = i;
            for (int j = i + 1; j < array.length; j++) {
                if (array[j] < array[minIndex]) {
                    minIndex = j;
                }
            }
            temp1 = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp1;
        }
    }
}