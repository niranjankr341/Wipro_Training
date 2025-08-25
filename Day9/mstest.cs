using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class StringTests
{
    [TestMethod]
    public void CheckLength()
    {
        string text = "Wipro";
        Assert.AreEqual(5, text.Length);
    }
}
