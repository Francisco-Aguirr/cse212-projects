using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Basic dequeue operation with different priorities
    // Expected: Highest priority item is dequeued first
    // Requirements Covered: 
    // - Dequeue removes highest priority item
    // - Items with different priorities are handled correctly
    public void Dequeue_ReturnsHighestPriorityItem()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Low", 1);
        queue.Enqueue("High", 3);
        queue.Enqueue("Medium", 2);
        
        Assert.AreEqual("High", queue.Dequeue());
        Assert.AreEqual("Medium", queue.Dequeue());
        Assert.AreEqual("Low", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: Multiple items with same priority
    // Expected: Items are dequeued in FIFO order when priorities are equal
    // Requirements Covered:
    // - FIFO order maintained for same-priority items
    // - Multiple items with same priority handled correctly
    public void Dequeue_ReturnsFIFO_WhenSamePriority()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("First", 1);
        queue.Enqueue("Second", 1);
        queue.Enqueue("Third", 1);
        
        Assert.AreEqual("First", queue.Dequeue());
        Assert.AreEqual("Second", queue.Dequeue());
        Assert.AreEqual("Third", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: Mixed priorities with multiple items
    // Expected: Correct priority order with FIFO for same priorities
    // Requirements Covered:
    // - Complex scenario mixing different priorities
    // - Verifies both priority and FIFO behaviors together
    public void Dequeue_HandlesMixedPrioritiesCorrectly()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Low1", 1);
        queue.Enqueue("High1", 3);
        queue.Enqueue("Med1", 2);
        queue.Enqueue("Med2", 2);
        queue.Enqueue("Low2", 1);
        queue.Enqueue("High2", 3);
        
        Assert.AreEqual("High1", queue.Dequeue());
        Assert.AreEqual("High2", queue.Dequeue());
        Assert.AreEqual("Med1", queue.Dequeue());
        Assert.AreEqual("Med2", queue.Dequeue());
        Assert.AreEqual("Low1", queue.Dequeue());
        Assert.AreEqual("Low2", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue
    // Expected: Throws InvalidOperationException
    // Requirements Covered:
    // - Empty queue handling
    // - Proper exception type and behavior
    [ExpectedException(typeof(InvalidOperationException))]
    public void Dequeue_ThrowsException_WhenEmpty()
    {
        var queue = new PriorityQueue();
        queue.Dequeue();
    }

    [TestMethod]
    // Scenario: Single item in queue
    // Expected: Returns the single item
    // Requirements Covered:
    // - Edge case of single item queue
    // - Basic functionality verification
    public void Dequeue_ReturnsSingleItem()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Single", 1);
        Assert.AreEqual("Single", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: Negative priorities
    // Expected: Correctly handles negative priorities
    // Requirements Covered:
    // - Negative priority handling
    // - Priority comparison works with negative numbers
    public void Dequeue_HandlesNegativePriorities()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Negative", -1);
        queue.Enqueue("Positive", 1);
        queue.Enqueue("Zero", 0);
        
        Assert.AreEqual("Positive", queue.Dequeue());
        Assert.AreEqual("Zero", queue.Dequeue());
        Assert.AreEqual("Negative", queue.Dequeue());
    }
}