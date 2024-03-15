function solve(stockProducts, orderedProducts) {

    const store = {};
    const orders = {};

    for (let i = 0; i < stockProducts.length; i += 2) {
        store[stockProducts[i]] = Number(stockProducts[i + 1]);
    }

    for (let i = 0; i < orderedProducts.length; i += 2) {

        if (store[orderedProducts[i]]) {
            store[orderedProducts[i]] += Number(orderedProducts[i + 1]);
        } else {
            store[orderedProducts[i]] = Number(orderedProducts[i + 1]);
        }
    }

    for (let s in store) {
        console.log(`${s} -> ${store[s]}`);
    }
}

solve(['Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Beer', '2'],
    ['Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30']);