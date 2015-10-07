Feature: backlog tree DSL parsing
	In order to prove that SpecFlow is better than a custom parser
	As a rebellious student
	I want to implement a DSL for backlog items structured as trees

Scenario: Specify a test with a tree
	Given a backlog item named 'my item A'
	And a child backlog item named 'my item B' with parent 'my item A'
	And a child backlog item named 'my item C' with parent 'my item A'
	And a child backlog item named 'my item D' with parent 'my item C'
	And a child backlog item named 'my item E' with parent 'my item B'
	And a child backlog item named 'my item F' with parent 'my item E'
	When I run the test
	Then the test should pretty print a tree of backlog items
