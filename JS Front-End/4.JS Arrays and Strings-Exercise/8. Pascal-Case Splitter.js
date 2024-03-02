function solve(input) {
 
    const words = input.match(/[A-Z][a-z]*/g);
    
    const result = words.join(', ');

    console.log(result);
}

solve('SplitMeIfYouCanHaHaYouCantOrYouCan'); //Split, Me, If, You, Can, Ha, Ha, You, Cant, Or, You, Can
solve('HoldTheDoor');  //Hold, The, Door
solve('ThisIsSoAnnoyingToDo');// This, Is, So, Annoying, To, Do