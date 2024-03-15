function solve(enploeeNames) {

    const empolees = {};
   
    for (const name of enploeeNames) {
        empolees[name] = name.length
    }

    for (const emploee in empolees) {
        console.log(`Name: ${emploee} -- Personal Number: ${empolees[emploee]}`);
    }
}

solve([
    'Silas Butler',
    'Adnaan Buckley',
    'Juan Peterson',
    'Brendan Villarreal'
]);