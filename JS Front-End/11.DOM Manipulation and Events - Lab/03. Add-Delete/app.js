function addItem() {
    const inputItemElement = document.getElementById('newItemText');
    const itemsListElement = document.getElementById('items');

    const newInputElement = document.createElement('li'); 
    newInputElement.textContent = inputItemElement.value;
    
    const deleteLinkElement = document.createElement('a');
    deleteLinkElement.textContent = '[Delete]';
    deleteLinkElement.href = '#';
      
    deleteLinkElement.addEventListener('click', () => { 
        newInputElement.remove();
        
    });   
    newInputElement.appendChild(deleteLinkElement);   
    itemsListElement.appendChild(newInputElement);
    inputItemElement.value = '';
}