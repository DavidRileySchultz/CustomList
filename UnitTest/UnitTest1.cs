using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


//use unit test that tests up to 12 additions and removing then check index 0.
//minimum 25-30 tests written
//5 for add, 5 for remove, 5 for overloading +, 5 for overloading -, 5 for zip.
//this is bare minimum, should probably do more.
//goal before weekend, have tests written and add possibly remove method completed.


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Int_CheckIfCountIncreases()
        {
            //Arrange
            customList<int> test = new customList<int>();
            int expectedResult = 1;

            //Act
            test.Add(2);

            //Assert
            Assert.AreEqual(expectedResult, test.Count);
        }
        [TestMethod]
        public void Add_Int_CheckValueIndex0()
        {
            //Arrange
            customList<int> test = new customList<int>();
            int expectedResult = 2;

            //Act
            test.Add(expectedResult);

            //Assert
            Assert.AreEqual(expectedResult, test[0]);

        }
        [TestMethod]
        public void Add_Int_CheckValueIndex1()
        {
            //Arrange
            customList<int> test = new customList<int>();
            int expectedResult1 = 2;
            int expectedResult2 = 16;
            //Act
            test.Add(expectedResult1);
            test.Add(expectedResult2);
            //Assert
            Assert.AreEqual(expectedResult2, test[1]);

        }
        [TestMethod]
        public void Add_Int_CheckValueIndex0WithMultipleAdds()
        {
            //Arrange
            customList<int> test = new customList<int>();
            int expectedResult1 = 2;
            int expectedResult2 = 16;
            int expectedResult3 = 23;
            int expectedResult4 = 14;
            int expectedResult5 = 3;
            int expectedResult6 = 19;
            int expectedResult7 = 80;
            int expectedResult8 = 97;
            int expectedResult9 = 12;
            int expectedResult10 = 22;
            int expectedResult11 = 43;
            int expectedResult12 = 9;
            //Act
            test.Add(expectedResult1);
            test.Add(expectedResult2);
            test.Add(expectedResult3);
            test.Add(expectedResult4);
            test.Add(expectedResult5);
            test.Add(expectedResult6);
            test.Add(expectedResult7);
            test.Add(expectedResult8);
            test.Add(expectedResult9);
            test.Add(expectedResult10);
            test.Add(expectedResult11);
            test.Add(expectedResult12);
            
            //Assert
            Assert.AreEqual(expectedResult1, test[0]);
        }

        [TestMethod]
        public void Add_Double_CheckIfCountIncreases()
        {
            //Arrange
            customList<double> test = new customList<double>();
            int expectedResult = 1;
         
            //Act 
            test.Add(.24);

            //Assert
            Assert.AreEqual(expectedResult, test.Count);

        }

        [TestMethod]
        public void Add_Double_CheckValueIndex0()
        {
            //Arrange
            customList<double> test = new customList<double>();
            double expectedResult1 = .12;
            double expectedResult2 = 1.23;


            //Act
            test.Add(expectedResult1);
            test.Add(expectedResult2);

            //Assert
            Assert.AreEqual(expectedResult1, test[0]);
        }

        public void Add_Double_CheckValueIndex1()
        {
            //Arrange
            customList<double> test = new customList<double>();
            double expectedResult1 = .12;
            double expectedResult2 = 1.23;


            //Act
            test.Add(expectedResult1);
            test.Add(expectedResult2);

            //Assert
            Assert.AreEqual(expectedResult2, test[1]);
        }
    }
}
