using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddingTwoNumbers;

namespace AddingTwoNumbersUnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //set
            int numb1 = 2;
            int numb2 = 3;
            int ExcpectedSum = 0;
             ExcpectedSum += numb1 + numb2;

            ///act
            var addtwomubers = new Add(numb1, numb2);
           var ActualSum = addtwomubers.AddTwoNumbers();


            //Assert
            Assert.AreEqual(ExcpectedSum,ActualSum);
                       
        }
    }
}
