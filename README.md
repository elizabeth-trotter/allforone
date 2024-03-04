# All For One

**Name:** Elizabeth Trotter

**Project Scope:** This is the `Web API` part of a comprehensive project that consolidates former mini API endpoints challenges into a 10-page web application.

> [!IMPORTANT]
> This project is on pause and has pending to do list items before use.

**My To Do's:**
- [x] Remove unused files *front end was move to seperate repo*
- [ ] API Use Documentation
  - [x] Add description, method, endpoint, parameters, returns
  - [x] Add footnote with required items
  - [ ] Shorten routes
  - [ ] Add entire link


<h2 align="center">API Calls & Endpoints</h2>

| Description | HTTP Method | Endpoint[^1] | Parameters | Returns |
| ------------- | :-------------: | ------------- | ------------- | :-------------: |
| Say Hello  | `GET`  | /Hello/Hello/{userName}  | `userName` | String |
| Adding Numbers | `GET`  | /Sum/GetSum/{numOne}/{numTwo}  | `numOne` `numTwo` | String  |
| Asking Questions | `GET`  | /Question/GetAnswers/{name}/{time}  | `name` `time` | String  |
| Greater Or Less Than | `GET`  | /Compare/CompareNums/{numOne}/{numTwo}  | `numOne` `numTwo` | String  |
| Mad Lib | `GET`  | /MadLib/MadLib/{noun1}/{holiday1}/{pronoun1}/{animal1}/{exclamation1} /{color1}/{noun2}/{verb1_ing}/{object1}/{hours1}  | `noun1` `holiday1` `pronoun1` `animal1` `exclamation1` `color1` `noun2` `verb1_ing` `object1` `hours1` | String  |
| Odd Or Even | `GET`  | /OddOrEven/OddOrEven/{numOne}  | `numOne` | String  |
| Reverse String | `GET`  | /ReverseItAlpha/ReverseIt/Entersequenceoflettersandornumbers{userInput}  | `userInput` | String  |
| Reverse Number | `GET`  | /ReverseItNum/ReverseItNum/Enteranumberonly{userNum}  | `userNum` | String  |
| Magic 8 Ball | `GET`  | /MagicBall/Generate8BallResponseToQuestion/  | none | String  |
| Restaurant Picker | `GET`  | /Restaurant/ChoosePizzaSushiOrBurgers/{category}  | `category` | String  |

[^1]: All fields within { } are required to make an API call
