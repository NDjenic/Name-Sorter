using System;
using System.Collections.Generic;
using System.Text;
using name_sorter;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace name_sorter.Tests
{
    [TestClass]
    public class NameTests
    {
        [TestMethod]
        public void NameIsCorrect()
        {
            String testName = "Rooney Manfull Guerrero Castorina";
            Name newName = new Name(testName); 
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNameException), "Name has too many given name elements")]
        public void NameIsIncorrectTooLong()
        {
            String testName = "Rooney Manfull Guerrero Castorina Illenaro";
            Name newName = new Name(testName);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNameException), "Name has no surname/is too short")]
        public void NameIsIncorrectTooShort()
        {
            String testName = "Rooney";
            Name newName = new Name(testName);
        }
    }
}
