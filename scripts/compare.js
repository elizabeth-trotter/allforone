// Variables by ID
let response = document.getElementById("response");
let submitBtn = document.getElementById("submitBtn");

// Page Specific ID
let numOne = document.getElementById("numOne");
let numTwo = document.getElementById("numTwo");

// API Fetch Function
async function CompareEndpoint(numOne, numTwo){
    const promise = await fetch(`https://allforoneproject.azurewebsites.net/Compare/CompareNums/${numOne}/${numTwo}`);
    const data = await promise.text();
    console.log(data);
    return data;
}

// Submit Button Event
submitBtn.addEventListener('click', async () => {
    if(numOne.value && numTwo.value){
        let fetchedData = await CompareEndpoint(numOne.value, numTwo.value);
        response.textContent = fetchedData;
    }
});

// User Input Event
numTwo.addEventListener('keydown', async (event) => {
    if(numOne.value && numTwo.value){
        if(event.key === "Enter"){
            let fetchedData = await CompareEndpoint(numOne.value, numTwo.value);
            response.textContent = fetchedData;
        }
    }
});

numOne.addEventListener('keydown', async (event) => {
    if(numOne.value && numTwo.value){
        if(event.key === "Enter"){
            let fetchedData = await CompareEndpoint(numOne.value, numTwo.value);
            response.textContent = fetchedData;
        }
    }
});