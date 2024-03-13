
function solve(jsonFile) {

    let jsonToObj = JSON.parse(jsonFile);

    Object.keys(jsonToObj)
        .forEach(key => console.log(`${key}: ${jsonToObj[key]}`));
}
solve('{"name": "George", "age": 40, "town": "Sofia"}');



