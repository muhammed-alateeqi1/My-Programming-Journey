import {Movies} from "./movies.module.js";
import {handleSelectCategory} from "./selectCategory.js";

let movies = new Movies()

//if you want to move this to index.js you can do this
handleSelectCategory(movies)

