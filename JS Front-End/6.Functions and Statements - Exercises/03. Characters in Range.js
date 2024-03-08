
function solve(firstCh,secondCh) {
    const sortedChar = getSortedChar(firstCh, secondCh);
    const start = sortedChar[0];
    const end = sortedChar[1];
    const result = getChar(start, end);
    console.log(result.join(' '));

    function getChar(start, end) {
        let char = [];
        for (let i = start.charCodeAt(0)+1; i < end.charCodeAt(0); i++) {
            char.push(String.fromCharCode(i));
        }
        return char;
    }
    
    function getSortedChar(a,b) {
        const charArray = [a, b];
        charArray.sort();
        return charArray;
    }
}

solve('C','#')