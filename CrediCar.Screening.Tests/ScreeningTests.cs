using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CrediCar.Screening.Tests
{
    [TestClass]
    public class ScreeningTests
    {
        [TestMethod]
        public void ShouldNewScreeningInitialiseCorrectly()
        {
            var screening = new Impl.Screening();

            var guid1 = screening.UniqueId;

            Assert.IsNotNull(guid1);

            screening = new Impl.Screening();

            var guid2 = screening.UniqueId;

            Assert.AreNotEqual(guid1, guid2);
            Assert.IsNotNull(screening.QuestionResponses);
            Assert.AreEqual(0, screening.QuestionResponses.Count());
        }
    }
}
