// See https://aka.ms/new-console-template for more information

using CustomQueueImplementation;

MyQueue<int> queue = new MyQueue<int>();

queue.Push(1);
queue.Push(2);
queue.Push(3);
queue.Push(4);
queue.Push(5);

int value = queue.Pop();
Console.WriteLine(value);
value = queue.Peek();
Console.WriteLine(value);
Person per1 = new Person("Tekla");
Person per2 = new Person("Nefeli");

MyQueue<Person> queue1 = new MyQueue<Person>();
queue1.Push(per1);
queue1.Push(per2);

Person personvalue = queue1.Pop();
Console.WriteLine(personvalue.GetFirstname());

public class Person
{
    private string _firstname;

    public Person(string firstname)
    {
        _firstname = firstname;
    }

    public string GetFirstname()
    {
        return _firstname; 
    }
}