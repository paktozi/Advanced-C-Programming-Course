function solve(input) {
    //let evenSum = 0;
    //let oddsum = 0;
    // for (let i = 0; i < input.length; i++) {
    //     if (input[i]% 2 === 0) {
    //         evenSum += input[i];
    //     }
    //     else {
    //         oddsum += input[i];
    //     }
    // }
    let evenNum = input.filter(x => x % 2 === 0);
    let oddNum = input.filter(x=>x%2!==0);
    
     let evenSum = evenNum.reduce((a,b)=>a+b,0);
    let oddSum = oddNum.reduce((a,b)=>a+b,0);
   console.log(evenSum-oddSum);
}
solve([1, 2, 3, 4, 5, 6]);
solve([3,5,7,9]);