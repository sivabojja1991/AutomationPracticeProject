Feature: Register
	In order to access my account
    As a user of the website
    I want to Register into the website

@Register
Scenario: Successful Login with Valid Credentials
	Given User is at the AutoMation Practice Home Page
	And Navigate to SignIn Page
	When User given at valid Email address
	And Click on the Create an account Button
	And User fill the Register Form
	And User click the Register Button
	Then Register message should display