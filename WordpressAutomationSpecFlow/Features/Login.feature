Feature: Login
	In order to write my diary
	As a blogger
	I want to be albe to log in

Background: 
	Given I am on the login page

@mytag
Scenario: Positive Login
	Given I have entered my credentials
	When I press Log in button
	Then I should be able to see my dashboard page

@mytag
Scenario: Negative Login - False User Name
	Given I have entered unvalid user name
	When I press Log in button
	Then I should be able to see an error message 'ERROR: Invalid username. Lost your password?'

@mytag
Scenario: Negative Login - False Password
	Given I have entered invalid password
	When I press Log in button
	Then I should be able to see an error message 'ERROR: The password you entered for the username mariusz is incorrect. Lost your password?'

@mytag
Scenario: Negative Login - Invalid Credantials
	Given I have entered invalid credentials
	When I press Log in button
	Then I should be able to see an error message 'ERROR: Invalid username. Lost your password?'
