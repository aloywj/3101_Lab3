using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class UsingAvailabilityStepDefinition
{
    private Calculator _calculator;
    private double _result;
        
    public UsingAvailabilityStepDefinition(Calculator calc)
    {
        this._calculator = calc;
    }

    [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMtbf(double p0, double p1)
    {
        _result = _calculator.MTBF(p0, p1);
    }

    [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double p0, double p1)
    {
        _result = _calculator.Availability(p0, p1);
    }

    [Then(@"the availability result should be (.*)")]
    public void ThenTheAvailabilityResultShouldBe(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}