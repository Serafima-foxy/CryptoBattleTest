Feature: BattleRequest
	In order to start battle
	As a gamer
	I want to select my warrior and HP points


Scenario Outline: Checking warriors selection
	Given the game crypto-battle is opened in Google Chrome with player autorization
	When I click Create Request button
	When I select <warrior> from list
	Then the selected icon should be in the warrior card

	Examples: 
		| warrior |
		| BCH     |
		| DASH    |
		| EOS     |
		| BTC     |
		| ETH     |
		| LTC     |
		| NEO     |
		| ZEC     |
		| ZRX     |
		| WAVES   |
		| BAT     |
		| XMR     |
		| XRP     |



Scenario Outline: Creat new card with selected warrior
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
		| BAT     | 100       |
		| ZEC     | 150       |
		| BTC     | 200       |
		| EOS     | 300       |
		| ETH     | 500       |

Scenario: Checking Connect button after creation warrior card and logouting
	Given the game crypto-battle is opened in Google Chrome with player autorization
	When I click Create Request button
	When I select <warrior> from list
	When I click HP points button
	When I select <hp_points> from points list
	When I click Creat button
	When I click Logout button
	Then the Log in button should be in the new card