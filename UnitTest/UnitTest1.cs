﻿using System;
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
            CustomList<int> test = new CustomList<int>();
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
            CustomList<int> test = new CustomList<int>();
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
            CustomList<int> test = new CustomList<int>();
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
        public void Remove_Int_CheckIfIntRemoved()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            int expectedResult = 4;
            
            //Act
            test.Remove(3);
            int actualResult = test[2];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_CheckAtIndex0()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            int expectedResult = 2;

            //Act
            test.Remove(1);
            int actualResult = test[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Remove_CheckIfRemovesFirst()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            int expectedResult = 4;


            //Act
            test.Remove(3);
            int actualResult = test[2]

            //Assert
            Assert.AreEqual(expectedResult, actualResult)


        }

        [TestMethod]
        public void Remove_CheckIfCountDecreases()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>;
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            int expectedResult = 3;
            //Act
            test.Remove(1);
            int actualResult = test.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Remove_CheckIfListShifts()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);

            int expectedResult = 7;
            //Act
            test.Remove(3);
            int actualResult = test.Count;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
           [TestMethod]
           public void OverLoad+_CheckIf

    }
}
