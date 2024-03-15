function solve(input) {

    let heroes = [];

    for (let line of input) {

        let [name, level, item] = line.split(' / ');
        let hero = {
            name,
            level:Number(level),
            item,
        };
        // hero.name = name;
        // hero.level = parseInt(level),
        // hero.item = item;
        heroes.push(hero);
    }

    heroes.sort((a, b) => a.level - b.level);
    
    for (let line of heroes) {
        console.log(`Hero: ${line.name}`);
        console.log(`level => ${line.level}`);
        console.log(`items => ${line.item}`);
    }
 
    // heroes.forEach(hero => console.log(`Hero: ${hero.name} level => ${hero.level} Items => ${hero.item}`));
}

solve([
    'Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara'
]);