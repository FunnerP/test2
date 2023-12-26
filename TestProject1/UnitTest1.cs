namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void TestAverageSum()
        {
            int number1 = 12345;
            int number2 = 67890;
            double expectedAverageSum = 22.5;

            double result = MyClass.CalculateAverageSum(number1, number2);

            Assert.AreEqual(expectedAverageSum, result);
        }

        [Test]
        public void TestDigitSum()
        {
            int number = 12345;
            int expectedDigitSum = 15;

            int result = MyClass.CalculateDigitSum(number);

            Assert.AreEqual(expectedDigitSum, result);
        }
    }
}