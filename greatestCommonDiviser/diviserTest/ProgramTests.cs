using Microsoft.VisualStudio.TestTools.UnitTesting;
using greatestCommonDiviser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greatestCommonDiviser.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        // full testing documentation at https://docs.google.com/document/d/1_BSmvXBNifrJA0DAPVz0RLJbs-tf0k5k22BI4v5wqew/edit?usp=sharing

        [TestMethod()]
        public void InputToDivisorTestA()
        {
            Assert.AreEqual(Program.InputToDivisor(""), "Sorry, it doesn't look like you entered two integers.");
        }
        [TestMethod()]
        public void InputToDivisorTestB()
        {
            Assert.AreEqual(Program.InputToDivisor("3"), "Sorry, it doesn't look like you entered two integers.");
        }
        [TestMethod()]
        public void InputToDivisorTestC()
        {
            Assert.AreEqual(Program.InputToDivisor("2 4 6"), "Sorry, it doesn't look like you entered two integers.");
        }
        [TestMethod()]
        public void InputToDivisorTestD()
        {
            Assert.AreEqual(Program.InputToDivisor("ha ha"), "Sorry, it doesn't look like you entered two integers.");
        }
        [TestMethod()]
        public void InputToDivisorTestE()
        {
            Assert.AreEqual(Program.InputToDivisor("6 6"), "The greatest common divisor of 6 and 6 is 6.");
        }
        [TestMethod()]
        public void InputToDivisorTestF()
        {
            Assert.AreEqual(Program.InputToDivisor("10 15"), "The greatest common divisor of 10 and 15 is 5.");
        }
        [TestMethod()]
        public void InputToDivisorTestG()
        {
            Assert.AreEqual(Program.InputToDivisor("-22 16"), "The greatest common divisor of -22 and 16 is 2.");
        }

    }
}