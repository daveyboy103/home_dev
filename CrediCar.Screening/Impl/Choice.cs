using CrediCar.Screening.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CrediCar.Screening.Impl
{
    [DebuggerDisplay("{Text}"]
    public class Choice : IChoice
    {
        public string Text { get; set; }
        public string Link { get; set; }
        public double Score { get; set; }
        public int? NextQuestion { get; set; }
    }

    public class Screening : IScreening
    {
        private readonly IEnumerable<ISourceQuestion> _sourceQuestions;

        private IQuestion _currentQuestion;
        private IQuestion _previousQuestion;

        public Screening()
        {
            UniqueId = Guid.NewGuid().ToString();
            QuestionResponses = new List<IQuestion>();
        }

        public Screening(IEnumerable<ISourceQuestion> sourceQuestions)
        {
            _sourceQuestions = sourceQuestions ?? throw new ArgumentNullException(nameof(sourceQuestions));

            var questions = sourceQuestions as ISourceQuestion[] ?? sourceQuestions.ToArray();

            if (!questions.Any())
            {
                throw new InvalidOperationException("Must supply at least one question.");
            }
        }
        public string UniqueId { get; }

        public IEnumerable<IQuestion> QuestionResponses { get; }

        public double TotalScore {
            get
            {
                double score = 0;

                foreach (var questionResponse in QuestionResponses)
                {
                    foreach (var choice in questionResponse.SelectedChoices)
                    {
                        score += choice.Score;
                    }
                }

                return score;
            }
        }

        private IList<IQuestion> QuestionsAsList => (List<IQuestion>)QuestionResponses;

        public void AddQuestionResponse(IQuestion question)
        {
            throw new System.NotImplementedException();
        }

        public ISourceQuestion GetNextQuestion()
        {
            if (!QuestionResponses.Any())
            {
                return _sourceQuestions.FirstOrDefault();
            }

            return _sourceQuestions.FirstOrDefault(x => x.QuestionId == GetPreviousOrCurrentQuestion().SelectedChoices.First().NextQuestion);
        }

        private IQuestion GetPreviousOrCurrentQuestion()
        {
            if(_currentQuestion == null)
            {
                return _previousQuestion;
            }

            return _currentQuestion;
        }

        public void RemoveQuestionResponse(IQuestion question)
        {
            throw new System.NotImplementedException();
        }
    }
}
