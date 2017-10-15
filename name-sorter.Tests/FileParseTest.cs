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

            NameSorter namesorter = new NameSorter(fileName);
            List<String> actual = namesorter.GetNames(); //Made it so because CollectionAssert.AreEqual DOES NOT like complex classes.
            CollectionAssert.AreEqual(expected, actual, "All names have been parsed");
        }

        [TestMethod]
        public void SortedNameFileIsWritten()
        {
            NameSorter nameSorter = new NameSorter(fileName);
            nameSorter.SortNames();
            nameSorter.GenerateNames();

            if (!File.Exists(System.IO.Directory.GetCurrentDirectory() + "\\sorted-names-list.txt"))
            {
                Assert.Fail("File Does Not Exist");
            }
        }
   
    }
}
