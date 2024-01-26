// Variables by ID
let response = document.getElementById("response");
let submitBtn = document.getElementById("submitBtn");

// Page Specific ID
let input = document.getElementById("input");

// API Fetch Function
async function ReverseStrEndpoint(userInput){
    const promise = await fetch(`https://allforoneproject.azurewebsites.net/ReverseItAlpha/ReverseIt/Entersequenceoflettersandornumbers${userInput}`);
    const data = await promise.text();
    console.log(data);
    return data;
}

// Submit Button Event
submitBtn.addEventListener('click', async () => {
    if(input.value){
        let fetchedData = await ReverseStrEndpoint(input.value);
        response.textContent = fetchedData;
    }
});

// User Input Event
input.addEventListener('keydown', async (event) => {
    if(input.value){
        if(event.key === "Enter"){
            let fetchedData = await ReverseStrEndpoint(event.target.value);
            response.textContent = fetchedData;
        }
    }
});
