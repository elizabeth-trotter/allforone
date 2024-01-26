// Variables by ID
let response = document.getElementById("response");
let submitBtn = document.getElementById("submitBtn");

// Page Specific ID
let name = document.getElementById("name");
let time = document.getElementById("time");

// API Fetch Function
async function QuestionEndpoint(name, time){
    const promise = await fetch(`https://allforoneproject.azurewebsites.net/Question/GetAnswers/${name}/${time}`);
    const data = await promise.text();
    console.log(data);
    return data;
}

// Submit Button Event
submitBtn.addEventListener('click', async () => {
    if(name.value && time.value){
        let fetchedData = await QuestionEndpoint(name.value, time.value);
        response.textContent = fetchedData;
    }
});

// User Input Event
name.addEventListener('keydown', async (event) => {
    if(name.value && time.value){
        if(event.key === "Enter"){
            let fetchedData = await QuestionEndpoint(name.value, time.value);
            response.textContent = fetchedData;
        }
    }
});

time.addEventListener('keydown', async (event) => {
    if(name.value && time.value){
        if(event.key === "Enter"){
            let fetchedData = await QuestionEndpoint(name.value, time.value);
            response.textContent = fetchedData;
        }
    }
});
