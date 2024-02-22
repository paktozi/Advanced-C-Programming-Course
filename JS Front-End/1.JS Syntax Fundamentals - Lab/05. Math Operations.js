function solve(numA, numB, sing) {

    switch (sing) {
        case '+': console.log(numA + numB); break;
        case '-': console.log(numA - numB); break;
        case '*': console.log(numA * numB); break;
        case '/': console.log(numA / numB); break;
        case '%': console.log(numA % numB); break;
        case '**': console.log(numA**numB); break;
    }
}

solve(3,5.5,'*');
