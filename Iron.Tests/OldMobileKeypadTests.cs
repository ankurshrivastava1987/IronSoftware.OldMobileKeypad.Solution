using Xunit;
using Iron.OldMobileKeypad.Services;

namespace Iron.Tests
{
    public class OldMobileKeypadTests
    {
         OldMobileKeyPadService oldMobileKeyPad = new OldMobileKeyPadService();

        [Fact]
        public void OldKeypadSampleText1()
        {
            //Arrange
            string sampleText = "33#";

            //Expectedoutput
            string expectedOutput = "E";

            //Act
            string actualOutput = oldMobileKeyPad.ReplaceOldKeypadInputToChar(sampleText);

            //Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void OldKeypadSampleText2()
        {
            //Arrange
            string sampleText = "227*#";

            //Expectedoutput
            string expectedOutput = "B";

            //Act
            string actualOutput = oldMobileKeyPad.ReplaceOldKeypadInputToChar(sampleText);

            //Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

       
        [Fact]
        public void OldKeypadSampleText3()
        {
            //Arrange
            string sampleText2 = "4433555 555666#";

            //Expectedoutput
            string expectedOutput = "HELLO";

            //Act
            string actualOutput = oldMobileKeyPad.ReplaceOldKeypadInputToChar(sampleText2);

            //Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void OldKeypadSampleText4()
        {
            //Arrange
            string sampleText = "8 88777444666*664#";

            //Expectedoutput
            string expectedOutput = "TURINNG";

            //Act
            string actualOutput = oldMobileKeyPad.ReplaceOldKeypadInputToChar(sampleText);

            //Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

    }
}
