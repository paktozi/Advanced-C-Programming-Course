function slove(numA,numB) {
    let numbers = '';
    let totSum = 0;
    for (let i = numA; i <= numB; i++){
        totSum += i;    
        numbers += i+' ';
    }
    console.log(numbers);
    console.log(`Sum: ${totSum}`);
}
slove(5,10);