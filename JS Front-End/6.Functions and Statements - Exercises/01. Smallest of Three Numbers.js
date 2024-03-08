// function getSmallestNum(a,b,c) {

//     let smallestNum = (a, b, c) =>Math.min(a,b,c);
//    console.log(smallestNum(a,b,c));
// }


function getSmallestNum(a, b, c) {

    let nums = [a, b, c];
    let min = Infinity;
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] < min) {
            min = nums[i];
        }
    }
    console.log(min);
}

getSmallestNum(2, 47, 8);



