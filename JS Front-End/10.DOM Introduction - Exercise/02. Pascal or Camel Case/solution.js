function solve() {

  const textElement = document.getElementById('text');
  const namingConvElement = document.getElementById('naming-convention');
  const resultTextElement = document.getElementById('result');

//   const convertToPascalCase = (text) => text
//   .split(' ')
//   .map(word => word.charAt(0).toUpperCase() + word.slise(1))
//   .join('');

// const convertor = {
//   'Pascal Case': convertToPascalCase,
//   'Camel Case ': (text) => convertToPascalCase(text).charAt(0).toLowerCase() + convertToPascalCase(text).split(1)

// };

// resultTextElement.textoCntent = convertor[namingConvElement.value](text);
 
 
 
  let finalWord = '';

  switch (namingConvElement.value) {
    case 'Camel Case': finalWord = camelCase(textElement.value); break;
    case 'Pascal Case': finalWord = pascalCase(textElement.value); break;
    default: finalWord = 'Error!'; break;
  }

  resultTextElement.textContent = finalWord;

  function camelCase(input) {
    let inputToLowerCase = input.toLowerCase();
    let arr = inputToLowerCase.split(' ');

    for (let i = 1; i < arr.length; i++) {
      let word = arr[i];
      let arrWord = word.split('');
      let firstLetter = arrWord[0];
      let upperLetter = firstLetter.toUpperCase();
      arrWord[0] = upperLetter;
      arr[i] = arrWord.join('');
    }
    return arr.join('');
  }
  camelCase(textElement.value);

  function pascalCase(input) {
    let inputToLowerCase = input.toLowerCase();
    let arr = inputToLowerCase.split(' ');

    for (let i = 0; i < arr.length; i++) {
      let word = arr[i];
      let arrWord = word.split('');
      let firstLetter = arrWord[0];
      let upperLetter = firstLetter.toUpperCase();
      arrWord[0] = upperLetter;
      arr[i] = arrWord.join('');
    }
    return arr.join('');
  }
  pascalCase(textElement.value);
}



