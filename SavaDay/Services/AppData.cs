namespace SavaDay.Services
{
    public class AppData
    {
        public int Age { get; set; }

        public const double DefaultIncrementAmount = 0.01;
        public static double IncrementAmount { get; set; } = DefaultIncrementAmount; // default value, user can change it.

        public static int RowUserDateSelection { get; set; } = 31; // days (not every to fix)
        public static int ColUserDateSelection { get; set; } = 12; // months
    }
}