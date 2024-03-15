function solve(input) {
    let movies = [];

    input.forEach(element => {
        if (element.includes('addMovie')) {
            let movie = element.split('addMovie')[1].trim();
            movies.push({ name: movie });
        } else if (element.includes('directedBy')) {
            let [movie, director] = element.split(' directedBy ');
            let searching = movies.find((x) => x.name === movie.trim());
            if (searching) {
                searching['director'] = director.trim();
            }
        } else if (element.includes('onDate')) {
            let [movie, date] = element.split(' onDate ');
            let searching = movies.find((x) => x.name === movie.trim());
            if (searching) {
                searching['date'] = date.trim();
            }
        }
    });
    movies.forEach((movie) => {
        if (movie.name && movie.date && movie.director) {
            console.log(JSON.stringify(movie));
        }
    });
}

solve([
    'addMovie Fast and Furious',
    'addMovie Godfather',
    'Inception directedBy Christopher Nolan',
    'Godfather directedBy Francis Ford Coppola',
    'Godfather onDate 29.07.2018',
    'Fast and Furious onDate 30.07.2018',
    'Batman onDate 01.08.2018',
    'Fast and Furious directedBy Rob Cohen'
]);