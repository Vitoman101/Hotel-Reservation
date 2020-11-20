using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Booking
    {
        
        private int startDay;
        private int endDay;
        public bool isBooked { get; set; }


        /// <summary>
        /// Start day, the first day guests come. Days are represented from 1 to 365
        /// </summary>
        /// <returns>Returns (INT) first day of guest visit</returns>
        public int getStartDay()
        {
            return startDay;
        }

        /// <summary>
        /// Last day of guest visit. Days are represented from 1 to 365. This value must be greater than StartDay.
        /// </summary>
        /// <returns>Returns (INT) last day of visit.</returns>
        public int getEndDay()
        {
            return endDay;
        }

        /// <summary>
        /// Static constructor, so this is only way you can make an instance of this class
        /// </summary>
        /// <param name="start">This is first day of booking. Value must be positive and less than 365</param>
        /// <param name="end">This is last day of booking. Value must be positive, greater than first day and less than 365</param>
        /// <returns>Returns instance of Booking class</returns>
        public static Booking makeBooking(int start, int end)
        {
            return new Booking(start, end);
        }

        protected Booking(int start, int end)
        {
            startDay = start;
            endDay = end;
        }

        public override string ToString()
        {
            return "Booking" + " " + getStartDay() + " " + getEndDay() + " is " + $"{(isBooked ? "ACCEPTED" : "DECLINED")}";
        }

        /// <summary>
        /// This is used to compare two objects
        /// </summary>
        /// <param name="obj">Booking object</param>
        /// <returns>returns if two objects are equal</returns>
        public override bool Equals(object obj)
        {
            var other = obj as Booking;
            if (other == null)
            {
                return false;
            }
            return startDay == other.startDay && endDay == other.endDay && isBooked == other.isBooked;
        }
    }
}
