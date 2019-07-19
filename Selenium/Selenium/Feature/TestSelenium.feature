Feature: Testing the Execute Automation Selenium Test Site

Scenario: Login scenario
	Given User is at Login Page
	When User type any UserName and Password therefore press Login
	Given User should be at form page
	When User fills: Title: Mr, Initial: RAT, FirstName -Roberto, MiddleName: sapucaia, Gender: Female, LanguagesKnown: unmark English and mark Hindi
	And Press button Save
	And Press the button Generate
	Then A Javascript alert will appear on the screen
	When User press OK
	Then Another Javascript alert will appear on the screen
	When User press OK the test is done.