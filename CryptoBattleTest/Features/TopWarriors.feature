Feature: TopWarriors
	In order to know top players and aim to the top
	As a player
	I want to see top 10 players

Scenario: Checking Top Warriors label
	Given the game crypto-battle is opened in Google Chrome
	Then the Top Warrior should be a label

Scenario Outline: Checking Top 10 warriors names
	Given the game crypto-battle is opened in Google Chrome
	Then the <warrior_name> should be in the name field

	Examples:
		| warrior_name        |
		| Андрей_Беличенко!!! |
		| Not_Funny           |
		| Andrey Belichenko   |
		| Diana               |
		| Андрій Бєліченко444 |
		| Borik               |
		| Борис               |
		| Андрей Беличенко    |
		| Роман Криптоман     |
		| Наташа Хайдар       |

Scenario Outline: Checking Top 10 warriors scores
	Given the game crypto-battle is opened in Google Chrome
	Then the <warrior_score> should be in the score field

	Examples:
		| warrior_score |
		| 23            |
		| 18            |
		| 17            |
		| 14            |
		| 12_A          |
		| 12_B          |
		| 11            |
		| 8             |
		| 7             |
		| 5             |

Scenario: Checking player's name
	Given the game crypto-battle is opened in Google Chrome with player autorization
	Then the player name should be in the name list
	Then the player score should be in the score list