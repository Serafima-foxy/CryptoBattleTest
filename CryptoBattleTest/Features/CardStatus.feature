Feature: CardStatus
	In order to know if I logged or not
	As a player
	I want to see card status


Scenario Outline: Checking card status when player created card and logout
	Given the game crypto-battle is opened in Google Chrome with player autorization
	When I click Create Request button
	When I select <warrior> from list
	When I click HP points button
	When I select <hp_points> from points list
	When I click Creat button
	When I click Logout button
	Then the Log in button should be in the new card

		Examples: 
		| warrior | hp_points |
		| BTC     | 50        |

Scenario Outline: Checking card status when player created card and stay in account
	Given the game crypto-battle is opened in Google Chrome with player autorization
	When I click Create Request button
	When I select <warrior> from list
	When I click HP points button
	When I select <hp_points> from points list
	When I click Creat button
	Then the new card is created

	Examples: 
		| warrior | hp_points |
		| BTC     | 50        |


