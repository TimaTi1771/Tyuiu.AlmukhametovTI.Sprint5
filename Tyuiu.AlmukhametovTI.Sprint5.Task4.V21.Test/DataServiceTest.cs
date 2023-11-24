using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlmukhametovTI.Sprint5.Task4.V21.Lib;
using System.IO;


namespace Tyuiu.AlmukhametovTI.Sprint5.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V21.txt";

            FileInfo frt = new FileInfo(path);
            bool fileExists = frt.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
