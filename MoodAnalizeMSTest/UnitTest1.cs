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
    }
}