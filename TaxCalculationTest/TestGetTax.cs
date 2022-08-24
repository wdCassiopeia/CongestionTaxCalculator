namespace TaxCalculationTest;


[TestClass]
public class TestGetTax
{

    [TestMethod]
    public void TestGetTaxLib()
    {
        var data = new List<KeyValuePair<TestData, int>>();
        data.Add(
            new KeyValuePair<TestData, int>(
                new TestData
                {
                    dateTimes = new DateTime[] { new DateTime(2013, 1, 2, 11, 11, 11),
                    new DateTime(2013, 1, 2, 11, 21, 11),
                    new DateTime(2013, 1, 2, 14, 11, 11)},
                    vehicle = new Car()
                }, 16));

        data.Add(
            new KeyValuePair<TestData, int>(
                new TestData
                {
                    dateTimes = new DateTime[] { new DateTime(2013, 1, 2, 11, 11, 11),
                    new DateTime(2013, 1, 2, 11, 21, 11),
                    new DateTime(2013, 1, 2, 14, 11, 11),
                    new DateTime(2013, 1, 2, 18, 10, 11)},
                    vehicle = new Car()
                }, 24));
                
        data.Add(
        new KeyValuePair<TestData, int>(
                new TestData
                {
                    dateTimes = new DateTime[] { new DateTime(2013, 1, 2, 11, 11, 11),
                    new DateTime(2013, 1, 2, 11, 21, 11),
                    new DateTime(2013, 1, 2, 14, 11, 11),
                    new DateTime(2013, 1, 2, 18, 10, 11)},
                    vehicle = new Bus()
                }, 0));

        foreach (KeyValuePair<TestData, int> keyValue in data)
        {
            var result = CongestionTaxCalculator.GetTax(keyValue.Key.vehicle, keyValue.Key.dateTimes);
            var expectedResult = keyValue.Value;

            Assert.AreEqual(expectedResult, result);
        }

    }
    public class TestData
    {
        
        public DateTime[]? dateTimes { get; set; }
        public Vehicle? vehicle { get; set; }
    }
}