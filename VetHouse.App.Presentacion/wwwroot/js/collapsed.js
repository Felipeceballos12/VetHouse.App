const collapsedHistory = document.querySelector(".collapsed");
const collapsedVS = document.querySelector(".collapsedSV");

collapsedHistory.addEventListener('click', (event) => {
    
    let content = event.target.nextElementSibling;

    if (content.style.display === "none") {
        content.style.display = "flex";
        content.style.justifyContent = "center";
        content.style.AlignItems = "center";
        content.style.flexWrap = "wrap";
        content.style.width = "100%";

        event.target.classList.add("active");

    } else {
        event.target.classList.remove("active");
        content.style.display = "none";
    }
});

collapsedVS.addEventListener("click", (event) => {

    let content = event.target.nextElementSibling;

    if (content.style.display === "none") {
        content.style.display = "flex";
        content.style.justifyContent = "center";
        content.style.AlignItems = "center";
        content.style.flexWrap = "wrap";
        content.style.width = "100%";

        event.target.classList.add("active");

    } else {
        event.target.classList.remove("active");
        content.style.display = "none";
    } 
});