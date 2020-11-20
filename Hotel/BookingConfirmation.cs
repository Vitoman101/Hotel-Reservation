using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public static class BookingConfirmation
    {
        /// <summary>
        /// This is function that will check if the booking dates are more than 0 and less than 365
        /// </summary>
        /// <param name="book">Use instance of Booking class</param>
        /// <returns></returns>
        private static bool isValidBookingDate(Booking book)
        {
            if (book.getEndDay() < book.getStartDay())
            {
                return false;
            }
            else if (book.getStartDay() < 0 || book.getEndDay() < 0)
            {
                return false;
            }
            else if (book.getStartDay() > 365 || book.getEndDay() > 365)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Method that checks if booking is possible or not
        /// </summary>
        /// <param name="numberOfRooms">Give number of avaliable rooms</param>
        /// <param name="bookings">List of bookings</param>
        public static void CheckBooking(int numberOfRooms, List<Booking> bookings)
        {
            //number of days in year
            int[] test = new int[365];

            foreach (var booking in bookings)
            {
                bool DECLINED = false;
                if (isValidBookingDate(booking))
                {
                    for (int a = booking.getStartDay(); a <= booking.getEndDay(); a++)
                    {
                        //before filling in days, this loop checks if its possible to book on those dates
                        if (test[a] + 1 > numberOfRooms)
                        {
                            booking.isBooked = false;
                            DECLINED = true;
                            break;
                        }
                    }
                    if (!DECLINED)
                    {
                        //if its possible to book it, booking days happens here
                        for (int a = booking.getStartDay(); a <= booking.getEndDay(); a++)
                        {
                            test[a] += 1;
                        }
                        booking.isBooked = true;
                    }
                }
                else
                {
                    booking.isBooked = false;
                }
            }
        }
    }
}
