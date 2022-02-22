using System;
using FluentAssertions;
using Xunit;

namespace MutationTesting.Tests.StrongerTests;

public class CalculatorTests
{
    private readonly Calculator _sut = new();
    
    [Theory]
    [InlineData(10, 5, 5)]
    public void Test_Add(int expected, int firstAddend, int secondAddend)
    {
        var result = _sut.Add(firstAddend, secondAddend);
    
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData(0, 5, 5)]
    [InlineData(5, 10, 5)]
    public void Test_Subtract(int expected, int minuend, int subtrahend)
    {
        var result = _sut.Subtract(minuend, subtrahend);
    
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(6, 3, 2)]
    public void Test_Multiply(int expected, int firstMultiplicand, int secondMultiplicand)
    {
        var result = _sut.Multiply(firstMultiplicand, secondMultiplicand);
    
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData(1, 0, 1, 1)]
    [InlineData(2, 0, 4, 2)]
    [InlineData(2, 1, 5, 2)]
    public void Test_Divide(int expected, int remainder, int dividend, int quotient)
    {
        var result = _sut.Divide(dividend, quotient);
    
        result.Result.Should().Be(expected);
        result.Remainder.Should().Be(remainder);
    }
    
    [Fact]
    public void Test_Divide_ByZero()
    {
        var result = () => _sut.Divide(1, 0);
    
        result.Should().Throw<DivideByZeroException>();
    }
}