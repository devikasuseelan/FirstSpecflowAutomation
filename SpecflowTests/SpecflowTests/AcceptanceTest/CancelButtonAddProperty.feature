Feature: CancelButtonAddProperty
	I want to check the functionality of cancel button in Add property page.

@mytag
Scenario: check the functionality of cancel button in add property page
     Given I am in the add property page
	 When I clicked the cancel button
	 Then I must be taken to my properties page
