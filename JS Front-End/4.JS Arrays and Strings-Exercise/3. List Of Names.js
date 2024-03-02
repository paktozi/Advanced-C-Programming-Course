function solve(names) {
    names.sort((a,b)=>a.localeCompare(b))
        .forEach((thisName, index) => {
            console.log(`${index + 1}.${thisName}`)
        
        });
}
solve(["John", "Bob", "Christina", "Ema"]);