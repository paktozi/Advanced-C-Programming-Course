// function solve(text) {
//     let textToArray = text.split(' ');

//     for (let i = 0; i < textToArray.length; i++) {
//         if (textToArray[i].includes('#') && textToArray[i].length > 1) {
//             console.log(textToArray[i].replace('#',''));
//         }
//     }
// }
// solve('Nowadays everyone uses # to tag a #special word in #socialMedia');
// solve('The symbol # is known #variously in English-speaking #regions as the #number sign');
function solve(input) {
    const pattern = /#(?<special_word>[a-zA-Z]+)/g;
    const matches = input.matchAll(pattern);
    for (const match of matches) {
        console.log(match.groups.special_word);
    }
} 
 solve('Nowadays everyone uses # to tag a #special word in #socialMedia');
 solve('The symbol # is known #variously in English-speaking #regions as the #number sign');