var siteName = document.getElementById("siteName");
var siteURL = document.getElementById("siteURL");
var submitBtn = document.getElementById("submitBtn");
var tableContent = document.getElementById("tableContent");
var bookMarksContainer;

if (localStorage.getItem("Bookmarks") == null) {
  bookMarksContainer = [];
} else {
  bookMarksContainer = JSON.parse(localStorage.getItem("Bookmarks"));
  displayBookmark();
}

function addBookmark() {
  if (checkInputs()) {
    var bookMarks = {
      siteName: siteName.value,
      siteURL: siteURL.value,
    };
    bookMarksContainer.push(bookMarks);
    clearInputs();
    displayBookmark();
    localStorage.setItem("Bookmarks", JSON.stringify(bookMarksContainer));
  }
}

function checkInputs() {
  var isValid = true;

  // Clear previous error messages
  document.getElementById("errorMessage").innerHTML = "";
  document.getElementById("errorMessage-2").innerHTML = "";

  if (siteName.value.trim() === "") {
    showErrorMessageOne("Please fill all the fields.");
    siteName.classList.add("invalid");
    isValid = false;
  } else if (siteName.value.length < 3) {
    showErrorMessageOne("Site name must be at least 3 characters long.");
    siteName.classList.add("invalid");
    isValid = false;
  } else {
    siteName.classList.remove("invalid");
    siteName.classList.add("valid");
  }

  // Regex to validate URL starting with https://
  var urlPattern = /^https:\/\/.+$/;

  if (siteURL.value.trim() === "") {
    showErrorMessageTwo("Please fill all the fields.");
    siteURL.classList.add("invalid");
    isValid = false;
  } else if (!urlPattern.test(siteURL.value)) {
    showErrorMessageTwo("Please enter a valid URL starting with https://");
    siteURL.classList.add("invalid");
    isValid = false;
  } else {
    siteURL.classList.remove("invalid");
    siteURL.classList.add("valid");
  }

  return isValid;
}

function showErrorMessageOne(message) {
  document.getElementById("errorMessage").innerHTML = `
        <div class="alert alert-danger mt-2" role="alert">
            ${message}
        </div>
    `;
}

function showErrorMessageTwo(message) {
  document.getElementById("errorMessage-2").innerHTML = `
        <div class="alert alert-danger mt-2" role="alert">
            ${message}
        </div>
    `;
}

function clearInputs() {
  siteName.value = "";
  siteURL.value = "";
  siteName.classList.remove("valid", "invalid");
  siteURL.classList.remove("valid", "invalid");
  document.getElementById("errorMessage").innerHTML = "";
  document.getElementById("errorMessage-2").innerHTML = "";
}

function displayBookmark() {
  var tableContent = ``;
  for (var i = 0; i < bookMarksContainer.length; i++) {
    tableContent += `     
            <tr>
                <td>${i + 1}</td>
                <td>${bookMarksContainer[i].siteName}</td>
                <td>
                    <a class="btn btn-success px-3" href="${
                      bookMarksContainer[i].siteURL
                    }" target="_blank">
                        <i class="fa-solid fa-eye me-2"></i>Visit
                    </a>
                </td>
                <td>
                    <button class="btn btn-danger px-3" onclick="deleteBookmark(${i})">
                        <i class="fa-regular fa-trash-can me-2"></i>Delete
                    </button>
                </td>
            </tr>`;
  }
  document.getElementById("tableContent").innerHTML = tableContent;
}

function deleteBookmark(index) {
  bookMarksContainer.splice(index, 1);
  displayBookmark();
  localStorage.setItem("Bookmarks", JSON.stringify(bookMarksContainer));
}
