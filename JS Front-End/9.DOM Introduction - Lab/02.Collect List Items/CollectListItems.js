function extractText() {
  
    let itemsElement = document.getElementById('items');
    let textarea = document.getElementById('result');
    textarea.value = itemsElement.textContent;    
}