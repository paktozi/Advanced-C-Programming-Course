function create(words) {
   const divElement = document.getElementById('content');
   for (let word of words) {
      const divTag = document.createElement('div');
      const paragraphElement = document.createElement('p');

      paragraphElement.textContent = word;
      paragraphElement.style.display = 'none';
      divTag.appendChild(paragraphElement);

      divTag.addEventListener('click', () => {
         paragraphElement.style.display = 'block';
      });
      divElement.appendChild(divTag);
   }
}