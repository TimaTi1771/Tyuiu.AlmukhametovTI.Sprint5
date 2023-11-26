using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AlmukhametovTI.Sprint5.Task6.V11.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint5.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V11.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 3;
            Assert.AreEqual(wait, res);                      
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V11.txt";

            FileInfo frt = new FileInfo(path);
            bool fileExists = frt.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
