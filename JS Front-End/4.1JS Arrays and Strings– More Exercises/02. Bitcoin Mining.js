function solve(input) {

    const bitCoinPrice = 11949.16;
    const goldPrice = 67.51;
    let bitCoinCount = 0;
    let totalMoney = 0;
    let firstDate = 0;

    for (let i = 0; i < input.length; i++) {
        let day = i + 1;
        if (day % 3 === 0) {
            input[i] -= input[i] * 0.3;
        }
        totalMoney += goldPrice * input[i];
        while (totalMoney - bitCoinPrice >= 0) {
            totalMoney -= bitCoinPrice;
            bitCoinCount++;
            if (bitCoinCount === 1) {
                firstDate = day;
            }
        }
    }
    console.log(`Bought bitcoins: ${bitCoinCount}`);
    if (bitCoinCount !== 0) {
        console.log(`Day of the first purchased bitcoin: ${firstDate}`);
    }
    console.log(`Left money: ${totalMoney.toFixed(2)} lv.`);

}

solve([100, 200, 300]);
solve([50, 100]);
solve([3124.15, 504.212, 2511.124]);