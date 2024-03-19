function sumTable() {

    let tdCostElements = document.querySelectorAll('tr td:last-child:not(#sum)');
    const tdSum = document.getElementById('sum');

    const sum = Array
        .from(tdCostElements)
        .reduce((sum, element) => sum + Number(element.textContent), 0);
   
    tdSum.textContent = sum; 
    // let total = 0;  
    // for (let el of tdCostElements) {
    //     total += Number(el.textContent);
    // }
    //tdSum.textContent = total;
}