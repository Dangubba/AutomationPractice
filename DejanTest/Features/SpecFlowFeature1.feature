Feature: Check if login is posible
	


Scenario: Login process
	Given I am on login form pop up
	When I enter valid email address
	And I enter valid password
	And I click on submit button
	Then My account page is diplayed
