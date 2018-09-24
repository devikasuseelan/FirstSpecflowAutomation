Feature: ListARental
	As a property owner Iwant to list a property for renting

@mytag
Scenario: Listing a property for renting
	Given I am in My properties page
	When I entered detais for renting
	Then I should be able to list it