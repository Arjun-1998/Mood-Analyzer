using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()

        {
        
                //Arrange
                string expected = "SAD";
                string message = "I am in Sad Mood";
                MoodStatus moodAnalyse = new MoodStatus(message);

                //Act
                string mood = moodAnalyse.AnalyseMood();

                //Assert
                Assert.AreEqual(expected, mood);
            
        }
    }
}
    
