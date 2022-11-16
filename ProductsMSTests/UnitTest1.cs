using ProductsClass;
namespace ProductsMSTests;

[TestClass]
public class UnitTest1
{
    [TestMethod(displayName: "TestMultiplyOperator")]
    public void TestMultiplyOperator()
    {
        Product p1 = new("test", 10);

        Product p2 = p1 * 5;
        Assert.AreEqual(p2.GetPrice(), 50);
    }

    [TestMethod(displayName: "TestSumOperator")]
    public void TestSumOperator()
    {
        Product p1 = new("test", 10);
        Product p2 = new("test2", 20);
        Product p3 = p1 + p2;
        Assert.AreEqual(p3.GetPrice(), 30);
    }

    [TestMethod(displayName: "TestPPOperator")]
    public void TestPPOperator()
    {
        Product p1 = new("test", 10);
        Product p2 = ++p1;
        Assert.AreEqual(p2.GetPrice(), 20);
    }

    [TestMethod]
    public void TestMoreOperator()
    {
        Product p1 = new("test", 10);
        Product p2 = new("test2", 20);
        Assert.AreEqual(p2>p1, true);
    }

    [TestMethod]
    public void TestLessOperator()
    {
        Product p1 = new("test", 110);
        Product p2 = new("test2", 20);
        Assert.AreEqual(p2 < p1, true);
    }

    [TestMethod]
    public void TestMultySumOperator()
    {
        Product p1 = new("test", 10);
        Product p2 = new("test2", 20);
        Product p3 = new("test3", 5);
        Assert.AreEqual(Product.GetSum(p1, p2, p3), 35);
    }

    [TestMethod]
    public void TestEqualOperator()
    {
        Product p1 = new("test", 10);
        Product p2 = new("test", 10);
        Assert.AreEqual(p2 == p1, true);
    }

    [TestMethod]
    public void TestNonEqualOperator()
    {
        Product p1 = new("test", 10);
        Product p2 = new("test", 50);
        Assert.AreEqual(p2!=p1, true);
    }

    [TestMethod]
    public void TestEqualOrMoreOperator()
    {
        Product p1 = new("test", 10);
        Product p2 = new("test2", 10);
        Assert.AreEqual(p2 >= p1, true);
    }

    [TestMethod]
    public void TestEqualOrLessOperator()
    {
        Product p1 = new("test", 20);
        Product p2 = new("test2", 20);
        Assert.AreEqual(p2 <= p1, true);
    }

    [TestMethod]
    public void TestEqualOrMoreOperator2()
    {
        Product p1 = new("test", 10);
        Product p2 = new("test2", 11);
        Assert.AreEqual(p2 >= p1, true);
    }

    [TestMethod]
    public void TestEqualOrLessOperator2()
    {
        Product p1 = new("test", 20);
        Product p2 = new("test2", 19);
        Assert.AreEqual(p2 <= p1, true);
    }
}
