Feature: Login
	In order to write my diary
	As a blogger
	I want to be albe to log in

@mytag
Scenario: Positive Login
	Given I am on the login page
	And I have entered my credentials
	When I press Log in button
	Then I should be able to see my dashboard page

@mytag @closeAfter
Scenario: Negative Login - False User Name
	Given I am on the login page
	And I have entered unvalid user name
	When I press Log in button
	Then I should be able to see an error message 'ERROR: Invalid username. Lost your password?'

@mytag @closeAfter
Scenario: Negative Login - False Password
	Given I am on the login page
	And I have entered invalid password
	When I press Log in button
	Then I should be able to see an error message 'ERROR: The password you entered for the username mariusz is incorrect. Lost your password?'

@mytag @closeAfter
Scenario: Negative Login - Invalid Credantials
	Given I am on the login page
	And I have entered invalid credentials
	When I press Log in button
	Then I should be able to see an error message 'ERROR: Invalid username. Lost your password?'
