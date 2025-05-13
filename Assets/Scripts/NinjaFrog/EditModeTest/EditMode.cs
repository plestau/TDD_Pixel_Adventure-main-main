using NUnit.Framework;
using UnityEngine;

[TestFixture]
public class NinjaFrogMovementTests
{
    private NinjaFrogStats stats;

    [SetUp]
    public void SetUp()
    {
        stats = new NinjaFrogStats();
    }

    [TestCase(5f, true)]
    public void CanMove_Case(float testSpeed, bool expected)
    {
        stats.speed = testSpeed;
        bool canMove = stats.CanMove();
        Assert.AreEqual(expected, canMove, $"Expected CanMove() to return {expected} for speed {testSpeed}");
    }
}