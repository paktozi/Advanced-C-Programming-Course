function solve(replacedWord,text) {
    
    let replaceWotdToArray = replacedWord.split(', ');
    let textToArray = text.split(' ');
    let indexWord = 0;

    for (let i = 0; i < textToArray.length; i++){
        
        if (textToArray[i].includes('*')) {
            textToArray[i] = replaceWotdToArray[indexWord];
            indexWord++;
        }
    } 
    console.log(textToArray.join(' '));
}
solve('great',
     'softuni is ***** place for learning new programming languages');

solve('great, learning',
'softuni is ***** place for ******** new programming languages');