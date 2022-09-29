using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class Calculator
{
    public Calculator() { }
    public double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value
                                    // Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = Add(num1, num2);
                break;
            case "s":
                result = Subtract(num1, num2);
                break;
            case "m":
                result = Multiply(num1, num2);
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                result = Divide(num1, num2);
                break;
            case "f":
                result = Factorial(num1);
                break;
            case "t":
                result = TriangleArea(num1, num2);
                break;
            case "c":
                result = CircleArea(num1);
                break;
            case "1":
                result = UnknownFunctionA(num1, num2);
                break;
            case "2":
                result = UnknownFunctionB(num1, num2);
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }
    public double Add(double num1, double num2)
    {
        bool checkForBinary(double val)
        {
            string value = val.ToString();
            if (Regex.IsMatch(value, "^[01]+$"))
            {
                return true;
            }
            return false;
        }

        if (checkForBinary(num1) && checkForBinary(num2))
        {
            return Convert.ToInt32((num1.ToString() + num2.ToString()), 2);
        }
        return (num1 + num2);
    }
    public double Subtract(double num1, double num2)
    {
        return (num1 - num2);
    }
    public double Multiply(double num1, double num2)
    {
        if (num1 == 0 || num2 == 0) return 0;
        return (num1 * num2);
    }
    public double Divide(double num1, double num2)
    {
        if (num1 == 0 && num2 == 0) return 1;
        if (num1 == 0) return 0;
        if (num2 == 0) return double.PositiveInfinity;
        if (num1 == 0 || num2 == 0) throw new ArgumentException();

        return (num1 / num2);
    }
    public double Factorial(double num1)
    {
        switch (num1)
        {
            case < 0:
                throw new ArgumentException("Number cannot be negative");
            case 0:
                return 1;
        }

        int fact = 1;
        for (int x = 1; x <= num1; x++)
        {
            fact *= x;
        }
        return fact;
    }
    public double TriangleArea(double height, double length)
    {
        if (height <= 0 || length <= 0) throw new ArgumentException();
        return (0.5 * height * length);
    }
    public double CircleArea(double radius)
    {
        if (radius <= 0) throw new ArgumentException();
        return (radius * radius * 3.142);
    }
    public double UnknownFunctionA(double num1, double num2)
    {
        // Permutation
        if (num1 < num2) throw new ArgumentException();

        return (Factorial(num1) / Factorial(num1 - num2));
    }
    public double UnknownFunctionB(double num1, double num2)
    {
        // Combination
        // 3 fact, 1 div , 1 multi, 1 sub
        if (num1 < num2) throw new ArgumentException();

        return Divide(Factorial(num1), (Factorial(num2) * Factorial(num1 - num2)));
    }

    public double MTBF(double MTTF, double MTTR)
    {
        return (MTTF + MTTR);
    }
    
    public double Availability(double MTTF, double MTBF)
    {
        return (MTTF / MTBF);
    }
    
    public double CurrentFailureIntensity(double initialFailure, double failureOverTime, double totalFailureOverTime)
    {
        double result = (initialFailure * (1 - (failureOverTime / totalFailureOverTime)));
        return (Math.Round(result, 0, MidpointRounding.AwayFromZero));
    }
    
    public double ExpectedFailureIntensity(double initialFailure, double totalFailureOverInfiniteTime, double time)
    {
        double result = (totalFailureOverInfiniteTime *
                         (1 - Math.Exp(-((initialFailure / totalFailureOverInfiniteTime) * time))));
        return (Math.Round(result, 0, MidpointRounding.AwayFromZero));
    }
}