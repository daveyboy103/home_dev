using CrediCar.Screening.Interfaces;
using System.Collections.Generic;

namespace CrediCar.Screening.Tests
{
    public static class DataFactory
    {
        public static IEnumerable<ISourceQuestion> GetSourceQuestions()
        {
            var ret = new List<ISourceQuestion>();

            var sourceQuestion = new Impl.SourceQuestion { QuestionId = 1 };
            var choice = new Impl.Choice { Text = "Asian", NextQuestion = 2 };
            sourceQuestion.AddChoice(choice);
            choice = new Impl.Choice { Text = "American", NextQuestion = 3 };
            sourceQuestion.AddChoice(choice);
            choice = new Impl.Choice { Text = "European", NextQuestion = 4, Score = 12 };
            sourceQuestion.AddChoice(choice);
            choice = new Impl.Choice { Text = "Not Hungry", NextQuestion =6, Score = -999 };
            sourceQuestion.AddChoice(choice);
            ret.Add(sourceQuestion);

            sourceQuestion = new Impl.SourceQuestion { QuestionId = 2 };
            choice = new Impl.Choice { Text = "Japanese" };
            sourceQuestion.AddChoice(choice);
            choice = new Impl.Choice { Text = "Chinese" };
            sourceQuestion.AddChoice(choice);
            choice = new Impl.Choice { Text = "Thai", };
            sourceQuestion.AddChoice(choice);
            ret.Add(sourceQuestion);

            sourceQuestion = new Impl.SourceQuestion { QuestionId = 3 };
            choice = new Impl.Choice { Text = "TexMex" };
            sourceQuestion.AddChoice(choice);
            choice = new Impl.Choice { Text = "New York" };
            sourceQuestion.AddChoice(choice);
            choice = new Impl.Choice { Text = "Cajun", };
            sourceQuestion.AddChoice(choice);
            ret.Add(sourceQuestion);

            sourceQuestion = new Impl.SourceQuestion { QuestionId = 4 };
            choice = new Impl.Choice { Text = "French" };
            sourceQuestion.AddChoice(choice);
            choice = new Impl.Choice { Text = "Italian", NextQuestion = 5, Score = 5 };
            sourceQuestion.AddChoice(choice);
            choice = new Impl.Choice { Text = "Spanish", };
            sourceQuestion.AddChoice(choice);
            ret.Add(sourceQuestion);

            sourceQuestion = new Impl.SourceQuestion { QuestionId = 5 };
            choice = new Impl.Choice { Text = "Pizza" , Score = 8};
            sourceQuestion.AddChoice(choice);
            choice = new Impl.Choice { Text = "Pasta", Score = 2 };
            sourceQuestion.AddChoice(choice);
            ret.Add(sourceQuestion);

            sourceQuestion = new Impl.SourceQuestion { QuestionId = 6 };
            choice = new Impl.Choice { Text = "Bye Then" , Score = -999};
            sourceQuestion.AddChoice(choice);
            ret.Add(sourceQuestion);

            return ret;
        }
    }
}
