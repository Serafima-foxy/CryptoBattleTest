Feature: Authorization
	In order to play game
	As a gamer
	I want to authorized


Scenario: Checking authorization with google accaunt
	Given the game crypto-battle is opened in Google Chrome
	When I click Log in button
	When I click Google button
	When I enter email in field
	When I click Next button
	When I enter password in field
	When I click Next button
	Then the game label should be in the screen
