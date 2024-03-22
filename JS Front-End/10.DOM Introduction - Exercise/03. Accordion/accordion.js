function toggle() {
   
    const buttonElement = document.querySelector('.head span.button'); 
    const exrtraInfoElement = document.getElementById('extra');
    const buttonTextEl = buttonElement.textContent;
   
    exrtraInfoElement.style.display = 'block';
    buttonElement.textContent = 'Less';
    
    if (buttonTextEl === 'More') {
        exrtraInfoElement.style.display = 'block';
    buttonElement.textContent = 'Less';
    }
    else {
        exrtraInfoElement.style.display = 'none';
    buttonElement.textContent = 'More';
    }
}