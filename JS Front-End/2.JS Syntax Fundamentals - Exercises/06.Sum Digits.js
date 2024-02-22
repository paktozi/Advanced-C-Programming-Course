function slove(num) {
    let result = 0;
    let numToStr = num.toString();
    for (let i = 0; i < numToStr.length; i++){
        result +=parseInt(numToStr[i]);
    }
    console.log(result);
}
slove(12345);