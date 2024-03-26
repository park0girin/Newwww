using System.Collections.Generic;

public class MyStack<T>
{
    private int count;
    private int i;
    private MyQueue<T> queue1;
    private MyQueue<T> queue2;
    public MyStack()
    {
        count = 0;
    }
    public void push()
    {
        i = count - 1;
        while (i >= 0)
        {

        }
        count++;
    }
    public void pop()
    {
        count--;
    }
}
