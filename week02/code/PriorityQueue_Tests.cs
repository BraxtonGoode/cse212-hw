using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following items: Car (2), Bills (5)
    // Expected Result: Bills, Car
    // Defect(s) Found: error where it was not checking last item in the dequeue method and not removing item from the queue after dequeueing
    public void TestPriorityQueue_1()
    {
        
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Car", 2);
        priorityQueue.Enqueue("Bills", 5);

        Assert.AreEqual("Bills", priorityQueue.Dequeue(), "Higher priority item.");
        Assert.AreEqual("Car", priorityQueue.Dequeue(), "Lower priority item.");
    }

    [TestMethod]
    // Scenario: Have multiple items with the same priority: Car (2), Bike (5), Bills (5), Food (3)
    // Expected Result: Bike, Bills, Food, Car
    // Defect(s) Found: error where it wasnt checking for greater than only greater than or equal to in dequeue method
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Car", 2);
        priorityQueue.Enqueue("Bike", 5);
        priorityQueue.Enqueue("Bills", 5);
        priorityQueue.Enqueue("Food", 3);

        Assert.AreEqual("Bike", priorityQueue.Dequeue(), "Higher priority item.");
        Assert.AreEqual("Bills", priorityQueue.Dequeue(), "Same priority item.");
        Assert.AreEqual("Food", priorityQueue.Dequeue(), "Lower priority item.");
        Assert.AreEqual("Car", priorityQueue.Dequeue(), "Lowest priority item.");
    }

    [TestMethod]
    // Scenario: Try to dequeue from an empty queue
    // Expected Result: Exception should be thrown with appropriate error message.
    // Defect(s) Found: none found
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected exception was not thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message, "Exception message should match.");
        }
    }

    
}