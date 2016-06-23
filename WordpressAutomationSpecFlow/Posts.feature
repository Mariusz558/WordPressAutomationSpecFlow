Feature: Posts
	In order to manage my posts
	As a bloger
	I want to be able to add and remove posts.

@mytag
Scenario: Add new post
	Given I have logged in
	Given I am on the new post page
	When I enter my post
	Then I should see it on the Posts page

@ignore
Scenario: Delete a post
	Given I have logged in
	Given I am on the dashboard page
	Given There is at least one post created
	When I go to the post page
	Then I should be able to delete selected post
