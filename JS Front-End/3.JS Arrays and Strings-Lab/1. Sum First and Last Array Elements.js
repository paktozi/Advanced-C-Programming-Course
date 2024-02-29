function solve(num) {
    let first = num.shift();
    let last = num.pop();
    // let sum = num[0] + num[num.length - 1];
    // console.log(sum);
    console.log(first+last);
}
solve([20,30,40]);