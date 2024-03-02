
function solve(input, num) {       
    for (let i = 0; i < num; i++) {   
        input.push(input.shift());
    }
    console.log(input.join(' '));
}
solve([51, 47, 32, 61, 21], 2);
solve([32, 21, 61, 1], 4);