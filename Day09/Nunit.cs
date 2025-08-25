using NUnit.Framework;

[TestFixture]
public class MathTests
{
    [Test]
    public void Add_TwoNumbers_ReturnsSum()
    {
        int a = 5, b = 10;
        int result = a + b;
        Assert.AreEqual(15, result);
    }
}
