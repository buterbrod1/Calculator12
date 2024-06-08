namespace Calculator;

public interface IMenu<out T>
{
    public IMenu<T> Show();
    public IMenuItemSelector<T> ItemSelector { get; }
}
