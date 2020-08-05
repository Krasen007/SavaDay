namespace SavaDay.Items
{
    public static class Increment
    {
        public static double DefaultIncrementAmount { get; } = 0.01; // default value, user can change it.
        public static double IncrementAmount { get; set; } = DefaultIncrementAmount; // default value, user can change it.
    }
}