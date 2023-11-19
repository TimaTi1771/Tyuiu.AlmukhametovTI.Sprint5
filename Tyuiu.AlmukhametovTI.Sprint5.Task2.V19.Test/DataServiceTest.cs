using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlmukhametovTI.Sprint5.Task2.V19.Lib;
using System.IO;

namespace Tyuiu.AlmukhametovTI.Sprint5.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\Users\Tim17\source\repos\Tyuiu.AlmukhametovTI.Sprint5\Tyuiu.AlmukhametovTI.Sprint5.Task2.V19\bin\Debug\OutPutFileTask2.csv";
            FileInfo frt = new FileInfo(path);
            bool fileExists = frt.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
