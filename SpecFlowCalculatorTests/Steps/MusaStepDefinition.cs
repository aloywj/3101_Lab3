using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class UsingMusaStepDefinition
{
    private Calculator _calculator;
    private double _result;
        
    public UsingMusaStepDefinition(Calculator calc)
    {
        this._calculator = calc;
    }

    [When(@"the initial failure intensity (.*) and the average number of failures (.*) and the total number of failure over infinite time (.*) and calculate current failure intensity")]
    public void WhenTheInitialFailureIntensityAndTheAverageNumberOfFailuresAndTheTotalNumberOfFailureOverInfiniteTimeAndCalculateCurrentFailureIntensity(double p0, double p1, double p2)
    {
        _result = _calculator.CurrentFailureIntensity(p0, p1, p2);
    }

    [When(@"the initial failure intensity (.*) and  the total number of failure over infinite time (.*) and number of CPU Hours (.*) calculate the numbers of failures")]
    public void WhenTheInitialFailureIntensityAndTheAverageNumberOfFailuresAndTheTotalNumberOfFailureOverInfiniteTimeAndNumberOfCpuHoursCalculateTheNumbersOfFailures(double p0, double p1, double p2)
    {
        _result = _calculator.ExpectedFailureIntensity(p0, p1, p2);
    }

    [Then(@"the number of failures experienced should be (.*)")]
    public void ThenTheNumberOfFailuresExperiencedShouldBe(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }

    [Then(@"the current failure intensity should be (.*)")]
    public void ThenTheCurrentFailureIntensityShouldBe(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}