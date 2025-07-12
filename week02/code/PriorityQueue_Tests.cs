using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Basic priority queue functionality with different priorities
    // Expected: Highest priority item dequeued first, FIFO for same priorities
    // Requirements Covered: All core requirements in one test
    // - Handles different priorities
    // - Maintains FIFO for same priorities
    // - Properly removes dequeued items
    public void TestPriorityQueue_BasicOperations()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Low", 1);
        queue.Enqueue("High", 3);
        queue.Enqueue("Medium", 2);
        queue.Enqueue("High2", 3); // Same priority as High
        queue.Enqueue("Medium2", 2); // Same priority as Medium

        Assert.AreEqual("High", queue.Dequeue()); // Highest priority
        Assert.AreEqual("High2", queue.Dequeue()); // Same priority, FIFO
        Assert.AreEqual("Medium", queue.Dequeue());
        Assert.AreEqual("Medium2", queue.Dequeue());
        Assert.AreEqual("Low", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue
    // Expected: Throws InvalidOperationException
    // Requirements Covered: Empty queue handling
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestPriorityQueue_EmptyQueue()
    {
        var queue = new PriorityQueue();
        queue.Dequeue();
    }
}