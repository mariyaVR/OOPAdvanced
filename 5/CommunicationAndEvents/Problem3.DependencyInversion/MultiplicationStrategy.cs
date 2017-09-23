using System;

class MultiplicationStrategy : IStrategy
{
    public int Calculate(int firstOperand, int secondOperand)
    {
        return firstOperand * secondOperand;
    }
}