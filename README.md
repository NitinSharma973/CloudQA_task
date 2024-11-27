This project demonstrates how to automate form interactions using Selenium WebDriver in C#. The script automates the process of filling out a form on the webpage https://app.cloudqa.io/home/AutomationPracticeForm, testing various input elements like text fields, radio buttons, and date fields. Initially, the script sets up the WebDriver with Chrome, maximizes the browser window, and navigates to the form's URL. It then waits for elements to load using WebDriverWait before interacting with them. The test checks the functionality of the First Name, Last Name, Gender (radio button), and Date of Birth fields by locating each element by its ID, clearing any pre-filled data, and inputting new values. If the Male gender radio button is not selected, the script clicks it. After testing all the fields, the script prints success messages and gracefully handles any errors using a try-catch block. Finally, the browser is closed using driver.Quit() to terminate the WebDriver session. This code is useful for automating basic form interactions, and the WebDriver wait ensures that elements are present before any interaction, preventing errors. The project also showcases basic exception handling and browser automation, making it a good starting point for more complex web automation tasks. To run the script, you simply need to ensure you have the necessary NuGet packages installed and execute the code in your IDE or command line.