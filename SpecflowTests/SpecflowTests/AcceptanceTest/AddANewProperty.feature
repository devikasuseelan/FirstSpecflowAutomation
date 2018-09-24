Feature: Add a new Property
	As a property Owner I want to add a new property and verify it is created


@mytag
Scenario: Add a new property with valid details
	Given I am in the My properties page
	When I added a new property
	Then I can see it in My properties page


