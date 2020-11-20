using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hotel;
using System.Collections.Generic;

namespace HotelTest
{
    [TestClass]
    public class HotelTest
    {
        [TestMethod]
        public void Test1a()
        {

            List<Booking> actual = new List<Booking>();
            actual.Add(Booking.makeBooking(-4, 2));
            BookingConfirmation.CheckBooking(1, actual);

            List<Booking> expected = new List<Booking>();
            expected.Add(Booking.makeBooking(-4, 2));
            expected[0].isBooked = false;


            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test1b()
        {

            List<Booking> actual = new List<Booking>();
            actual.Add(Booking.makeBooking(200, 400));
            BookingConfirmation.CheckBooking(1, actual);

            List<Booking> expected = new List<Booking>();
            expected.Add(Booking.makeBooking(200, 400));
            expected[0].isBooked = false;


            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2()
        {

            List<Booking> actual = new List<Booking>();
            actual.Add(Booking.makeBooking(0, 5));
            actual.Add(Booking.makeBooking(7, 13));
            actual.Add(Booking.makeBooking(3, 9));
            actual.Add(Booking.makeBooking(5, 7));
            actual.Add(Booking.makeBooking(6, 6));
            actual.Add(Booking.makeBooking(0, 4));
            BookingConfirmation.CheckBooking(3, actual);

            List<Booking> expected = new List<Booking>();
            expected.Add(Booking.makeBooking(0, 5));
            expected.Add(Booking.makeBooking(7, 13));
            expected.Add(Booking.makeBooking(3, 9));
            expected.Add(Booking.makeBooking(5, 7));
            expected.Add(Booking.makeBooking(6, 6));
            expected.Add(Booking.makeBooking(0, 4));

            //all items accepted test
            foreach (var i in expected)
            {
                i.isBooked = true;
            }

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test3()
        {

            List<Booking> actual = new List<Booking>();
            actual.Add(Booking.makeBooking(1, 3));
            actual.Add(Booking.makeBooking(2, 5));
            actual.Add(Booking.makeBooking(1, 9));
            actual.Add(Booking.makeBooking(0, 15));
            BookingConfirmation.CheckBooking(3, actual);

            List<Booking> expected = new List<Booking>();
            expected.Add(Booking.makeBooking(1, 3));
            expected.Add(Booking.makeBooking(2, 5));
            expected.Add(Booking.makeBooking(1, 9));
            expected.Add(Booking.makeBooking(0, 15));
            
            foreach(var i in expected)
            {
                i.isBooked = true;
            }

            //last item declined test
            expected[expected.Count-1].isBooked = false;

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test4()
        {

            List<Booking> actual = new List<Booking>();
            actual.Add(Booking.makeBooking(1, 3));
            actual.Add(Booking.makeBooking(0, 15));
            actual.Add(Booking.makeBooking(1, 9));
            actual.Add(Booking.makeBooking(2, 5));
            actual.Add(Booking.makeBooking(4, 9));
            BookingConfirmation.CheckBooking(3, actual);

            List<Booking> expected = new List<Booking>();
            expected.Add(Booking.makeBooking(1, 3));
            expected.Add(Booking.makeBooking(0, 15));
            expected.Add(Booking.makeBooking(1, 9));
            expected.Add(Booking.makeBooking(2, 5));
            expected.Add(Booking.makeBooking(4, 9));
            
            foreach(var i in expected)
            {
                i.isBooked = true;
            }

            //second last item is declined
            expected[expected.Count - 2].isBooked = false;


            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test5()
        {

            List<Booking> actual = new List<Booking>();
            actual.Add(Booking.makeBooking(1, 3));
            actual.Add(Booking.makeBooking(0, 4));
            actual.Add(Booking.makeBooking(2, 3));
            actual.Add(Booking.makeBooking(5, 5));
            actual.Add(Booking.makeBooking(4, 10));
            actual.Add(Booking.makeBooking(10, 10));
            actual.Add(Booking.makeBooking(6, 7));
            actual.Add(Booking.makeBooking(8, 10));
            actual.Add(Booking.makeBooking(8, 9));
            BookingConfirmation.CheckBooking(2, actual);

            List<Booking> expected = new List<Booking>();
            expected.Add(Booking.makeBooking(1, 3));
            expected.Add(Booking.makeBooking(0, 4));
            expected.Add(Booking.makeBooking(2, 3));
            expected.Add(Booking.makeBooking(5, 5));
            expected.Add(Booking.makeBooking(4, 10));
            expected.Add(Booking.makeBooking(10, 10));
            expected.Add(Booking.makeBooking(6, 7));
            expected.Add(Booking.makeBooking(8, 10));
            expected.Add(Booking.makeBooking(8, 9));
            
            foreach(var i in expected)
            {
                i.isBooked = true;
            }

            //third is false and second last is false
            expected[2].isBooked = false;
            expected[expected.Count - 2].isBooked = false;


            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
