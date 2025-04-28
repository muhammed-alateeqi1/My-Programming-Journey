export class Ui {
    displayDataGame(data) {
        let moviesBox = ``;
        for (let i = 0; i < data.length; i++) {
            let dataImg = data[i].poster_path ? 'https://image.tmdb.org/t/p/w500' + data[i].poster_path : './assets/images/default-movie.jpg';
            moviesBox += `
         <div data-id="${data[i].id}" class="movie-card">
         <div class="card-body p-2">
         <figure class="position-relative">
         <div class="movie-overlay p-5">
             <h1 class="movie-title text-center animate__animated">${data[i].title}</h1>
            <p class="movie-disc animate__animated animate__flipInX">
           ${data[i].overview}
            </p>
            <p class="movie-date animate__animated animate__fadeInUp">Release Date : ${data[i].release_date}</p>
            <div class="movie-rate animate__animated animate__fadeInUp">
            <i class="fa-solid fa-star"></i><i class="fa-solid fa-star"></i><i class="fa-solid fa-star"></i><i class="fa-solid fa-star"></i>
            <div class="rate-circle">
               <span class="small sm vote-number">
                  ${data[i].vote_average.toFixed(1)}
                  
               </span>
            </div>
            </div>
         </div>
          <img class="card-img" src="${dataImg}" />
          </figure>
            </div>
         </div>
         `;
        }
        document.getElementById("moveData").innerHTML = moviesBox;
        let openSideBar = false;
        document.querySelector("#nav-menu-btn").addEventListener('click', function (e) {
            openSideBar = !openSideBar
            if (openSideBar) {
                document.querySelector('.side-nav').style.marginLeft = "0px";
                document.querySelector('nav').style.marginLeft = "230px";
                document.querySelector('#nav-toggle').classList.replace('fa-bars', 'fa-x')
            } else {
                document.querySelector('#nav-toggle').classList.replace('fa-x', 'fa-bars')
                document.querySelector('.side-nav').style.marginLeft = "-230px";
                document.querySelector('nav').style.marginLeft = "0px";
            }
        })
    }
}
