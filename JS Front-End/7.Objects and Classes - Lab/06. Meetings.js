
function solve(input) {
    const meetings = {};

    for (const line of input) {

        const [weekday, name] = line.split(' ');
        if (meetings[weekday]) {
            console.log(`Conflict on ${weekday}!`);
        } else {
            meetings[weekday] = name;
            console.log(`Scheduled for ${weekday}`);
        }
    }
    for (let day in meetings) {
        console.log(`${day} -> ${meetings[day]}`);
    }
}


solve(['Monday Peter',
    'Wednesday Bill',
    'Monday Tim',
    'Friday Tim']);