function solve(firstName, lastName, hairColor) {
    
    let person = {
        name:firstName,
        lastName,
        hairColor,
    };
    const toJson = JSON.stringify(person);
    console.log(toJson);
}

solve('George', 'Jones', 'Brown');
