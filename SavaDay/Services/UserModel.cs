using System;
using System.ComponentModel.DataAnnotations;

namespace SavaDay.Services
{
    public class UserModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string Name { get; set; } = "";

        public DateTime Date { get; set; } = DateTime.Now;
        public double TotalAmount { get; set; }

        public int StartDay { get; set; } = Constants.StartDayDefault;
        public int EndDay { get; set; } = DateTime.Today.Day;

        public string TotalDaysText { get; set; } = "Click calculate";
        public double BeginAmount { get; set; }

        public void CalculateAmount()
        {
            double moneyTotal;
            int totalDays;

            // Clears amount if user press calculate multiple times.
            this.TotalAmount = 0;
            moneyTotal = this.BeginAmount - AppData.IncrementAmount; // Increases the amount per day with the given begin amount

            // Check if input is not logical
            if (this.EndDay <= this.StartDay)
            {
                this.EndDay = this.StartDay;
            }

            totalDays = this.EndDay - this.StartDay;

            for (int i = 0; i <= totalDays; i++)
            {
                moneyTotal += AppData.IncrementAmount;
                this.TotalAmount += moneyTotal;
            }

            this.TotalDaysText = (totalDays + 1 /* Accounts for dates like start 1 end 2 = should be 2 days */).ToString();
        }

        public double CalcOnlyAmount(int startDay, int endDay)
        {
            double moneyTotal;
            int totalDays;

            // Clears amount if user press calculate multiple times.
            double totalAmount = 0;
            moneyTotal = this.BeginAmount - AppData.IncrementAmount; // Increases the amount per day with the given begin amount

            // Check if input is not logical
            if (endDay <= startDay)
            {
                endDay = startDay;
            }

            totalDays = endDay - startDay;

            for (int i = 0; i <= totalDays; i++)
            {
                moneyTotal += AppData.IncrementAmount;
                totalAmount += moneyTotal;
            }

            return totalAmount;
        }

        public void Reset()
        {
            this.TotalAmount = 0;
            this.TotalDaysText = "Click calculate";

            this.StartDay = Constants.StartDayDefault;
            this.EndDay = DateTime.Today.Day;
            this.BeginAmount = 0;
        }
    }
}