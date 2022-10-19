﻿Feature: Login
	In order to access my account
    As a user of the website
    I want to log into the website

@Login
Scenario: Successful Login with Valid Credentials
	Given User is at the Home Page
	And Navigate to LogIn Page
	When User enter UserName and Password
	And Click on the LogIn button
	Then Successful LogIN message should display