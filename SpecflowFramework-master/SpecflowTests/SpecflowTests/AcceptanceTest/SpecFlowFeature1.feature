Feature: Indicate Happiness
	In order inform my individual happiness level
	As a team member
	I want to be able to select and submit my happiness level details

@mytag
Scenario Outline: Submit Individual Hapiness Level
	Given I have entered my individual happiness level
	When I press on the submit button <Emotion>
	Then the hapiness level information should be submitted 

	Examples: 
	| Emotion   |
	| VeryHappy |
	| Scared    |
	| Angry     |
	| VeryBad   |
	| Sad       |
	| Crying    |

Scenario: Cancel Happiness Level Selection
	Given I have entered my individual happiness level
	When I press on the Cancel button
	Then the happiness level selection should not be submitted and saved

Scenario: Change Selection before Submitting
	Given I have entered my individual happiness level
	When I change the initial selection
	Then the new selection is activated