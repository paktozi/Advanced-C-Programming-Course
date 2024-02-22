function solve(numberOfPeople, typeOfGroup, dayOfWeek) {
    let totalSum = 0;
    let price = 0;
    switch (typeOfGroup) {
        case 'Students':
            if (dayOfWeek == 'Friday') {
                price = 8.45;
            }
            else if (dayOfWeek == 'Saturday') {
                price = 9.80;
            }
            else if (dayOfWeek == 'Sunday') {
                price = 10.46;
            }
            totalSum = numberOfPeople * price;
            if (numberOfPeople >= 30) {
                 totalSum -= totalSum * 0.15;
            } break;
        case 'Business':
            if (dayOfWeek == 'Friday') {
                price = 10.90;
            }
            else if (dayOfWeek == 'Saturday') {
                price = 15.6;
            }
            else if (dayOfWeek == 'Sunday') {
                price = 16;
            }
            totalSum = numberOfPeople * price;
            if (numberOfPeople >= 100) {
                totalSum -= price * 10;
            } break;
        case 'Regular':
            if (dayOfWeek == 'Friday') {
                price = 15;
            }
            else if (dayOfWeek == 'Saturday') {
                price = 20;
            }
            else if (dayOfWeek == 'Sunday') {
                price = 22.5;
            }
            totalSum = numberOfPeople * price;
            if (numberOfPeople >= 10 && numberOfPeople <= 20) {
                totalSum -= totalSum * 0.05
            } break;
    }
    console.log(`Total price: ${totalSum.toFixed(2)}`);
}
solve(30, 'Students', 'Sunday');