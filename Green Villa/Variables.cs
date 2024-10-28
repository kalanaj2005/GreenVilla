using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Villa
{
    public class Variables
    {
        // storing login details
        public static string username = "";

        //store guest ID for deleting and updating
        public static int guestID = 0;

        //store room number for deleting and updating
        public static string roomNum = "";

        //store details required for making a reservation
        public static DateTime startDate;
        public static DateTime endDate;
        public static int Cost;
        public static int NumOfDays;
        public static string AddReservationRoom;

        //store reservation ID for updating
        public static int reservationID;
        public static string updateRoomNum;
        public static int updateGID;
    }
}
