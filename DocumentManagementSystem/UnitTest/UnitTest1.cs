namespace UnitTest
{
    using Domain.Model;
    using Domain.Service;
    using Domain.Service.Interface;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using Utilities;
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestChangeFile()
        {
            var path = @"C:\Demo\test.txt";
            if (!File.Exists(path))
            {
                var stream = File.Create(path);
                stream.Close();
                //Directory.CreateDirectory(path);
            }
            var newfileName = DateTime.Now.ToString(Constants.DATETIMEPATERN) + "_test.txt";
            var newfilePath = Path.Combine(@"C:\Demo", newfileName);
            List<LocalFile> files = new List<LocalFile>
            {
                new LocalFile
                {
                    Name = "test.txt",
                    Path = path,
                    NewFileName = newfileName
                }
            };

            FileManager fileManager = new FileManager();
            fileManager.ChangeFileNames(files);
            Assert.IsTrue(File.Exists(newfilePath));
        }
    }
}
