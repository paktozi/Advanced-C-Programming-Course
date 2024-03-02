function solve(input) { 
    let sortedArr = [];
    let length = input.length;
    input.sort((a, b) => a - b);
   
    for (let i = 0; i <length; i++){
        if (i % 2 === 0) {      
            sortedArr[i] = input[0];  
            input.shift();
        }
        else {       
            sortedArr[i] = input[input.length - 1];
            input.pop();
        }     
    }
    return sortedArr;
}
solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);   
