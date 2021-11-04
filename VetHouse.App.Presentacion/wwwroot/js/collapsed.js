const collapsedHistory = document.querySelector(".collapsed");
const collapsedVS = document.querySelector(".collapsedSV");

collapsedHistory.addEventListener('click', (event) => {
    
    let content = document.querySelector(".contentHistory");

    if (content.style.display === "none") {
        content.style.display = "flex";
        content.style.justifyContent = "center";
        content.style.AlignItems = "center";
        content.style.flexWrap = "wrap";
        content.style.width = "100%";

        event.target.classList.add("active");
        document.querySelector(".arrowUp").src = "https://img.icons8.com/external-those-icons-fill-those-icons/20/000000/external-down-arrows-those-icons-fill-those-icons-7.png";

    } else {
        event.target.classList.remove("active");
        document.querySelector(".arrowUp").src = "https://img.icons8.com/external-those-icons-fill-those-icons/20/000000/external-up-arrows-those-icons-fill-those-icons-6.png";
        content.style.display = "none";
    }
});

collapsedVS.addEventListener("click", (event) => {

    let content = document.querySelector(".contentVitalSign");

    if (content.style.display === "none") {
        content.style.display = "flex";
        content.style.justifyContent = "space-between";
        content.style.AlignItems = "center";
        content.style.flexWrap = "wrap";
        content.style.width = "100%";

        event.target.classList.add("active");
        document.querySelector(".arrowUpSV").src = "https://img.icons8.com/external-those-icons-fill-those-icons/20/000000/external-down-arrows-those-icons-fill-those-icons-7.png";
        

    } else {
        event.target.classList.remove("active");
        document.querySelector(".arrowUpSV").src = "https://img.icons8.com/external-those-icons-fill-those-icons/20/000000/external-up-arrows-those-icons-fill-those-icons-6.png";
        content.style.display = "none";
    } 
});