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
            string sampleText1 = "227*#";

            //Expectedoutput
            string expectedOutput = "B";

            //Act
            string actualOutput = oldMobileKeyPad.ReplaceOldKeypadInputToChar(sampleText1);

            //Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void OldKeypadSampleText2()
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
    }
}
