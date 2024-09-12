
let rand = Math.random() * 40;
let randomNumber = Math.floor(rand);
console.log("randomNumber : " + randomNumber);

let numberOfAttempts = 0;
let availableAttempts = 7;
let numberOfCards = 40;

function renderCard(num) {
    const container = document.getElementById("card-container");
    for (let i = 1; i <= num; i++) {
        const card = document.createElement("div");

        card.className = "card mx-2 my-2 d-flex justify-content-center align-items-center";
        card.style.width = "8rem";
        card.style.height = "8rem";
        // card.innerText = i;

        card.setAttribute("data-card-number", i);

        container.appendChild(card);
    }
}

renderCard(numberOfCards);

const cards = document.querySelectorAll("#card-container .card");
cards.forEach((card) => {
    card.addEventListener("click", (e) => {

        let cardNumber = e.target.getAttribute("data-card-number");
        card.innerHTML = cardNumber;
        cardNumber = parseInt(cardNumber);
        console.log("cardNumber : " + cardNumber);


        if (cardNumber === randomNumber) {
            card.style.backgroundColor = "green";
            alert("Congratulations! You have won the game in " + numberOfAttempts + " attempts.");

        } else {
            numberOfAttempts++;
            availableAttempts--;
            if (cardNumber < randomNumber) {
                cards.forEach((previousCard) => {
                    let previousCardNumber = previousCard.getAttribute("data-card-number");
                    previousCardNumber = parseInt(previousCardNumber);
                    if (previousCardNumber <= cardNumber) {
                        previousCard.style.backgroundColor = "skyblue";
                    }
                });
            } else if (cardNumber > randomNumber) {
                cards.forEach((afterCards) => {
                    let afterCardsNumber = afterCards.getAttribute("data-card-number");
                    afterCardsNumber = parseInt(afterCardsNumber);
                    if (afterCardsNumber >= cardNumber) {
                        afterCards.style.backgroundColor = "red";
                    }
                })
            }
        }
        if (availableAttempts === 0) {
            alert("You have lost the game. Please try again.");
        } else {
            alert("You have " + availableAttempts + " attempts left.");
        }
    });
});


function updateStatistics() {
    document.getElementById("statistics").innerHTML = `
    <p class= "mx-4">Random Number : {randomNumber}</p>
    <p class= "mx-4">Number of Attempts : ${numberOfAttempts}</p>
    <p class= "mx-4">Available Attempts : ${availableAttempts}</p>
    `;
}

setInterval(updateStatistics, onclick = document.getElementById("card-container .card"));