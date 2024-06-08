namespace Calculator;

public interface IMenuItemSelector<out T>
{
    public T Select();
}
