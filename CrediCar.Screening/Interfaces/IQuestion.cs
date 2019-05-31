using System.Collections.Generic;

namespace CrediCar.Screening.Interfaces
{
    public interface IQuestion : ISourceQuestion
    {
        IEnumerable<IChoice> SelectedChoices { get; }

        string Notes { get; set; }

        ISourceQuestion SourceQuestion { get; }

        void AddSelectedChoice(IChoice choice);
    }
}
