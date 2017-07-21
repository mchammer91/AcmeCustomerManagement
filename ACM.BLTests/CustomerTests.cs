using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    using ACM.BL;

    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CalculatePercentOfGoalsStepsTestValid()
        {
            // arrange
            Customer customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "2000";
            decimal expected = 40M;

            // act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalsStepsTestValidAreEqual()
        {
            // arrange
            Customer customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "5000";
            decimal expected = 100M;

            // act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalsStepsTestValidActualIsZero()
        {
            // arrange
            Customer customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "0";
            decimal expected = 0M;

            // act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // assert
            Assert.AreEqual(expected, actual);
        }

    }
}
