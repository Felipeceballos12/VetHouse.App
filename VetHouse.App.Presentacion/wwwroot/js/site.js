// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
// const weight = document.querySelector(".weight-input");
// weight.addEventListener('input', validationNumber);

// function validationNumber(e) {
//     let isNumber = Number(e.target.value);
//     if (!isNumber) {
//         this.classList.add("invalid");
//     }
// }

let currentFormRegister = 0;
const formCurrent = document.querySelectorAll(".form-register");
const btnActive = document.querySelectorAll(".btn");


showForm(currentFormRegister, formCurrent);

function showForm(n, formCurrent) {
    formCurrent[n].style.display = "block";

    if (n === 0) {
        document.querySelector(".btn-back").style.display = "none";
    } else {
        document.querySelector(".btn-back").style.display = "inline";
    }

    if (n == (formCurrent.length - 1)) {
        document.querySelector(".btn-next").innerHTML = "SUBMIT";
    } else {
        document.querySelector(".btn-next").innerHTML = "NEXT";
    }
}


btnActive.forEach(btn => {
    btn.addEventListener('click', () => {
        formCurrent[currentFormRegister].style.display = "none";
        
        if (btn.textContent.toUpperCase() === "NEXT") {
            currentFormRegister += 1;
        } else if (btn.textContent.toUpperCase() === "BACK") {
            currentFormRegister -= 1;
        } else {
            document.querySelector(".btn-next").type = "submit";
        }

        showForm(currentFormRegister, formCurrent);
    });
});
