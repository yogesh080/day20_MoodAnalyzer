using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalizer;
namespace MoodAnalizeMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSad()
        {   //Arrange
            string message = " I am in a SAD Mood";
            string expected = "SAD";
            string actual_Output;

            MoodAnalizers moodAnalizer = new MoodAnalizers(message);

            //Act
            actual_Output = moodAnalizer.AnalizeMood();

            //Assert
            Assert.AreEqual(expected, actual_Output);
        }
        [TestMethod]
        [DataRow(null)]
        public void AnalyseMood_Happytest()
        {
            //Arrange
            string message = "I am in Any Mood";
            string expected = "Happy";
            string actual_Output;

            MoodAnalizers moodAnalizer = new MoodAnalizers(message);

            //act 
            actual_Output= moodAnalizer.AnalizeMood();

            //Assert
            Assert.AreEqual(expected,actual_Output);

        }

       
        

    }
}