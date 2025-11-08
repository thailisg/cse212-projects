using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: here we add three elements to dequeue them all
    // Expected Result: the elements are returned in order of highest to lowest priority
    // Defect(s) Found: It does not return the elements in the expected order
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 3);
        priorityQueue.Enqueue("Medium", 2);

        Assert.AreEqual("High", priorityQueue.Dequeue(), "element with highest priority");
        Assert.AreEqual("Medium", priorityQueue.Dequeue(), "element with medium priority");
        Assert.AreEqual("Low", priorityQueue.Dequeue(), "element with lowest priority");
    }

    [TestMethod]
    // Scenario: add elements with the same priority
    // Expected Result: that the elements return ordered in a queue
    // Defect(s) Found: returns the last element instead of the first (they have the same priority)
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Thai", 1);
        priorityQueue.Enqueue("Osman", 1);
        priorityQueue.Enqueue("Silvia", 1);

        Assert.AreEqual("Thai", priorityQueue.Dequeue());
        Assert.AreEqual("Osman", priorityQueue.Dequeue());
        Assert.AreEqual("Silvia", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.

}