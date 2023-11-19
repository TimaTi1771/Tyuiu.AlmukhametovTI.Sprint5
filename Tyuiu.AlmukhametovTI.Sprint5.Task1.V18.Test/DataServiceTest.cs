using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlmukhametovTI.Sprint5.Task1.V18.Lib;
using System.IO;
using System.Diagnostics;

namespace Tyuiu.AlmukhametovTI.Sprint5.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Tim17\source\repos\Tyuiu.AlmukhametovTI.Sprint5\Tyuiu.AlmukhametovTI.Sprint5.Task1.V18\bin\Debug\OutPutFileTask1.txt";
            FileInfo frt = new FileInfo(path);
            bool fileExists = frt.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
