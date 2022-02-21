namespace MutationTesting;

public class Calculator
{
    public int Add(int firstAddend, int secondAddend)
    {
        return firstAddend + secondAddend;
    }
    
    public int Subtract(int minuend, int subtrahend)
    {
        return minuend - subtrahend;
    }
    
    public int Multiply(int firstMultiplicand, int secondMultiplicand)
    {
        return firstMultiplicand * secondMultiplicand;
    }
    
    public (int Result, int Remainder) Divide(int dividend, int quotient)
    {   
        var result = dividend / quotient;
        var remainder = dividend % quotient;

        return (result, remainder);
    }
}
