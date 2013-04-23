// <copyright file="UnitTestExampleTest.cs">Copyright ©  2013</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting.UnitTest;
using System.Linq;

using UnitTesting.UnitTest.Moles;

namespace UnitTesting.UnitTest
{
    [TestClass]
    [PexClass(typeof(UnitTestExample))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UnitTestExampleTest
    {
        /// <summary>
        /// The TestContext Instance
        /// </summary>
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test 
        ///run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [PexMethod] //Parameterized Unit Testing using PEX
        public string Capitalize(string value)
        {
            string result = UnitTestExample.Capitalize(value);
            return result;
            // TODO: add assertions to method UnitTestExampleTest.Capitalize(String)
        }


        [PexMethod] //Parameterized Unit Testing with Assertion using PEX
        public void CapitalizeMaintainsLettersCount(string input)
        {
            string output = UnitTestExample.Capitalize(input);
            PexAssert.AreEqual(
            LettersCount(input),
            LettersCount(output));
        }

        [PexMethod] //Parameterized Unit Testing with Assertion using PEX
        public void CapitalizeWillNotCapitalizeAgain(string input)
        {
            string capitalized = UnitTestExample.Capitalize(input);
            string capitalizedAgain = UnitTestExample.Capitalize(capitalized);
            PexAssert.AreEqual(capitalized, capitalizedAgain);
        }

        [PexMethod] //Parameterized Unit Testing with Assertion using PEX
        public void CapitalizeReturnsOnlyLettersAndUnderscores(string input)
        {
            string output = UnitTestExample.Capitalize(input);
            PexAssert.TrueForAll(output, IsLetterOrUnderscore);
        }

        [PexMethod, PexAllowedException(typeof(InvalidOperationException))] //Stub Type Mocking
        public void GetFileContentUsingInterface(string fileName)
        {
            //Arrange
            var Ifs = new SIFileSystem();
            Ifs.ReadAllTextString = fName =>
            {
                if (fName == null)
                    throw new InvalidOperationException("File Name Can't be NULL");
                else if (fName.Length == 0)
                    throw new InvalidOperationException("Length of File Name Can't be Zero");
                else
                    return fName;
            };

            //Act
            var test = new UnitTestExample(Ifs);
            string result = test.GetFileContentUsingInterface(fileName);

            //Assert
            PexAssert.AreEqual(fileName, result);

        }

        [PexMethod, PexAllowedException(typeof(InvalidOperationException))] //Mole Type Mocking
        public void GetFileContent(string fileName)
        {
            //Arrange
            MFileSystem.AllInstances.ReadAllTextString = (fs, fName) =>
            {
                if (fName == null)
                    throw new InvalidOperationException("File Name Can't be NULL");
                else if (fName.Length == 0)
                    throw new InvalidOperationException("Length of File Name Can't be Zero");
                else
                    return fName;
            };

            //Act
            string result = UnitTestExample.GetFileContent(fileName);

            //Assert
            PexAssert.AreEqual(fileName, result);

        }

        private static int LettersCount(string s)
        {
            return Enumerable.Count(s, char.IsLetter);
        }       

        private static bool IsLetterOrUnderscore(char c)
        {
            return char.IsLetter(c) || c == '_';
        }

        [DeploymentItem("UnitTesting.Tests\\TestData\\AddData.csv"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\AddData.csv", "AddData#csv", DataAccessMethod.Sequential)]
        public void TestAddMethod()
        {            
            int outputActual = UnitTestExample.Add(Convert.ToInt32(TestContext.DataRow["Int1"].ToString()), Convert.ToInt32(TestContext.DataRow["Int2"].ToString()));
            int outputExpected = Convert.ToInt32(TestContext.DataRow["Output"].ToString());
            Assert.AreEqual<int>(outputExpected, outputActual, "Failed unit test for int1 = {0}, int2 = {1}. Output Expected = {2} , Output Actual = {3}", TestContext.DataRow["Int1"].ToString(), TestContext.DataRow["Int2"].ToString(), TestContext.DataRow["Output"].ToString(), outputActual.ToString());
        }
    }
}
