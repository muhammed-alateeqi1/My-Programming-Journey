let searchInput = document.querySelector("#searchInput");

// currentDay Selcetors //

let currentDayText = document.querySelector(".up-bar .date");
let weekDay = document.querySelector(".up-bar .day");
let currentForecast = document.querySelector(".custom");
let currentPower = document.querySelector(".power span");
let windSpeed = document.querySelector(".speed span");
let windDir = document.querySelector(".dir span");

// Tommorrow Selectors
let tommorrowDiv = document.querySelector(".tommorrow-div .up-bar .day");
let tommorrowIcon = document.querySelector(".tommorrow-div .forecast-content img");
let tommorrowMaxTemp = document.querySelector(".tommorrow-div .degree .max");
let tommorrowMinTemp = document.querySelector(".tommorrow-div .degree .min");
let tommorrowWeatherCondition = document.querySelector(".tommorrow-div  .custom");

let afterTommorrowDiv = document.querySelector(".after-tommorrow-div .up-bar .day");
let afterTommorrowIcon = document.querySelector(".after-tommorrow-div .forecast-content img");
let afterTommorrowMaxTemp = document.querySelector(".after-tommorrow-div .degree .max");
let afterTommorrowMinTemp = document.querySelector(".after-tommorrow-div .degree .min");
let afterTommorrowWeatherCondition = document.querySelector(".after-tommorrow-div  .custom");

let days = [
  "Sunday",
  "Monday",
  "Tuesday",
  "Wednesday",
  "Thursday",
  "Friday",
  "Saturday",
];
const months = [
  "January",
  "February",
  "March",
  "April",
  "May",
  "June",
  "July",
  "August",
  "September",
  "October",
  "November",
  "December",
];
function getWeather(city) {
  var request = new XMLHttpRequest();
  request.open(
    "GET",
    `https://api.weatherapi.com/v1/forecast.json?key=1697ef953dbb4bd9a97141743242406&q=${city}&days=3`
  );
  request.send();
  request.addEventListener("load", function () {
    let dataResponse = JSON.parse(request.response);
    let currentDay = dataResponse.location.localtime;
    let currenDayAsWeek = new Date(currentDay).getDay();
    let currentMonth = new Date().getMonth();
    currentDayAsNumber = new Date().getDate();
    currentDayText.innerHTML = `${currentDayAsNumber} ${months[currentMonth]}`;
    weekDay.innerText = `${days[currenDayAsWeek]}`;
    let icon = dataResponse.current.condition.icon;
    document
      .querySelector("#day-one-icon")
      .setAttribute("src", `https:${icon}`);
    document.querySelector(
      ".location"
    ).innerText = `${dataResponse.location.name}`;
    document.querySelector(
      ".degree .num .temp-c"
    ).innerText = `${dataResponse.current.temp_c}`;
    windDir.innerText = `${dataResponse.current.wind_dir}`;
    currentForecast.innerText = dataResponse.current.condition.text;
    currentPower.innerText = `${dataResponse.current.cloud}%`;
    windSpeed.innerText = `${dataResponse.current.wind_kph} km\h `;
    function getTommorrow() {
        let tomIcon = dataResponse.forecast.forecastday[1].day.condition.icon;
        let wCondition = dataResponse.forecast.forecastday[1].day.condition.text;
        let maxTomTemp = dataResponse.forecast.forecastday[1].day.maxtemp_c;
        let minTomTemp = dataResponse.forecast.forecastday[1].day.mintemp_c;
        let tommorrowAsNumber = dataResponse.forecast.forecastday[1].date;
        getTommorrow = new Date(tommorrowAsNumber).getDay();
        tommorrowDiv.innerText = days[getTommorrow];
        tommorrowIcon.setAttribute("src", `https:${tomIcon}`);
        tommorrowMaxTemp.innerText = maxTomTemp;
        tommorrowMinTemp.innerText = minTomTemp;
        tommorrowWeatherCondition.innerText = wCondition;
      }
    function updateAfterTommorrow(){
        let tomIcon = dataResponse.forecast.forecastday[2].day.condition.icon;
        let wCondition = dataResponse.forecast.forecastday[2].day.condition.text;
        let maxTomTemp = dataResponse.forecast.forecastday[2].day.maxtemp_c;
        let minTomTemp = dataResponse.forecast.forecastday[2].day.mintemp_c;
        let tommorrowAsNumber = dataResponse.forecast.forecastday[2].date;
        getTommorrow = new Date(tommorrowAsNumber).getDay();
        afterTommorrowDiv.innerText = days[getTommorrow];
        afterTommorrowIcon.setAttribute("src", `https:${tomIcon}`);
        afterTommorrowMaxTemp.innerText = maxTomTemp;
        afterTommorrowMinTemp.innerText = minTomTemp;
        afterTommorrowWeatherCondition.innerText = wCondition;
    }
    getTommorrow();
    updateAfterTommorrow()

  });
}
searchInput.addEventListener("input", function () {
  getWeather(searchInput.value);
});
getWeather("cairo");



