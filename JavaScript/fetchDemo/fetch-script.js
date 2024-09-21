const form = document.getElementById("form");
form.addEventListener("submit", (event) => {
	event.preventDefault();
	addData();
});

function addData() {
	const rollNumber = document.getElementById("rollNumber").value.trim();
	const name = document.getElementById("name").value.trim();
	const email = document.getElementById("email").value.trim();
	const age = document.getElementById("age").value.trim();

	let formData = {
		rollNumber: rollNumber,
		name: name,
		email: email,
		age: age,
	};

	fetch("https://jsonplaceholder.typicode.com/users", {
		method: "POST",
		body: JSON.stringify(formData),
		headers: {
			"Content-Type": "application/json; charset=UTF-8",
		},
	})
		.then((response) => response.json())
		.then((data) => {
			console.log("fetch done:", data);
			const table = document.getElementById("userTableBody");

			const row = document.createElement("tr");
			row.innerHTML = `
            <td>${rollNumber}</td>
            <td>${name}</td>
            <td>${age}</td>
            <td>${email}</td>
            <td><button class="delete-button btn btn-warning">Delete</button></td>`;

			row.querySelector(".delete-button").addEventListener("click", () => {
				table.removeChild(row);
				// alert("User deleted successfully!");
			});

			table.appendChild(row);
			form.reset();
			// alert("Data submitted successfully!");
		})
		.catch((error) => {
			console.error("Error:", error);
		});
}

const usersArray = [
	{ rollNumber: "001", name: "Alice", email: "alice@example.com", age: "20" },
	{ rollNumber: "002", name: "Bob", email: "bob@example.com", age: "22" },
	{
		rollNumber: "003",
		name: "Charlie",
		email: "charlie@example.com",
		age: "21",
	},
];

fetch("https://jsonplaceholder.typicode.com/users")
	.then((response) => {
		return response.json();
	})
	.then((data) => {
		console.log("Fetched data:", data[1]);

		const table = document.getElementById("usersData");
		
		data.forEach((user) => {
			const row = document.createElement("tr");
			row.innerHTML = `
			<td>${user.id}</td>
			<td>${user.name}</td>
			<td>${user.email}</td>
			<td>${user.phone}</td>
			<td>${user.company.name}</td>`;
			table.appendChild(row);
		});
	})
	.catch((error) => {
        console.error("Error fetching users:", error);
        alert("An error occurred while fetching users.");
    });
