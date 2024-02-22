function slove(input) {
    let strNum = input.toString();
    let totSum = 0;
    let isSame = true;
    for (let i = 0; i < strNum.length-1; i++) {
        if (strNum[i] !== strNum[i + 1]) {
            isSame = false;
            break
        }       
    }
    for (let i = 0; i < strNum.length; i++) {
        totSum += parseInt(strNum[i]);
    }
    console.log(isSame);
    console.log(totSum);
}
slove(1234);
