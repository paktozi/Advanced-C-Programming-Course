function search() {
   const townsListstElement = document.getElementById('towns');
   const searchedText = document.getElementById('searchText').value;
   const resultTextElement = document.getElementById('result');
   let matches = 0;

   const townElem = Array.from( townsListstElement.children);
   for (let townElement of townElem) {
      if (townElement.textContent.toLowerCase().includes(searchedText.toLowerCase())) {
         townElement.style.textDecoration = 'underline';
         townElement.style.fontWeight = 'bold';
         matches++;
      }
      else {
         townElement.style.textDecoration = 'none';
         townElement.style.fontWeight = 'normal';
      }
   }
   resultTextElement.textContent = `${matches} matches found`;
}
