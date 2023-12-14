

const user = JSON.parse(localStorage.getItem("user"));

if (!user) {
    $("#booksLink").hide();
    $("#logout").hide();

    $("#signUpLink").show();
} else {
    $("#booksLink").show();
    $("#logout").show();

    $("#signUpLink").hide();
}

$("#logout").on("click", () => localStorage.clear());