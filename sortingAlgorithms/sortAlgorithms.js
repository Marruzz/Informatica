function bubbleSort(array) {
  let len = array.length;
  for (let i = 0; i < len - 1; i++) {
    for (let j = 0; j < len - i - 1; j++) {
      if (array[j] > array[j + 1]) {
        let temp = array[j];
        array[j] = array[j + 1];
        array[j + 1] = temp;
      }
    }
  }
}

function insertionSort(array) {
  for (let i = 1; i < array.length; i++) {
    let temp = array[i];
    let j = i - 1;
    while (j >= 0 && array[j] > temp) {
      array[j + 1] = array[j];
      j--;
    }
    array[j + 1] = temp;
  }
}

function selectionSort(array) {
  for (let i = 0; i < array.length - 1; i++) {
    let minIdx = i;
    for (let j = i + 1; j < array.length; j++) {
      if (array[minIdx] > array[j]) {
        minIdx = j;
      }
    }
    let temp = array[i];
    array[i] = array[minIdx];
    array[minIdx] = temp;
  }
}

let n = prompt("Si inserisca la quantità di valori da ordinare: ");
let array = [];
for (let i = 0; i < n; i++) {
  array.push(parseInt(prompt(`Inserire il valore ${i + 1}: `)));
}

let scelta = prompt("Si inserisca su quale algoritmo si vuole ordinare: ");
switch (scelta) {
  case "1":
    bubbleSort(array);
    break;
  case "2":
    insertionSort(array);
    break;
  case "3":
    selectionSort(array);
    break;
  default:
    console.log("Scelta non valida");
    break;
}

console.log("Array after sorting:");
console.log(array.join(" "));
