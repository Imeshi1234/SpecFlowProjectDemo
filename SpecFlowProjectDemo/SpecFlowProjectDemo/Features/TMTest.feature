Feature: Create,Edit, and Delete TM Record

Background: 
Given user logs into TurnUp Portal
And user navigates to time and material page

Scenario: A. Create a TM record
When user creates a new time and material racord
Then turnup portal should save the time and material record


Scenario: B. Edit TM record
When user edit an existing time and material racord
Then turnup portal should save the existing time and material record


Scenario: C. Delete a TM record
When user delete an existing time and material racord
Then The time and material record should delete from turnup portal 