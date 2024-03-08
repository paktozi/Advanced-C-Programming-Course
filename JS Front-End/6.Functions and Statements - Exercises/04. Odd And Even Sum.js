function sumEvenOddDigits(number) {

    let numberStr = number.toString();
    let evenSum = 0;
    let oddSum = 0;

    for (let i = 0; i < numberStr.length; i++) {

        let digitInt = parseInt(numberStr[i]);

        if (digitInt % 2 === 0) {
            evenSum += digitInt;
        } else {
            oddSum += digitInt;
        }
    }
    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);
}


sumEvenOddDigits(12554);

