const table = document.getElementById("table-body");

function renderTable(data) {
    table.innerHTML = "";
    data.forEach((item, index) => {
        const row = table.insertRow(index);
        Object.entries(item).forEach(([key, value], index) => {
            const cell = row.insertCell(index);
            if (key === "date") { 
                const date = new Date(value);
                const options = { year: 'numeric', month: 'long', day: 'numeric', hour: 'numeric', minute: 'numeric', hour12: true };
                cell.textContent = date.toLocaleString('en-US', options);
            } else {
                cell.textContent = value;
            }
        });
    });
}

let data = [];
fetch("http://localhost:5230/api/Timesheet")
    .then(response => response.json())
    .then(response => {
        data = response;
        renderTable(data);
    })
    .catch(error => console.error("Error -> ",error));