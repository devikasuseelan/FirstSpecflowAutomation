Feature: Add tenant details
	As a property owner the user want to add tenant details

@mytag
Scenario: Add a new tenant details
	Given I am in my properties page
	And   I searched for a property
	When  I added tenant details
	Then  I should get tenant successfuly added message