namespace Fundamentos_EXT;

public class Array<T>
{
    private static int cap = 10;
    private int aux = 0;
    private T[] array = new T[cap];

    public void AddElementoArray(T elemento)
    {
        if (aux + 1 < 11)
        {
            array[aux] = elemento;
        }
        aux++;
    }

    public T this[int i]
    {
        get => array[i];
        set => array[i] = value;
    }
}