
using System;
using System.Collections.Generic;
using System.Linq;

public class PriorityQueue
{
    private readonly List<PriorityItem> _queue = new();

    public int Count => _queue.Count;             

    public void Enqueue(string value, int priority)
    {
        _queue.Add(new PriorityItem(value, priority));
    }

    public string Dequeue()
    {
        if (_queue.Count == 0)
            throw new InvalidOperationException("The queue is empty.");

        int highPriorityIndex = 0;
        for (int i = 1; i < _queue.Count; i++)
        {
            if (_queue[i].Priority > _queue[highPriorityIndex].Priority)
                highPriorityIndex = i;              
        }

        string value = _queue[highPriorityIndex].Value;
        _queue.RemoveAt(highPriorityIndex);
        return value;
    }

   
    public override string ToString()
    {
        if (_queue.Count == 0) return "[]";
        return "[" + string.Join(", ", _queue.Select(item => item.ToString())) + "]";
    }
    
}

internal class PriorityItem
{
    public string Value    { get; }
    public int    Priority { get; }

    public PriorityItem(string value, int priority)
    {
        Value    = value;
        Priority = priority;
    }

    public override string ToString() => $"{Value} (Pri:{Priority})";
}
