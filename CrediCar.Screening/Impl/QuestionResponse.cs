using CrediCar.Screening.Interfaces;
using System.Collections.Generic;

namespace CrediCar.Screening.Impl
{
    public class QuestionResponse : SourceQuestion, IQuestion
    {
        public QuestionResponse(ISourceQuestion sourceQuestion)
        {
            SourceQuestion = sourceQuestion;
        }

        public IEnumerable<IChoice> SelectedChoices => new List<IChoice>();

        public string Notes { get; set; }

        public ISourceQuestion SourceQuestion { get; private set; }

        private IList<IChoice> SelectedChoicesAsList => (IList<IChoice>)SelectedChoices;

        public void AddSelectedChoice(IChoice choice)
        {
            SelectedChoicesAsList.Add(choice);
        }
    }
}
