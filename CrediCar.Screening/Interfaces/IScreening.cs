using System.Collections.Generic;

namespace CrediCar.Screening.Interfaces
{
    public interface IScreening
    {
        string UniqueId { get; }

        IEnumerable<IQuestion> QuestionResponses { get; }

        double TotalScore { get;  }

        void AddQuestionResponse(IQuestion question);

        void RemoveQuestionResponse(IQuestion question);

        ISourceQuestion GetNextQuestion();
    }
}
