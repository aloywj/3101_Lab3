using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

    [When(@"I have entered (.*) as initial failure and (.*) as failure over time and (.*) as total failure over time and press FI")]
    public void WhenIHaveEnteredAsInitialFailureAndAsFailureOverTimeAndAsTotalFailureOverTimeAndPressFi(double initialFailure, double failureOverTime, double totalFailureOverTime)
    {
        _result = _calculator.CurrentFailureIntensity(initialFailure, failureOverTime, totalFailureOverTime);
    }

    [When(@"I have entered (.*) as initial failure and (.*) as total failure over infinite time and (.*) as time and press EF")]
    public void WhenIHaveEnteredAsInitialFailureAndAsTotalFailureOverInfiniteTimeAndAsTimeAndPressEf(double initialFailure, double totalFailureOverInfiniteTime, double time)
    {
        _result = _calculator.CurrentFailureIntensity(initialFailure, totalFailureOverInfiniteTime, time);
    }
}