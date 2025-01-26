Setup SpecFlow Project.
1. Open Visual Studio Editor
2. Select "Continue without code"
3. Install Specflow from Extention section
4. Restart the Visual Studio
5. File -> New -> Project
6. Search "Specflow" in search bar and select the Specflow template
7. Add project name and location
8. Select test framework
9. Then create the project

Add selenium to the project
1. Right click on Dependencies -> Select Nuget Packages
2. Search Selenium -> Selenium.WebDriver install

Install and view LivingDoc in to the project
1.Go to the project folder -> bin -> Debug -> net6.0
2.hit dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI in the terminal
3.After running the Test hit livingdoc test-assembly OrangeBDD.dll -t TestExecution.json in the termminal
