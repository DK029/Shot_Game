using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shot_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shot_Game.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        //this method is used test the constructor method of the main class 
        [TestMethod()]
        public void Form1Test()
        {
            Assert.Fail();
        }

        //this method is sued to test the reset method from the main class
        [TestMethod()]
        public void resetTest()
        {
            Form1 obj = new Form1();
            obj.reset();
        }


    }
}