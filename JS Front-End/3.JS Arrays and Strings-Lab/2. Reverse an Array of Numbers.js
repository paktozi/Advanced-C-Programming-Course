function solve(n,input) {
   
    let res=input.slice(0,n)
        .reverse()
        .join(" ");
    console.log(res);
}
solve(3, [10, 20, 30, 40, 50]);