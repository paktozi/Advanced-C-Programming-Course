function solve(input) {
    let garage = [];

    for (const car of input) {

        let [direction, number] = car.split(', ');

        if (direction === 'IN' && !garage.includes(number)) {
            garage.push(number);
        }
        else if (direction === 'OUT' && garage.includes(number)) {
            let index = garage.indexOf(number);
            garage.splice(index, 1);
        }
    }
    if (garage.length !== 0) {

        let sortedNums = garage.sort((a, b) => a.localeCompare(b));

        garage.forEach(x => console.log(x));
    }
    else {
        console.log('Parking Lot is Empty');
    }
}

solve(['IN, CA2844AA',
    'IN, CA1234TA',
    'OUT, CA2844AA',
    'IN, CA9999TT',
    'IN, CA2866HI',
    'OUT, CA1234TA',
    'IN, CA2844AA',
    'OUT, CA2866HI',
    'IN, CA9876HH',
    'IN, CA2822UU']);
// solve(['IN, CA2844AA',
// 'IN, CA1234TA',
// 'OUT, CA2844AA',
// 'OUT, CA1234TA']);