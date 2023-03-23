namespace GenericsAndLambda;

public class MyClass<T>
{
    public T Data { get; set; }

    public void MyMethod<E>()
    {
        //...
    }
}