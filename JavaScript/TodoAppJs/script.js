// let button = document.getElementById("myBtn");
// let textBox = document.getElementById("myText");
// let myPara = document.getElementById("myPara");

// button.addEventListener("click", displayPara);

// function displayPara() {
//     myPara.innerText = textBox.value;
// }

// textBox.addEventListener("input", () => {
//     myPara.innerText = textBox.value;
// });

// ---------------------- TODO ------------------------

let button = document.getElementById("myBtn");
const ul = document.querySelector("ul");

let myArray = [];

button.addEventListener("click", () => {
    let textBox = document.getElementById("myText");
    let myValue = textBox.value;
    let li = document.createElement("li");
    
    if (!myArray.includes(myValue) && myValue !== "") {
        myArray.push(myValue);
        li.innerText = myValue;
        ul.appendChild(li);
    }

    textBox.value = "";

    console.log(myArray);
});

ul.addEventListener("click", (e) => {
    if(e.target.nodeName == "LI"){
        let thisValue = e.target.innerText;
        e.target.remove();
        myArray = myArray.filter((item) => {item !== thisValue});
        console.log(myArray);
    }
})

