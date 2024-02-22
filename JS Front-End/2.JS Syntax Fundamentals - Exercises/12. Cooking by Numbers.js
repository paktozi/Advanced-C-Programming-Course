function solve(num, a, b, c, d, e) {
    let list = [];
    list.push(a);
    list.push(b);
    list.push(c);
    list.push(d);
    list.push(e);

    for (let i = 0; i < list.length; i++) {

        switch (list[i]) {
            case 'chop': num /= 2; break;
            case 'dice': num = Math.sqrt(num); break;
            case 'spice': num += 1; break;
            case 'bake': num *= 3; break;
            case 'fillet': num -= (num * 0.20); break;   
        }
        console.log(num);
    }
}
solve(32, 'chop', 'chop', 'chop', 'chop', 'chop');
solve(9, 'dice', 'spice', 'chop', 'bake', 'fillet');