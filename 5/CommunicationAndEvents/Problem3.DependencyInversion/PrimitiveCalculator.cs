using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimitiveCalculator
{
    private IStrategy strategy;

    public PrimitiveCalculator() : this(new AdditionStrategy())
    {
    }

    public PrimitiveCalculator(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void changeStrategy(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    public int performCalculation(int firstOperand, int secondOperand)
    {
        return this.strategy.Calculate(firstOperand, secondOperand);
    }
}
