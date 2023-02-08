namespace DependencyInjection.Services;

public class CounterService
{
    public int Count { get; private set; } = 0;

    public void Increment()
    {
        Count++;
    }
}