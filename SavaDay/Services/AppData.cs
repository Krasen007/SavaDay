namespace SavaDay.Services
{
    public class AppData
    {
        public int Age { get; set; } = 0;
        public double DefaultIncrementAmount { get; } = 0.01; // default value, user can change it.
        public double IncrementAmount { get; set; } = 0; // default value, user can change it.

        public AppData()
        {
            IncrementAmount = DefaultIncrementAmount;
        }
    }
}