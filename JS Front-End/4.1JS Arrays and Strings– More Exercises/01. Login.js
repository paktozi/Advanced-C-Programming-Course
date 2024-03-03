function solve(input) {
    let userName = input[0];

    for (let i = 1; i <input.length; i++) {

        let passInput = input[i];
        let pass = passInput.split('').reverse().join('');

        if (i == 4&&userName!==pass) {
            console.log(`User ${userName} blocked!`);
            break;
       }
        if (userName === pass) {          
            console.log(`User ${userName} logged in.`);
        }
        else {
            console.log("Incorrect password. Try again.");
        }
    }
}
solve(['Acer', 'login', 'go', 'let me in', 'recA']);
solve(['sunny', 'rainy', 'cloudy', 'sunny', 'not sunny']);