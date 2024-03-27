function focused() {
    const inputelements = document.querySelectorAll('input[type=text]');
   Array.from(inputelements).forEach(inputElement => inputElement.addEventListener('focus', (event) => {
        event.target.parentElement.classList.add('focused');
    }));
   Array.from(inputelements).forEach(inputElement => inputElement.addEventListener('blur', (event) => {
        event.target.parentElement.classList.remove('focused');
    }));
}