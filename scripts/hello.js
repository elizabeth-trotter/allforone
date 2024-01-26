// Variables by ID
let response = document.getElementById("response");
let submitBtn = document.getElementById("submitBtn");

// Page Specific ID
let userName = document.getElementById("userName");

// API Fetch Function
async function SayHelloEndpoint(userName){
    const promise = await fetch(`https://allforoneproject.azurewebsites.net/Hello/Hello/${userName}`);
    const data = await promise.text();
    console.log(data);
    return data;
}

// Submit Button Event
submitBtn.addEventListener('click', async () => {
    if(userName.value){
        let fetchedData = await SayHelloEndpoint(userName.value);
        response.textContent = fetchedData;
    }
});

// User Input Event
userName.addEventListener('keydown', async (event) => {
    if(userName.value){
        if(event.key === "Enter"){
            let fetchedData = await SayHelloEndpoint(event.target.value);
            response.textContent = fetchedData;
        }
    }   
});
