namespace Calculator;

public abstract class Operation : IOperation
{
    public Operation(string name, int NumCounts)
    {
        Name = name;
        NumCount = NumCounts;
    }

    public string Name { get; }
    public int NumCount { get; }


    public abstract double Run(params double[] numbers);
}
