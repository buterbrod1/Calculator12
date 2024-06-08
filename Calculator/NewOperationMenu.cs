namespace Calculator;

public sealed class NewOperationMenu : IMenu<IOperation>
{
    public NewOperationMenu(IOperationProvider operationProvider,
        IOperationMenuItemSelector menuItemSelector)
    {
        this.operationProvider = operationProvider;
        ItemSelector = menuItemSelector;
    }

    private readonly IOperationProvider operationProvider;

    public IMenuItemSelector<IOperation> ItemSelector { get; }

    public IMenu<IOperation> Show()
    {
        Console.WriteLine("... Калькулятор ...");
        int i = 1;
        foreach (Operation operation in operationProvider.Get())
            Console.WriteLine($"{i++}. {operation.Name};");
        return this;
    }
}
