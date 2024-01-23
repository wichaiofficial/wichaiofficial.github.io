// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function togglesubmenu() {
    var menu = document.getElementById("submenu")
    if (menu.style.display == "block") {
        menu.style.display = "none";
    }
    else
    {
        menu.style.display = "block";
    }
}



function updateSearchResults() {
    //Instantiate the array
    var array = new Array();
    var imageArray = new Array();
    var imagelocation = "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/"

    //get the dropdown list that is populated with all the games, the drop down list values are the Game titles
    var dropDownList = document.getElementById('gameDropDownList');

    var imageList = document.getElementById('imageDropDownList');


    //get the player input from the textbox
    var customerInput = document.getElementById('searchInput').value.toLowerCase();

    //loop through the list and turn it into a javascript array
    for (let i = 0; i < dropDownList.options.length; i++) {
        if (dropDownList.options[i].value.toLowerCase().includes(customerInput)) {
            array.push(dropDownList.options[i].value);
            imageArray.push(imageList.options[i].value);
            console.log(array[i] + "added to array");
        }
    }

    //If the amount of options is larger than 5 then we dont want to show them all, so cut the array down to 5
    if (array.length > 5) {
        array = array.slice(0, 5);
    }

    //clear out the entries on the screen currently
    clearResults();

    //append to screen
    for (let r = 0; r < array.length; r++) {
        document.getElementById('searchResults').innerHTML +=
            "<div class='searchResultsBox searchDiv' onclick='addToSearchBar(\"" + array[r] + "\")'/>" +
            "<img class='smallimage' src='" + imageArray[r] + "' width = '50' height = '75' style='display: inline;' />" +
            "<p style='display: inline; padding-left: 15px;' id='p" + r + "'>" + array[r] + "</p>" +
            "<div>"
    }
}

function showResults() {
    console.log("showingResults");
}

function clearResults() {
    console.log("closingResults");
    document.getElementById('searchResults').innerHTML = "";
}

function clearResultsBuffer() {
    setTimeout(clearResults, 100);
}

function addToSearchBar(game) {
    console.log("clicked");
    console.log(game);
    document.getElementById("searchInput").value = game;
    document.getElementById("searchForm").submit();
}
