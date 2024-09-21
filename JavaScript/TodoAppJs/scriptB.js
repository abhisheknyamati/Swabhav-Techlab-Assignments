const button = document.getElementById("myBtn");
const ul = document.querySelectorAll("ul")[0];
const completedUl = document.querySelectorAll("ul")[1];
const textBox = document.getElementById("myText");

let myArray = ["groceries", "bills", "football","assignments"];
let completedArray = [];

function createListItem(item, isCompleted = false) {
    const li = document.createElement("li");
    const iconTrash = document.createElement("i");
    const iconCheck = document.createElement("i");

    iconTrash.className = "bi bi-trash btn btn-danger ms-2";
    iconTrash.style.cursor = "pointer";

    if (!isCompleted) {
        iconCheck.className = "bi bi-check2 btn btn-success ms-2";
        iconCheck.style.cursor = "pointer";
    }

    li.textContent = item;
    li.className = "list-group-item d-flex justify-content-between align-items-center";

    li.appendChild(iconCheck);
    li.appendChild(iconTrash);
    (isCompleted ? completedUl : ul).appendChild(li);
    
    return li;
}

myArray.forEach(item => createListItem(item));

button.addEventListener("click", () => {
    const myValue = textBox.value.trim();
    if (myValue !== "" && !myArray.includes(myValue)) {
        createListItem(myValue);
        myArray.push(myValue);
        textBox.value = "";
    } else {
        alert("Item already added to the list or empty!");
    }
});

ul.addEventListener("click", (e) => {
    if (e.target.classList.contains("bi-trash")) {
        const li = e.target.parentElement;
        const thisValue = li.textContent.replace("✗✓", "").trim(); 
        li.remove();
        myArray = myArray.filter(item => item !== thisValue);
    } else if (e.target.classList.contains("bi-check2")) {
        const li = e.target.parentElement;
        const thisValue = li.textContent.replace("✗✓", "").trim(); 
        li.remove();
        completedArray.push(thisValue);
        createListItem(thisValue, true);
        myArray = myArray.filter(item => item !== thisValue);
    }
});

completedUl.addEventListener("click", (e) => {
    if (e.target.classList.contains("bi-trash")) {
        const li = e.target.parentElement;
        const thisValue = li.textContent.replace("✗✓", "").trim(); 
        li.remove();
        completedArray = completedArray.filter(item => item !== thisValue);
    }
});
