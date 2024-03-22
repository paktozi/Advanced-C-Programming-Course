function subtract() {  
    const firstNumElement = document.getElementById('firstNumber');
    const secondNumElement = document.getElementById('secondNumber');
    const resultElement = document.getElementById('result');
  
    const result = Number(firstNumElement.value) - Number(secondNumElement.value)
    resultElement.textContent = result;
}