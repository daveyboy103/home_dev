using System;
using System.Collections.Generic;

namespace CrediCar.Screening.Interfaces
{

    public interface IQuestionTemplate
    {
        string Name { get; set; }

        IEnumerable<ISourceQuestion> SourceQuestions { get; }
    }
}
