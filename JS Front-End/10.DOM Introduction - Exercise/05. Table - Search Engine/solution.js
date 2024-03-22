function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {

      const tableRowElement = document.querySelectorAll('table.container tbody tr');
      const searchedElement = document.getElementById('searchField');
      const searchedText = searchedElement.value;
      
      for (let trElement of tableRowElement) {
         const tdElements = trElement.querySelectorAll('td');
         let isSelected = false;
         trElement.classList.remove('select'); //trElement.className = '';    
        
         for (let tdElement of tdElements) {
            if (tdElement.textContent.includes(searchedText)) {
               isSelected = true;
               break;
            }
         }
         if (isSelected) {
            trElement.classList.add('select'); // trElement.className = 'select';
         }       
      }
      searchedElement.value = '';
   }
}