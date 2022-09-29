Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@Musa
Scenario: Calculate current failure intensity
	Given I have a calculator
	When I have entered 5 as initial failure and 10 as failure over time and 15 as total failure over time and press FI
	Then the result should be 300
	
@Musa
Scenario: Calculate expected average failure intensity
	Given  I have a calculator
	When I have entered 5 as initial failure and 10 as total failure over infinite time and 15 as time and press EF
	Then the result should be 400
