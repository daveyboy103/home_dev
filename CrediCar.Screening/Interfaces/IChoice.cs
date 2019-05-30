namespace CrediCar.Screening.Interfaces
{
    public interface IChoice
    {
        string Text { get; set; }

        string Link { get; set; }

        double Score { get; set; }

        int? NextQuestion { get; set; }
    }
}
