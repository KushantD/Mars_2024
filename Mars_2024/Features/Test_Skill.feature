Feature: This feature contains test scenarios for the following
1. Create skill
2. Edit skill
3. Delete skill

Scenario: Verify user is able to create new skill
Given user logs into account screen
Then  user navigate to the home screen
When  user create new skill 'Demt' 'Beginner'
Then  User should able to save new skill 'Demt' 



Scenario Outline:  Verify  iser is able to edit existing skill record
Given user logs into account and navigate to home screen
When user edit existing skill record 'Office1' 'Beginner'
Then user should able to update skill record 'Office1'

Scenario: C. Delete an existing skill record
	Given User should log into Mars 
	When User delete an existing skill record
	Then the record must be deleted 



        
       
