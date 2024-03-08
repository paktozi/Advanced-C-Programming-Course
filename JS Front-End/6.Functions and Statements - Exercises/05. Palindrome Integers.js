function solve(num) {
    
    for (let i = 0; i < num.length; i++){
        
       
        let arr = num[i].toString().split('');
        if (arr[0] === arr[arr.length-1]) {
            console.log('true');
        } else {
            console.log('false')
        }
    }
}

solve([123, 323, 421, 121]);