function slove(numA, numB, sing) {

    switch (sing) {
        case '+': console.log(numA + numB); break;
        case '-': console.log(numA - numB); break;
        case '*': console.log(numA * numB); break;
        case '/': console.log(numA / numB); break;
        case '%': console.log(numA % numB); break;
        case '**': console.log(numA**numB); break;
    }
}

slove(3,5.5,'*');
