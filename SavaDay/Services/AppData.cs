namespace SavaDay.Services
{
    public class AppData
    {
        public int Age { get; set; } = 0;

        public const double DefaultIncrementAmount = 0.01;
        public static double IncrementAmount { get; set; } = DefaultIncrementAmount; // default value, user can change it.
    }
}