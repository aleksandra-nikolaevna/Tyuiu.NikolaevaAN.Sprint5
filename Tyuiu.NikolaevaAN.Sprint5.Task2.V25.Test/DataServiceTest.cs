﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.NikolaevaAN.Sprint5.Task2.V25.Lib;

namespace Tyuiu.NikolaevaAN.Sprint5.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Николаевы\source\repos\c#\Tyuiu.NikolaevaAN.Sprint5\Tyuiu.NikolaevaAN.Sprint5.Task2.V25\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
