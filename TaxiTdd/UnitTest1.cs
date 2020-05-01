using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxiTdd
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FileReader fileReader = new FileReader("testData.txt");
            List<TaxiBill> list = new List<TaxiBill>();
            list.Add(new TaxiBill { Distance = 1, WaitingTime = 0 });
            list.Add(new TaxiBill { Distance = 3, WaitingTime = 0 });
            list.Add(new TaxiBill { Distance = 10, WaitingTime = 0 });
            list.Add(new TaxiBill { Distance = 2, WaitingTime = 3 });
            CollectionAssert.AreEqual(list, fileReader.GetDatas());
        }

        [DataRow(1,0,6)]
        [DataRow(3, 0, 7)]
        [DataRow(10, 0, 13)]
        [DataRow(2, 3, 7)]
        [DataTestMethod]
        [TestMethod]
        public void TestMethod2(int distance,int waitingTime,int receipt)
        {
            TaxiBill taxiBill = new TaxiBill()
            {
                Distance = distance,
                WaitingTime = waitingTime
            };
            Assert.AreEqual(receipt, taxiBill.GetReceipt());
        }
    }
}
