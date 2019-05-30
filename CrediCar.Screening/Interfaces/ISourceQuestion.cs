using System.Collections.Generic;

namespace CrediCar.Screening.Interfaces
{
    public interface ISourceQuestion
    {
        int QuestionId { get; set; }

        IEnumerable<IChoice> Choices { get; }

        void AddChoice(IChoice choice);
    }
}
