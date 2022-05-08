using NUnit.Framework;
using System.Linq;

namespace Summator.Tests
{
    [TestFixture]
    public class SummatorTests
    {
        [Test] //Method Sum
       public void Test_Sum_TwoPositiveNumbersAAA()
        {
            //1. Arrange
            var values = new int[] { 5, 7 };
            int expected = 12;

            //2. Act
            int actual = Summator.Sum(values);


            //3. Assert
            Assert.That(expected == actual);
        }

        [Test] 
        public void Test_Assertions()
        {
            var values = new int[] { 5, 7 };
            int expected = 12;
            int actual = Summator.Sum(values);

            Assert.That(expected == actual, "Summator value should be equal to 10");
            Assert.That(expected, Is.EqualTo(actual));
            Assert.AreEqual(expected, actual);

            double percentage = 99.95;
            Assert.That(percentage, Is.InRange(80, 100));

            Assert.That("QA are awesome", Does.Contain("awesome"));

            string date = "7/11/2021";
            Assert.That(date, Does.Match(@"^\d{1,2}/\d{1,2}/\d{4}$"));

            
            Assert.That(() => "abv"[10], Throws.TypeOf<System.IndexOutOfRangeException>());

            Assert.That(Enumerable.Range(1, 100), Has.Member(50));
           
        }

        [Test]
        [Category("Critical")]
        public void Test_Sum_MultiplePositiveNumbers()
        {
            int expected = Summator.Sum(new int[] { 5, 7, 8, 9, 10 });
            int actual = 39;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_OnePositiveNUmber()
        {
            int actual = Summator.Sum(new int[] { 5 }); // int result

            Assert.That(actual == 5); //return bool true or false
        }

        [Test]
        public void Test_Sum_TwoNegativeNUmbers()
        {
            int actual = Summator.Sum(new int[] { -7, -9 }); 

            Assert.That(actual == -16); 
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            int actual = Summator.Sum(new int[] { });

            Assert.That(actual == 0); 
        }

        /*
        [Test]
        public void Test_Sum_BigValues()
        {
            int actual = Summator.Sum(new int[] {2000000000, 2000000000, 2000000000 });

            Assert.AreEqual(6000000000, actual);
        }
        */

        
        [Test] //Method Average
        public void Test_Average_TwoPositiveNumbers()
        {
            int actual = Summator.Average(new int[] { 5, 7 });
            int expected = 6;

            Assert.That(expected == actual);
        }

    }
}