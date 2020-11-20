using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------TEST 1a--------------");
            List<Booking> listOfRooms = new List<Booking>();
            listOfRooms.Add(Booking.makeBooking(-4, 2));
            BookingConfirmation.CheckBooking(1, listOfRooms);
            foreach (var i in listOfRooms)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------TEST 1b--------------");
            List<Booking> listOfRooms2 = new List<Booking>();
            listOfRooms2.Add(Booking.makeBooking(200, 400));
            BookingConfirmation.CheckBooking(1, listOfRooms2);
            foreach (var i in listOfRooms2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------TEST 2--------------");
            List<Booking> listOfRooms3 = new List<Booking>();
            listOfRooms3.Add(Booking.makeBooking(0, 5));
            listOfRooms3.Add(Booking.makeBooking(7, 13));
            listOfRooms3.Add(Booking.makeBooking(3, 9));
            listOfRooms3.Add(Booking.makeBooking(5, 7));
            listOfRooms3.Add(Booking.makeBooking(6, 6));
            listOfRooms3.Add(Booking.makeBooking(0, 4));
            BookingConfirmation.CheckBooking(3, listOfRooms3);
            foreach (var i in listOfRooms3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------TEST 3--------------");
            List<Booking> listOfRooms4 = new List<Booking>();
            listOfRooms4.Add(Booking.makeBooking(1, 3));
            listOfRooms4.Add(Booking.makeBooking(2, 5));
            listOfRooms4.Add(Booking.makeBooking(1, 9));
            listOfRooms4.Add(Booking.makeBooking(0, 15));
            BookingConfirmation.CheckBooking(3, listOfRooms4);
            foreach (var i in listOfRooms4)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------TEST 4--------------");
            List<Booking> listOfRooms5 = new List<Booking>();
            listOfRooms5.Add(Booking.makeBooking(1, 3));
            listOfRooms5.Add(Booking.makeBooking(0, 15));
            listOfRooms5.Add(Booking.makeBooking(1, 9));
            listOfRooms5.Add(Booking.makeBooking(2, 5));
            listOfRooms5.Add(Booking.makeBooking(4, 9));
            BookingConfirmation.CheckBooking(3, listOfRooms5);
            foreach (var i in listOfRooms5)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------TEST 5--------------");
            List<Booking> listOfRooms6 = new List<Booking>();
            listOfRooms6.Add(Booking.makeBooking(1, 3));
            listOfRooms6.Add(Booking.makeBooking(0, 4));
            listOfRooms6.Add(Booking.makeBooking(2, 3));
            listOfRooms6.Add(Booking.makeBooking(5, 5));
            listOfRooms6.Add(Booking.makeBooking(4, 10));
            listOfRooms6.Add(Booking.makeBooking(10, 10));
            listOfRooms6.Add(Booking.makeBooking(6, 7));
            listOfRooms6.Add(Booking.makeBooking(8, 10));
            listOfRooms6.Add(Booking.makeBooking(8, 9));
            BookingConfirmation.CheckBooking(2, listOfRooms6);
            foreach (var i in listOfRooms6)
            {
                Console.WriteLine(i);
            }

            //press any key to quit
            Console.ReadKey();
        }
    }
}
