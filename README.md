#Topic: Selenium Webdriver Framework. 
A introduction in C#.
=====================================

By the end of the meeting you will have it installed and running against Chrome and Firefox 
(and Edge if your using windows/ or using a windows virtual machine).
We will show you how run a test that tests the UI of a page across browsers. 

## Prerequisite

Before the meeting install Visual Studio Community edition. 
If you have any problems we will help you get that installed. If you do not have a laptop we can pair you with another person. 

Since we used Nunit, I would also recommend a test adapter. You can find this in Tools > Extensions and Updates 
* [Nunit 2 Test adapter] (http://nunit.org/index.php?p=vsTestAdapter&r=2.6.4)
* [Nunit 3 Test adapter](https://visualstudiogallery.msdn.microsoft.com/0da0f6bd-9bb6-4ae3-87a8-537788622f2d) (for running Nunit 3 tests)

(skip this if you have windows)
Virtual machine link for Windows 10 (if you want to install it on a virtual machine) 
[https://developer.microsoft.com/en-us/microsoft-edge/tools/vms/]

Git. 

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
5. Once you have finished the exercise push it to your own github account. 


## Review

 What did you find out? Did you find any bugs?
 Did anything surprise you? Where do you report a bug for each component?
 How do you report these bugs?
 
## References

* [git tutorial](https://try.github.io/levels/1/challenges/1)
* [git cheatsheet](https://rogerdudler.github.io/git-guide/)
* [git tutorial from github](https://guides.github.com/activities/hello-world/)
* [c# reference](https://msdn.microsoft.com/en-us/library/67ef8sbd.aspx)

* [naughty strings list](https://github.com/minimaxir/big-list-of-naughty-strings)
