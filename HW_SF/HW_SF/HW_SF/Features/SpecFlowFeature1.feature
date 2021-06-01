Feature: NWAppTest
	Testing NWApp

@mytag
Scenario: login, create new product, check parameters, logout, close brouser
	Given I open "http://localhost:5000" url
	When I type name and password
	And i check login
	And I click on all products button 
	And I click on create new button
	And I enter parameters in to fields
	And I click on new product
	And I check product parameters
	And I logout
	Then end test