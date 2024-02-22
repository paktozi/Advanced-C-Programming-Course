function solve(a, b, c) {
    let str = a + b + c;
    let strResult = '';
    for (let i = str.length-1; i >= 0; i--) {
        strResult += str[i]+' ';
    }
    console.log(strResult);
}
solve('a', 'b', 'c');