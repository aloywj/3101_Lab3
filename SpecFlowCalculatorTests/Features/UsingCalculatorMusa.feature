Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@Musa
Scenario: Calculate current failure intensity
	Given I have a calculator
	When  the initial failure intensity 10 and the average number of failures 50 and the total number of failure over infinite time 100 and calculate current failure intensity
	Then the current failure intensity should be 5
	
@Musa
Scenario: Calculate average number of failures
	Given I have a calculator
	When the initial failure intensity 10 and  the total number of failure over infinite time 100 and number of CPU Hours 10 calculate the numbers of failures
	Then the number of failures experienced should be 63
