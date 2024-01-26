// Variables by ID
let response = document.getElementById("response");
let submitBtn = document.getElementById("submitBtn");

// Page Specific ID
let userName = document.getElementById("numOne");

// API Fetch Function
async function OddOrEvenEndpoint(numOne){
    const promise = await fetch(`https://allforoneproject.azurewebsites.net/OddOrEven/OddOrEven/${numOne}`);
    const data = await promise.text();
    console.log(data);
    return data;
}

// Submit Button Event
submitBtn.addEventListener('click', async () => {
    if(numOne.value){
        let fetchedData = await OddOrEvenEndpoint(numOne.value);
        response.textContent = fetchedData;
    }
});

// User Input Event
numOne.addEventListener('keydown', async (event) => {
    if(numOne.value){
        if(event.key === "Enter"){
            let fetchedData = await OddOrEvenEndpoint(event.target.value);
            response.textContent = fetchedData;
        }
    }
});
