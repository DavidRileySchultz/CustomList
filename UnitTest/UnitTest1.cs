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
            CustomList<int> test = new CustomList<int>();
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
        public void Add_CheckIfIndex0SameAfterAddingInAdditonal()
        {

            //Arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(5);
            test.Add(6);
            test.Add(7);
            test.Add(8);
            test.Add(9);
            test.Add(10);
            test.Add(11);
            test.Add(12);
            int expectedResult = 1;

            //Act
            test.Add(13);
            int actualResult = test[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
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
            int actualResult = test[2];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }

        [TestMethod]
        public void Remove_CheckIfCountDecreases()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
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
        public void Remove_CheckNonExistantValueAtLastIndex()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test1.Add(4);
            test1.Add(5);
           
            int expectedResult = 5;

            //Act
            test1.Remove(8);
            int actualResult = test1[4];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Remove_CheckNonExistantValueCount()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test1.Add(4);
            test1.Add(5);

            int expectedResult = 5;

            //Act
            test1.Remove(8);
            int actualResult = test1.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [TestMethod]
        public void Overload_Plus_CheckIfListsCombineAtIndex3()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test2.Add(4);
            test2.Add(5);
            test2.Add(6);
            

            int expectedResult = 4;

            //Act


            CustomList<int> actualResult = test1 + test2;

            //Assert
            Assert.AreEqual(expectedResult, actualResult[3]);

        }
        [TestMethod]
        public void Overload_Plus_CheckIfListsCombineCount()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test1.Add(4);
            test2.Add(5);
            test2.Add(6);
            test2.Add(7);
            test2.Add(8);            

            int expectedResult = 8;

            //Act


            CustomList<int> actualResult = test1 + test2;

            //Assert
            Assert.AreEqual(expectedResult, actualResult.Count);

        }

        [TestMethod]
        public void Overload_Plus_CheckIfListsCombineAllIndexes()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test2.Add(5);
            test2.Add(6);
            test2.Add(7);
            
            //Act

            CustomList<int> actualResult = test1 + test2;

            //Assert
            Assert.AreEqual(test1[0], actualResult[0]);
            Assert.AreEqual(test1[1], actualResult[1]);
            Assert.AreEqual(test1[2], actualResult[2]);
            Assert.AreEqual(test2[0], actualResult[3]);
            Assert.AreEqual(test2[1], actualResult[4]);
            Assert.AreEqual(test2[2], actualResult[5]);
            

        }
        
        [TestMethod]
        public void Overload_Plus_CheckIfSingleIndexStringCombine()
        {
            //Arrange
            CustomList<string> test1 = new CustomList<string>();
            CustomList<string> test2 = new CustomList<string>();

            test1.Add("Hello");
            test2.Add("World");
            
            
            //Act
            CustomList<string> actualResult = test1 + test2;


            //Assert
            Assert.AreEqual(test1[0], actualResult[0]);
            Assert.AreEqual(test2[0], actualResult[1]);
            
        }

        [TestMethod]
        public void Overload_Plus_CheckIfSingleIndexIntCombine()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();

            test1.Add(2);
            test2.Add(5);


            //Act
            CustomList<int> actualResult = test1 + test2;


            //Assert
            Assert.AreEqual(test1[0], actualResult[0]);
            Assert.AreEqual(test2[0], actualResult[1]);

        }
        
        [TestMethod]
        public void Overload_Minus_CheckIfListsSubtractWith1IndexCount()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            
            test1.Add(1);
            test2.Add(1);

            int expectedResult = 0;


            //Act
            CustomList<int> actualResult = test1 - test2;

            //Assert
            Assert.AreEqual(expectedResult, actualResult.Count);
        }

        [TestMethod]
        public void Overload_Minus_CheckIfListsSubtractAtIndex0()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();

            test1.Add(1);
            test2.Add(1);

            int expectedResult = 0;


            //Act
            CustomList<int> actualResult = test1 - test2;

            //Assert
            Assert.AreEqual(expectedResult, actualResult[0]);
        }

        [TestMethod]
        public void Overload_Minus_CheckIfSubtractsMultipleCount()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();

            test1.Add(1);
            test1.Add(14);
            test1.Add(6);
            test1.Add(3);
            test1.Add(22);
            test2.Add(1);
            test2.Add(3);
            test2.Add(6);
            test2.Add(14);

            int expectedResult = 1;

            //Act
            CustomList<int> actualResult = test1 - test2;

            //Assert
            Assert.AreEqual(expectedResult, actualResult.Count);

        }
        [TestMethod]
        public void Overload_Minus_CheckIfSubtractsMultipleAtIndex0()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();

            test1.Add(1);
            test1.Add(14);
            test1.Add(6);
            test1.Add(3);
            test1.Add(22);
            test2.Add(1);
            test2.Add(3);
            test2.Add(6);
            test2.Add(14);

            int expectedResult = 22;
            //Act
            CustomList<int> actualResult = test1 - test2;

            //Assert
            Assert.AreEqual(expectedResult, actualResult[0]);

        }
        [TestMethod]
        public void Overload_Minus_CheckIfListsSubtractStringCount()
        {
            //Arrange
            CustomList<string> test1 = new CustomList<string>();
            CustomList<string> test2 = new CustomList<string>();

            test1.Add("Hello");
            test2.Add("World");

            int expectedResult = 1;


            //Act
            CustomList<string> actualResult = test1 - test2;

            //Assert
            Assert.AreEqual(expectedResult, actualResult.Count);
        }
    }
}
