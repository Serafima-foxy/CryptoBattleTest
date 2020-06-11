Feature: BattleRequest
	In order to start battle
	As a player
	I want to select my warrior and HP points


Scenario Outline: Checking warriors selection
	Given the game crypto-battle is opened in Google Chrome with player autorization
	When I click Create Request button
	When I select <warrior> from list
	Then the <selected_icon> should be in the warrior card

	Examples: 
		| warrior | selected_icon |
		| BCH     | BCH icon      |
		| DASH    | DASH icon     |
		| EOS     | EOS icon      |
		| BTC     | BTC icon      |
		| ETH     | ETH icon      |
		| LTC     | LTC icon      |
		| NEO     | NEO icon      |
		| ZEC     | ZEC icon      |
		| ZRX     | ZRX icon      |
		| WAVES   | WAVES icon    |
		| BAT     | BAT icon      |
		| XMR     | XMR icon      |
		| XRP     | XRP icon      |


Scenario Outline: Creat new card with selected warrior and HP points
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
		| XRP     | 200       | 
		| EOS     | 300       | 
		| ETH     | 500       | 

Scenario: Cheking Creation request function with logouting player
	Given the game crypto-battle is opened in Google Chrome
	Then the Create request button is not found

Scenario: Checking Connect button to another player
	Given the game crypto-battle is opened in Google Chrome with player autorization
	When another player card exist
	Then the Connect button should be in that card