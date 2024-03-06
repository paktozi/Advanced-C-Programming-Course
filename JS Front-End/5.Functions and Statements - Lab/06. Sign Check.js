function solve(numOne, numTwo, numThree) {

    let isPositive = (numOne, numTwo, numThree) => (numOne * numTwo )* numThree > 0;

    if (isPositive) {
        console.log('Positive');
    }
    else {
        console.log('Negative');
    }
}

let a = -6;
let b = -12;
let c = 14;

console.log(a*b*c>0);


solve(5, 12, -15);
solve(-6, -12, 14);
solve(-1, -2, -3);