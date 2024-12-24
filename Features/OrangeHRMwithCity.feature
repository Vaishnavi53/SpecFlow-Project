Feature: OrangeHRLogin


Scenario: Verify login with valid credentails
	Given User is on the login page
	When user enters the username  in the text fields
	Then user is navigated to home page

Scenario Outline:  Verify login with test parameters
	When user enters the "<username>" and "<password>"
	And user clicks on login button 
	Then user is navigates to home page
	Then user selects city and country information
	| city   | country |
	| Delhi  | India   |
	| Boston | USA     |

Examples: 
| username | password |
| tom      | harry    |


