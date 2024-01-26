// Variables by ID
let response = document.getElementById("response");
let submitBtnArr = [
    document.getElementById("submitBtnL0"), document.getElementById("submitBtnL1"), document.getElementById("submitBtnL2"), document.getElementById("submitBtnL3"), document.getElementById("submitBtnL4"),
    document.getElementById("submitBtnL5"), document.getElementById("submitBtnL6"), document.getElementById("submitBtnL7"), document.getElementById("submitBtnL8"), document.getElementById("submitBtnL9"),
];

let userName = document.getElementById("userName");

// JavaScript Global Variable
let fetchedData;

// Event Listeners
submitBtnArr.forEach(function(button, index){
    button.addEventListener('click', () => {
        switch (index){
            case 0:
                SayHelloEndpoint(userName.value);
                break;
            default:
                break;
        }
    });
});

// API Fetch Functions
const SayHelloEndpoint = async (name) => {
    const data = await fetch(`http://localhost:5105/Hello/Hello/${name}`);
    const promise = await data.json();
    fetchedData = promise;
    console.log(fetchedData);
}