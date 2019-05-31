using CrediCar.Screening.Interfaces;
using System.Diagnostics;

namespace CrediCar.Screening.Impl
{
    [DebuggerDisplay("{Text}")]
    public class Choice : IChoice
    {
        public string Text { get; set; }
        public string Link { get; set; }
        public double Score { get; set; }
        public int? NextQuestion { get; set; }
    }
}
