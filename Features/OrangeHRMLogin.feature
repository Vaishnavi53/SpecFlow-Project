Feature: OrangeHRM
 
Test orange hrm website login functionality

Background: User is on the orange hrm login page
 
Scenario Outline: Verify login for orange hrm website
	When User enters the "<usrname>" and "<passwd>" in the text fields
	When User clicks on submit button
	Then User is navigated to home page
 
Examples: 
| usrname | passwd   |
| Admin   | admin123 |


Scenario Outline: Verify login for orange hrm website for invalid credentails
	When User enters the "<usrname>" and "<passwd>" in the text fields
	When User clicks on submit button
	Then User is on the home page and a error is displayed
 
Examples: 
| usrname | passwd   |
| Admin   | admin1234 |