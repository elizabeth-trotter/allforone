// Variables by ID
let response = document.getElementById("response");
let submitBtn = document.getElementById("submitBtn");

// Page Specific ID
let noun1 = document.getElementById("noun1");
let holiday1 = document.getElementById("holiday1");
let pronoun1 = document.getElementById("pronoun1");
let animal1 = document.getElementById("animal1");
let exclamation1 = document.getElementById("exclamation1");
let color1 = document.getElementById("color1");
let noun2 = document.getElementById("noun2");
let verb1 = document.getElementById("verb1");
let object1 = document.getElementById("object1");
let hours1 = document.getElementById("hours1");


// API Fetch Function
async function RestaurantEndpoint(noun1, holiday1, pronoun1, animal1, exclamation1, color1, noun2, verb1_ing, bluntObject1, hours1){
    const promise = await fetch(`https://allforoneproject.azurewebsites.net/MadLib/MadLib/${noun1}/${holiday1}/${pronoun1}/${animal1}/${exclamation1}/${color1}/${noun2}/${verb1_ing}/${bluntObject1}/${hours1}`);
    const data = await promise.text();
    console.log(data);
    return data;
}

// Submit Button Event
submitBtn.addEventListener('click', async () => {
    if(noun1.value, holiday1.value, pronoun1.value, animal1.value, exclamation1.value, color1.value, noun2.value, verb1.value, object1.value, hours1.value){
        let fetchedData = await RestaurantEndpoint(noun1.value, holiday1.value, pronoun1.value, animal1.value, exclamation1.value, color1.value, noun2.value, verb1.value, object1.value, hours1.value);
        response.textContent = fetchedData;
        // input.value = "";
    }
});

// User Input Event
// input.addEventListener('keydown', async (event) => {
//     if(input.value){
//         if(event.key === "Enter"){
//             let fetchedData = await RestaurantEndpoint(event.target.value);
//             response.textContent = fetchedData;
//             // input.value = "";
//         }
//     }
// });
