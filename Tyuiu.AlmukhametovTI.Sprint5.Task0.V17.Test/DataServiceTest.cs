using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.AlmukhametovTI.Sprint5.Task0.V17.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint5.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekedFile()
        {
            string path = @"C:\Users\Tim17\source\repos\Tyuiu.AlmukhametovTI.Sprint5\Tyuiu.AlmukhametovTI.Sprint5.Task0.V17\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
