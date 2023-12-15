const user = JSON.parse(localStorage.getItem("user"));

console.log(user);

if (!user) {
    $("#booksLink").hide();
    $("#logout").hide();

    $("#signUpLink").show();
    $("#messages").hide();
} else {
    $("#booksLink").show();
    $("#logout").show();

    $("#signUpLink").hide();

    if (user.usertype !== 1) {
        $("#messages").hide();
    }
}

$("#logout").on("click", () => {
    if (confirm("Do you want to logout?")) {
        localStorage.clear();
    }
});