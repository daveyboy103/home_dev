using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldConstructorGuardAgainstNull()
        {
            new Impl.Screening(null);
        }

        [TestMethod]
        public void ShouldRemoveChildResponsesWhenQuestionRemoved()
        {
            var sourceQuestions = DataFactory.GetSourceQuestions();

            var screening = new Impl.Screening(sourceQuestions);

            var firstQuestion = screening.GetNextQuestion();

            Assert.IsNotNull(firstQuestion);
            Assert.AreEqual(1, firstQuestion.QuestionId);

            var firstQuestionResponse = new Impl.QuestionResponse(firstQuestion)
            {
                QuestionId = firstQuestion.QuestionId
            };

            firstQuestionResponse.AddChoice(firstQuestion.Choices.FirstOrDefault(x => x.Text == "European"));
            screening.AddQuestionResponse(firstQuestionResponse);

            var nextQuestion = screening.GetNextQuestion();
            Assert.IsNotNull(nextQuestion);
            Assert.AreEqual(4, nextQuestion.QuestionId);
            Assert.AreEqual(3, nextQuestion.Choices.Count());
            Assert.AreEqual("French", nextQuestion.Choices.FirstOrDefault().Text);
            Assert.AreEqual("Spanish", nextQuestion.Choices.FirstOrDefault().Text);
        }
    }
}
