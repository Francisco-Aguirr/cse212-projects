using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    public void Dequeue_ReturnsHighestPriorityItem()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Low", 1);
        queue.Enqueue("High", 3);
        Assert.AreEqual("High", queue.Dequeue());
    }

    [TestMethod]
    public void Dequeue_ReturnsFIFO_WhenSamePriority()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("First", 1);
        queue.Enqueue("Second", 1);
        Assert.AreEqual("First", queue.Dequeue());
    }
}