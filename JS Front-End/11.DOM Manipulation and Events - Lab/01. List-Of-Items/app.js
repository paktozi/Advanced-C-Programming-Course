function addItem() {  
    const ulElement = document.getElementById('items');
    const textInputElement = document.getElementById('newItemText');    
    const newLi = document.createElement('li');  
    newLi.textContent = textInputElement.value;
    ulElement.appendChild(newLi);
    textInputElement.value = '';
}