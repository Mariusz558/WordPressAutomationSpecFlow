Feature: Posts
	In order to manage my posts
	As a bloger
	I want to be able to add and remove posts.

@mytag
Scenario: Add new post
	Given I have logged in
	And I am on the new post page
	When I enter my post
	Then I should see it on the Posts page
