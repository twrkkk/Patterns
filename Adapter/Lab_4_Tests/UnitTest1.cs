using laba_4.Adapters;
using laba_4.Interfaces;
using laba_4.Realizations;

namespace Laba_4_Tests
{
    [TestFixture]
    public class PersonAdapterTests
    {
        [Test]
        public void PrintInitialsAndAge_PrintsCorrectly()
        {
            IPersonInfo personInfo = new Person("John Doe", new DateTime(1990, 5, 15));
            IAgeInfo ageInfo = new PersonAdapter(personInfo);
            string expectedOutput = "Initials: JD, Age: 34";

            var actualOutput = ageInfo.PrintInitialsAndAge();

            Assert.That(expectedOutput, Is.EqualTo(actualOutput));
        }
    }
}

