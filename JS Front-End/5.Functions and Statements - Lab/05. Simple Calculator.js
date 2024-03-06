function solve(numA,numB,operator) {
   
    let result = GetResult(operator);
    let total = result(numA,numB);
    console.log(total);

    function GetResult(operator) {
        switch (operator) {
            case 'multiply':return (numA,numB)=>numA*numB;
            case 'divide': return (numA,numB)=>numA/numB;
            case 'add': return (numA,numB)=>numA+numB;
            case 'subtract': return(numA,numB)=>numA-numB;
        }
    }
}

solve(5, 5, 'multiply');
