#Topic: Selenium Webdriver Framework. 
A introduction in C#.
=====================================

By the end of the meeting you will have it installed and running against Chrome and Firefox 
(and Edge if your using windows/ or using a windows virtual machine).
We will show you how run a test that tests the UI of a page across browsers. 

## Prerequisite

Before the meeting install Visual Studio Community edition. 
If you have any problems we will help you get that installed. If you do not have a laptop we can pair you with another person. 

(skip this if you have windows)
Virtual machine link for Windows 10 (if you want to install it on a virtual machine) 
[https://developer.microsoft.com/en-us/microsoft-edge/tools/vms/]

## Downloads

* [selenium webdriver website](http://www.seleniumhq.org/download/)
* [selenium webdriver github](https://github.com/SeleniumHQ/selenium)
* [chromedriver](https://sites.google.com/a/chromium.org/chromedriver/downloads)
* [geckodriver](https://github.com/mozilla/geckodriver)
* [edgedriver](https://developer.microsoft.com/en-us/microsoft-edge/tools/webdriver/)

## Exercise one

1. Create a unit test project
2. Add the nuget packages NUnit, Selenium.Support, Selenium.Webdriver
3. Download the drivers to the bin folder for the project you created. Download the driver for each browser you have. Rename geckodriver to wires.exe
4. Create a test to go to wikipedia and search for "Limerick". Make this work for all the browsers. 

## Review

 What did you find out? Did you find any bugs?
 Did anything surprise you? Where do you report a bug for each component?
 How do you report these bugs?