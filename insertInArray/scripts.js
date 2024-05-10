let itemsArray = [];

// Load items from localStorage on page load
window.onload = function() {
    const savedItems = localStorage.getItem('itemsArray');
    if (savedItems) {
        itemsArray = JSON.parse(savedItems);
    }
}

function addItem() {
    const inputItem = document.getElementById('inputItem');
    const itemValue = inputItem.value.trim();

    if (itemValue !== '') {
        itemsArray.push(itemValue);
        saveItems(); // Save items to localStorage
        updateDownloadLink(); // Update download link
        inputItem.value = '';
    }
}

function saveItems() {
    localStorage.setItem('itemsArray', JSON.stringify(itemsArray));
}

function updateDownloadLink() {
    const data = JSON.stringify(itemsArray, null, 2);
    const blob = new Blob([data], { type: 'application/json' });
    const url = URL.createObjectURL(blob);
    const downloadLink = document.getElementById('downloadLink');
    downloadLink.href = url;
    downloadLink.download = 'items.json'; // Set the download attribute
}

// Function to trigger download
function downloadItems() {
    const savedItems = localStorage.getItem('itemsArray');
    const blob = new Blob([savedItems], { type: 'application/json' });
    const url = URL.createObjectURL(blob);
    const a = document.createElement('a');
    a.href = url;
    a.download = 'items.json';
    a.click();
}
