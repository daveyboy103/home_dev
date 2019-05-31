using CrediCar.Screening.Interfaces;
using System.Collections.Generic;

namespace CrediCar.Screening.Impl
{
    public class SourceQuestion : ISourceQuestion
    {
        public int QuestionId { get; set; }

        public IEnumerable<IChoice> Choices => new List<IChoice>();

        private IList<IChoice> ChoicesAsList => (IList <IChoice>) Choices;

        public void AddChoice(IChoice choice)
        {
            ChoicesAsList.Add(choice);;
        }
    }
}
