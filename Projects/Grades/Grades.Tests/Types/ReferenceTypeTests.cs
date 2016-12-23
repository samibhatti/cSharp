using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    
    [TestClass]
    public class TypeTests //ReferenceTypeTests
    {

        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);

        }

        private void AddGrades(float[] grades)
        {
            //grades = new float[5]; test will fail, as it creates a new array and placed the value 89.1f on position 1. the assert is still pointing to original array.
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "scott";
            name = name.ToUpper();

            Assert.AreEqual("SCOTT", name);
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            //date.AddDays(1); //will fail the test as 
            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }
        [TestMethod]
        public void ValueTypesPAssByValue()
        {
            int x = 46;
            IncrementNumber(x);

            Assert.AreEqual(46, x);
        }

        private void IncrementNumber(int number)
        {
            number += 1;
            number = 0;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(ref book1);
            Assert.AreEqual("A GradeBook", book1.Name);
        }

        private void GiveBookAName(ref GradeBook book)
        {
            book = new GradeBook(); //writing new value to book2 that do not influence book1, book1 is still pointing to original GradeBook.
            book.Name = "A GradeBook";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Scott";
            string name2 = "scott";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            //x1 = 4;
            Assert.AreEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            g1 = new GradeBook();
            g1.Name = "Scott grade book";
            Assert.AreNotEqual(g1.Name, g2.Name);
        }

    }
}
