
export function handleSelectCategory(movies) {
    
    const trending = document.getElementById('trending')
    trending.addEventListener('click', () => {
        movies.getMovies('trending')
    })
    const nowPlaying = document.getElementById('now_playing')
    nowPlaying.addEventListener('click', () => {
        movies.getMovies('now_playing')
    })
    const popular = document.getElementById('popular')
    popular.addEventListener('click', () => {
        movies.getMovies('popular')
    })
    const topRated = document.getElementById('top_rated')
    topRated.addEventListener('click', () => {
        movies.getMovies('top_rated')
    })
    const upcoming = document.getElementById('upcoming')
    upcoming.addEventListener('click', () => {
        movies.getMovies('upcoming')
    })
}