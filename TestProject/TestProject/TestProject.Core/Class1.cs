
namespace TestProject.Core;

public class Calculator
{
    public int Add(int a, int b) => a + b;

    public int Divide(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException();
        return a / b;
    }

    public int Substract(int a, int b) => a - b;

    public int Mutliply(int a, int b) => a * b;
}
