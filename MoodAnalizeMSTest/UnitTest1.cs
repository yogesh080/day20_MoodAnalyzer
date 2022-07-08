using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalizer;
namespace MoodAnalizeMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSad()
        {
            string expected = "SAD";
            string message = " I am in a SAD Mood";
            MoodAnalizers moodAnalizer = new MoodAnalizers(message);


            string mood = moodAnalizer.AnalizeMood();

            Assert.AreEqual(expected, mood);
        }

        [TestMethod]
        //[DataRow("I am in HAPPY mood")]
        [DataRow(null)]

        public void GivenHappyMoodShouldReturnHappy(string message)
        {
            //arrenge
            string expected = "HAPPY";
            MoodAnalizers moodAnalizer = new MoodAnalizers(message);

            //act
            string mood = moodAnalizer.AnalizeMood();
            //assert
            Assert.AreEqual(expected, mood);

        }

    }
}