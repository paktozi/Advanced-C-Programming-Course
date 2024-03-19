function colorize() {   
    const evenRowElements = document.querySelectorAll('table tr:nth-child(2n)'); 
    for (let element of evenRowElements) {
        element.style.backgroundColor = 'teal';
    }  
    // evenRowElements.forEach(element => element.style.backgroundColor = 'teal'); 
}