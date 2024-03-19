function calc() {
    
    let firstInputBox =document.getElementById('num1');
    let seconInputBox = document.getElementById('num2');    
    let sumBox = document.getElementById('sum');
    
    let result = Number(firstInputBox.value) + Number(seconInputBox.value);
    sumBox.value = result;
}
