Feature: UsingCalculatorFactorial
In order to
As a
I want to
    
@Factorial
Scenario: Factorial a number
    Given I have a calculator
    When I have entered 3 into the calculator and press factorial
    Then the factorial result should be 6

@Factorial
Scenario: Factorial 0
    Given I have a calculator
    When I have entered 0 into the calculator and press factorial
    Then the factorial result should be 1
