using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.BelovaEA.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int x = 1;
            int y = 1;
            int z = 1;

            DataService ds = new DataService();
            int res = ds.Calc(x,y,z);
            Assert.AreEqual(15, res);
        }
    }
}
