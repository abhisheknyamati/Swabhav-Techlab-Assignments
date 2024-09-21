document.addEventListener("DOMContentLoaded", function () {
    const addActivityBtn = document.getElementById("addActivity");
    const container = document.querySelector(".container");

    addActivityBtn.addEventListener("click", function () {
        const timesheet = document.getElementById("activity").cloneNode(true);

        // Optionally, clear the inputs in the cloned form
        const inputs = timesheet.querySelectorAll("input, select, textarea");
        inputs.forEach(input => {
            if (input.type !== "button") {
                input.value = "";
            }
        });

        container.appendChild(timesheet);
    });
});

const removeActivity = document.getElementById("removeActivity");
removeActivity.addEventListener("click", () =>{
    const container = document.querySelector(".container");
    const lastActivity = container.lastElementChild;
    if (container.childElementCount > 2) {
        container.removeChild(lastActivity);
    }
});

const submit = document.getElementById("submit");

submit.addEventListener("click", (event) => {
    console.log("submit clicked");
    event.preventDefault();
    const form = document.getElementById("timesheetForm");
    const formData = new FormData(form);

    const data = {};
    formData.forEach((value, key) => {
        data[key] = value;
    });

    fetch("http://localhost:5230/api/Timesheet", {
        method: "POST",
        body: JSON.stringify(data),
        headers: {
            "Content-Type": "application/json"
        }
    })
        .then(response => response.json())
        .then(data => console.log("Success -> ",data))
        .catch(error => console.error("Error -> ",error));
});

