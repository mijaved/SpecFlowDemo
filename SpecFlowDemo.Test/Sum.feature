﻿Feature: Sum
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And Again I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Add three numbers
	Given I have entered 8 into the calculator
	And Again I have entered 3 into the calculator
	And Once Again I have entered 3 into the calculator
	When I press add
	Then the result should be 14 on the screen
