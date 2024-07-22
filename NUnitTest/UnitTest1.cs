using OldPhonePadLibrary;

namespace NUnitTest
{
    public class UnitTest1
    {
        private OldPhonePadFunction _oldPhonePadFunction;

        [SetUp]
        public void Setup()
        {
            _oldPhonePadFunction = new OldPhonePadFunction();

        }


        [Test]
        public void TestFor_E()
        {
            string inputDigits = "33#";
            string expectedOutput = "E";

            // Act
            string actualOutput = OldPhonePadFunction.OldPhonePad(inputDigits);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput); ;
        }

        [Test]
        public void TestFor_B()
        {
            string inputDigits = "227*#";
            string expectedOutput = "B";

            // Act
            string actualOutput = OldPhonePadFunction.OldPhonePad(inputDigits);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput); ;
        }



        [Test]
        public void TestFor_KJNU()
        {
            string inputDigits = "55 5669999*88";
            string expectedOutput = "KJNU";

            // Act
            string actualOutput = OldPhonePadFunction.OldPhonePad(inputDigits);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput); ;
        }


        [Test]
        public void TestFor_I_AM_THE_BEST()
        {
            string inputDigits = "444026088*8444*44330223377778#";
            string expectedOutput = "I AM THE BEST";

            // Act
            string actualOutput = OldPhonePadFunction.OldPhonePad(inputDigits);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput); ;
        }

        [Test]
        public void TestFor_HELLO()
        {
            string inputDigits = "4433555 555666#";
            string expectedOutput = "HELLO";

            // Act
            string actualOutput = OldPhonePadFunction.OldPhonePad(inputDigits);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput); ;
        }


        [Test]
        public void TestFor_NewInput()
        {
            string inputDigits = "8 88777444666*664#";
            string expectedOutput = "TURING";

            // Act
            string actualOutput = OldPhonePadFunction.OldPhonePad(inputDigits);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput); ;
        }
        


    }
}