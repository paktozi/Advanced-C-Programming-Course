function solve(word, text) {
    let isFind = false;
    let textToArray = text.split(' ');
    for (let i = 0; i < textToArray.length; i++) {
        if (textToArray[i].toLowerCase() === word.toLowerCase()) {
            console.log(textToArray[i].toLowerCase());
            isFind = true;
        }
    }
    if (!isFind) {
        console.log(`${word} not found!`);
    }
}

solve('javascript',
    'JavaScript is the best programming language');
solve('python',
    'JavaScript is the best programming language');