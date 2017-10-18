using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using name_sorter;

namespace name_sorter.Tests
{
    [TestClass]
    public class FileParseTest
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
        public void FileIsParsed()
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
        public void SortedNameFileIsWritten()
        {
            SorterProgram sorterProgram = new SorterProgram(fileName);
            sorterProgram.DoSortingWork();

            if (!File.Exists(System.IO.Directory.GetCurrentDirectory() + "\\sorted-names-list.txt"))
            {
                Assert.Fail("File Does Not Exist");
            }
        }
   
    }
}
