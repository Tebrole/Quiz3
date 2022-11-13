namespace CustomQueueImplementation;

public class MyQueue<T>
{
    private List<T>? _queue;

    public MyQueue(List<T>? queue)
    {
        _queue = queue;
    }

    public MyQueue()
    {
        _queue = new List<T>();
    }

    public MyQueue(int capacity)
    {
        _queue = new List<T>(capacity);
    }

    public void Push(T element)
    {
        //Adds value at the end of the list
        _queue!.Add(element);
    }

    public T Pop()
    {
        if (_queue == null || _queue?.Count == 0)
        {
            throw new IndexOutOfRangeException("Queue is empty");
        }

        T element = _queue![0];
        _queue.RemoveAt(0);

        return element;
    }

    public T Peek()
    {
        if (_queue == null || _queue?.Count == 0)
        {
            throw new IndexOutOfRangeException("Queue is empty");
        }

        T element = _queue![0];
        return element;
    }

    public bool IsEmpty()
    {
        return _queue != null && _queue.Count == 0;
    }
}