def bubble_sort(array):
    for i in range(len(array) - 1):
        for j in range(len(array) - i - 1):
            if array[j] > array[j + 1]:
                array[j], array[j + 1] = array[j + 1], array[j]

def insertion_sort(array):
    for i in range(1, len(array)):
        temp = array[i]
        j = i - 1
        while j >= 0 and array[j] > temp:
            array[j + 1] = array[j]
            j -= 1
        array[j + 1] = temp

def selection_sort(array):
    for i in range(len(array) - 1):
        min_idx = i
        for j in range(i + 1, len(array)):
            if array[min_idx] > array[j]:
                min_idx = j
        array[i], array[min_idx] = array[min_idx], array[i]

n = int(input("Si inserisca la quantità di valori da ordinare: "))
array = []
for i in range(n):
    array.append(int(input(f"Inserire il valore {i + 1}: ")))

print("Si inserisca su quale algoritmo si vuole ordinare: ")
print("1. Bubble Sort \n2. Insertion Sort \n3. Selection Sort")
scelta = int(input())

if scelta == 1:
    bubble_sort(array)
elif scelta == 2:
    insertion_sort(array)
elif scelta == 3:
    selection_sort(array)
else:
    print("Scelta non valida")

print("\nArray after sorting:")
for i in array:
    print(i, end=" ")