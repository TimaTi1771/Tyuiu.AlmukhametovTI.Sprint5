using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlmukhametovTI.Sprint5.Task5.V1.Lib;
using System.IO;

namespace Tyuiu.AlmukhametovTI.Sprint5.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V1.txt";

            FileInfo frt = new FileInfo(path);
            bool fileExists = frt.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
