using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AlmukhametovTI.Sprint5.Task7.V9.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint5.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V9.txt";

            FileInfo frt = new FileInfo(path);
            bool fileExists = frt.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
