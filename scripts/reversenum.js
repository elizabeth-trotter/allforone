// Variables by ID
let response = document.getElementById("response");
let submitBtn = document.getElementById("submitBtn");

// Page Specific ID
let input = document.getElementById("input");

// API Fetch Function
async function ReverseNumEndpoint(userNum){
    const promise = await fetch(`https://allforoneproject.azurewebsites.net/ReverseItNum/ReverseItNum/Enteranumberonly${userNum}`);
    const data = await promise.text();
    console.log(data);
    return data;
}

// Submit Button Event
submitBtn.addEventListener('click', async () => {
    if(input.value){
        let fetchedData = await ReverseNumEndpoint(input.value);
        response.textContent = fetchedData;
    }
});

// User Input Event
input.addEventListener('keydown', async (event) => {
    if(input.value){
        if(event.key === "Enter"){
            let fetchedData = await ReverseNumEndpoint(event.target.value);
            response.textContent = fetchedData;
        }
    }
});
