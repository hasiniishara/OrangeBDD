Feature: Login

This login feature is examine the all the positive and negative scenarios

@focus
Scenario: User login with valid credentials
	Given User on system login page
	When User enter valid credentials
		| key	   | value		|
		| userName | Admin		|
		| userPwd  | @PbgG0F5cW |
	Then User should be able to see the Dashboard screen
