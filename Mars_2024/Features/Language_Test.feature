Feature: This test suite contains test sceanrios for the following
1. Create Language
2. Edit Language
3. Delete Language

Scenario: A. Verify user is able to create a new Language
	Given user logs into account portal
	Then user navigates to the home screen
	When user create a new Language 'Gujarati'
	Then system should save Language 'Gujarati'


Scenario Outline: B. User able to Edit the the language records
	Given User logs
	Then User go to the home screen
	When User able to edit the record 'Run Test'
	Then User able to update record in language page 'Run Test'


Scenario: C. Delete an existing Language record
	Given User log into Mars
	When User delete an existing Language record
	Then the record should be deleted 'Hindi'