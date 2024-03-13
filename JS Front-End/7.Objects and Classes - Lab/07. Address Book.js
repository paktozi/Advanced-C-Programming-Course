function solve(input) {
    let adressBook = {};

    input.forEach(line => {
        let [name, address] = line.split(':');
        adressBook[name] = address;
   })
   
    // for (const line of input) {
    //     let [name, address] = line.split(':');
       
    //     person[name] = address;
    // }

  Object.entries(adressBook).sort((a, b) => a[0].localeCompare(b[0])).forEach(([name,adress])=>console.log(`${name} -> ${adress}`))
   


}




solve(['Tim:Doe Crossing',
    'Bill:Nelson Place',
    'Peter:Carlyle Ave',
    'Bill:Ornery Rd']);