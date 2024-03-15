function solve(input) {

    let townArray = [];

    for (const row of input) {

        const [town, latitude, longitude] = row.split(' | ');
        const city = {
            town,
            latitude:parseFloat(latitude).toFixed(2),
            longitude:parseFloat(longitude).toFixed(2),
        };
        townArray.push(city);
    }

    townArray.forEach(town => console.log(town));
    
}

solve(['Sofia | 42.696552 | 23.32601',
    'Beijing | 39.913818 | 116.363625']);