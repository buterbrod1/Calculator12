namespace Calculator;

public class Application
{
    public Application(
        IMenu<IOperation> menu)
    {
        this.menu = menu;
    }

    private IMenu<IOperation> menu;

    public void Run()
    {
        RNumbers rNumbers = new RNumbers();
        Operation operation = (Operation)menu.Show().ItemSelector.Select();
        double result = operation.Run(rNumbers.RNums(operation.NumCount));
        Console.WriteLine($"Результат: {result}");
    }
}
