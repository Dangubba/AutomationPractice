Feature: ElementsDisplayedOnEvents
	
@mytag
Scenario: Check if the all sponsors are displayed
	Given User is on homepage
	When User click on Events link in Navbar
	And User click Subsea Americas 2018 event
	Then Silver sponsors are displayed
