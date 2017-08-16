Feature: Login Action
		 In order to have multiple tests I should have valid Credentials
		 And should be able to login and logout from Goppa

@mytag
Scenario: 0.1Login Successful 
	Given User is on Goppa Home Page
	When  User Navigate to LogIn Page
	And   User enters "testgoppa@mailinator.com" and "Test123456" 
	#Then  New user is loged in  Successfully

#Scenario: 0.2LogOut Successful 
#	When User LogOut from the Goppa
#	Then  LogOut is done Successfully 