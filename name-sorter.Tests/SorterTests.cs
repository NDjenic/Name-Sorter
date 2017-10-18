using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using name_sorter;

namespace name_sorter.Tests
{

    [TestClass]
    public class SorterTests
    {
        String fileName = System.IO.Directory.GetCurrentDirectory() + "\\unsorted-names-list.txt";

        private List<String> GetNames(bool sort)
        {
            SorterProgram sorterProgram = new SorterProgram(fileName);
            if (sort)
            {
                sorterProgram.DoSortingWork();
            }
            else
            {
                sorterProgram.JustParseNames();
            }
            return sorterProgram.GetNames(); //Made it so because CollectionAssert.AreEqual DOES NOT like complex classes.
        }

        [TestMethod]
        public void SameNumberOfNames()
        {
            //CollectionAssert.AreEquivalent
            int expectedCount = 11;
            int actualCount = this.GetNames(false).Count; //Made it so because CollectionAssert.AreEqual DOES NOT like complex classes.
            Assert.AreEqual(expectedCount, actualCount, "Actual count (" + actualCount + ") matches expected count (" + expectedCount + ")");
        }

        [TestMethod]
        public void AllNamesAreThereButNotSorted()
        {
            List<String> expected = new List<String>
            {
                "Janet Parsons",
                "Vaughn Lewis",
                "Adonis Julius Archer",
                "Shelby Nathan Yoder",
                "Marin Alvarez",
                "London Lindsey",
                "Beau Tristan Bentley",
                "Leo Gardner",
                "Hunter Uriah Mathew Clarke",
                "Mikayla Lopez",
                "Frankie Conner Ritter",
            };

            List<String> actual = this.GetNames(false);
            CollectionAssert.AreEqual(expected, actual, "All names have been parsed");
        }

        [TestMethod]
        public void AllNamesShouldBeAlphabeticallySorted()
        {
            //Arrange
            List<String> expected = new List<String>
            {
                "Marin Alvarez",
                "Adonis Julius Archer",
                "Beau Tristan Bentley",
                "Hunter Uriah Mathew Clarke",
                "Leo Gardner",
                "Vaughn Lewis",
                "London Lindsey",
                "Mikayla Lopez",
                "Janet Parsons",
                "Frankie Conner Ritter",
                "Shelby Nathan Yoder"
            };

            //Act
            List<String> actual = this.GetNames(true);

            CollectionAssert.AreEqual(expected, actual, "All names have been parsed and ordered alphabetically");
        }
    }
}
