namespace Calculator;

public sealed class Division : Operation
{
    public Division() : base("Деление",2)
    {

    }

    public override double Run(params double[] numbers)
    {
        double result = numbers[0];
        for (int i = 1; i !=NumCount; i++)
        {
            result /= numbers[i];
        }
        return result;
    }
}
