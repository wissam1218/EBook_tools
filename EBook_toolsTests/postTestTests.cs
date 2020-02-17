using Microsoft.VisualStudio.TestTools.UnitTesting;
using EBook_tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook_tools.Tests
{
    [TestClass()]
    public class postTestTests
    {
        [TestMethod()]
        public void postTestTest()
        {
            postTest post = new postTest();
            addBtn_Click add = new addBtn_Click();


            String actual = ;
            String expected = "POST-TEST\r\n";


            Assert.AreEqual(expected, actual);




            int x = 0;
            x = 0;
           // Assert.IsTrue(x==0,"pass");
        }
    }
}