import {Ui} from "./ui.module.js";
import { handleSelectCategory } from "./selectCategory.js";

export class Movies {
    constructor() {
        this.getMovies()
        const search = document.getElementById('search')
        search.addEventListener('input', (e) => {
            this.search(e.target.value)
        });
        handleSelectCategory(this)
        this.ui = new Ui();
    }

    async getMovies(trem) {
        // this should be simplified
        let url = `https://api.themoviedb.org/3/`
        if (trem === 'trending') {
            url += 'trending/movie/day'
        } else {
            url += `movie/${trem ?? 'now_playing'}`
        }
        url += `?api_key=eba8b9a7199efdcb0ca1f96879b83c44`

        const api = await fetch(url);
        const response = await api.json();
        console.log(response)
        this.ui.displayDataGame(response.results)
    }

    async search(query) {
        if (query === '') {
            this.getMovies()
            return
        }
        const url = `https://api.themoviedb.org/3/search/movie?query=${query}&include_adult=false&language=en-US&page=1&api_key=eba8b9a7199efdcb0ca1f96879b83c44`;
        const api = await fetch(url);
        const response = await api.json();
        this.ui.displayDataGame(response.results)
        console.log(response)
    }
}