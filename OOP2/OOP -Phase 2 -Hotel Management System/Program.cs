namespace OOP__Phase_2__Hotel_Management_System;

class Program
{
    //class room 
    public class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        
        public Room(int roomNumber, string roomType, double pricePerNight)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            PricePerNight = pricePerNight;
            IsAvailable = true; 
        }
        
            //methods 
            public void DisplayRoom()
            {
                string availability = "";
                if (IsAvailable == true)
                {
                    availability = "Available";
                }
                else
                {
                    availability = "Occupied";
                }

                
                Console.WriteLine("Room #" + RoomNumber + " | Type: " + RoomType + " | Price: $" + PricePerNight + "/night | Status: " + availability);
            }
        }
    
        // class guest 
        public class Guest
        {
            
            public int GuestId { get; set; }
            public string GuestName { get; set; }
            public int RoomNumber { get; set; }
            public DateTime CheckInDate { get; set; }
            public int TotalNights { get; set; }

           
            public Guest(int guestId, string guestName, int roomNumber, int totalNights)
            {
                GuestId = guestId;
                GuestName = guestName;
                RoomNumber = roomNumber;
                CheckInDate = DateTime.Now; 
                TotalNights = totalNights;
            }
            
            //methods 
            public void DisplayGuest()
            {
                // Simple, easy-to-read concatenation
                Console.WriteLine("ID: " + GuestId + " | Name: " + GuestName + " | Room Assigned: #" + RoomNumber + " | Stay: " + TotalNights + " nights (From: " + CheckInDate.ToShortDateString() + ")");
            }
            
            public double CalculateTotalCost(double pricePerNight)
            {
                return TotalNights * pricePerNight;
            }
        
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}