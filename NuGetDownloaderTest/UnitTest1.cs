using System;
using NugetWorker;
using NUnit.Framework;

namespace NuGetDownloaderTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("SetUp Initiated....");
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("Hello !! Please enter Package Name to download.");
           
        }


        [Test]
        public void Test2()
        {
            Console.WriteLine("Hello !!");

        }



        [TearDown]
        public void Finish()
        {
            Console.WriteLine("TearDown Initiated....");
        }
    }
}