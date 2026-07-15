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


            Console.WriteLine("Room #" + RoomNumber + " | Type: " + RoomType + " | Price: $" + PricePerNight +
                              "/night | Status: " + availability);
        }
    }

    // class guest 
    public class Guest
    {

        public string GuestId { get; set; }
        public string GuestName { get; set; }
        public int RoomNumber { get; set; }
        public DateTime CheckInDate { get; set; }
        public int TotalNights { get; set; }


        public Guest(string guestId, string guestName, string checkInDate, int totalNights)
        {
            GuestId = guestId;
            GuestName = guestName;
            RoomNumber = 0; 
            TotalNights = totalNights;
            
            DateTime parsedDate;
            if (DateTime.TryParse(checkInDate, out parsedDate))
            {
                CheckInDate = parsedDate;
            }
            else
            {
                CheckInDate = DateTime.Now; 
            }
        }

        //methods 
        public void DisplayGuest()
        {
            // Simple, easy-to-read concatenation
            Console.WriteLine("ID: " + GuestId + " | Name: " + GuestName + " | Room Assigned: #" + RoomNumber +
                              " | Stay: " + TotalNights + " nights (From: " + CheckInDate.ToShortDateString() + ")");
        }

        public double CalculateTotalCost(double pricePerNight)
        {
            return TotalNights * pricePerNight;
        }

    }

    static void Main(string[] args)
    {
        //system list 
        List<Room> rooms = new List<Room>();
        List<Guest> guests = new List<Guest>();

        //rooms 
        rooms.Add(new Room(101, "Single", 75.00));
        rooms.Add(new Room(102, "Single", 75.00));
        rooms.Add(new Room(201, "Double", 120.00));
        rooms.Add(new Room(202, "Double", 120.00));
        rooms.Add(new Room(301, "Suite", 250.00));
        rooms.Add(new Room(302, "Suite", 250.00));

        int nextGustId = 1;
        bool running = true;

        while (running)
        {
            // Main Menu Blueprint
            Console.WriteLine("\n================================================");
            Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
            Console.WriteLine("================================================");
            Console.WriteLine("1. Add New Room");
            Console.WriteLine("2. Register New Guest");
            Console.WriteLine("3. Book a Room for a Guest");
            Console.WriteLine("4. View All Rooms");
            Console.WriteLine("5. View All Guests");
            Console.WriteLine("6. Search & Filter Rooms");
            Console.WriteLine("7. Guest & Booking Statistics");
            Console.WriteLine("8. Update Room Price");
            Console.WriteLine("9. Guest Lookup by Name");
            Console.WriteLine("10. Room Type Breakdown Report");
            Console.WriteLine("11. Check Out a Guest");
            Console.WriteLine("12. Remove Unavailable Rooms");
            Console.WriteLine("13. Extend Guest Stay");
            Console.WriteLine("14. Highest Revenue Booking");
            Console.WriteLine("15. Guest Pagination Viewer");
            Console.WriteLine("0. Exit");
            Console.WriteLine("================================================");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Room Number: ");
                    int newRoomNum;
                    if (!int.TryParse(Console.ReadLine(), out newRoomNum) || newRoomNum <= 0)
                    {
                        Console.WriteLine("Error: Room number must be a positive integer.");
                        break;
                    }

                    bool roomExists = rooms.Any(r => r.RoomNumber == newRoomNum);
                    if (roomExists == true)
                    {
                        Console.WriteLine("Error: Room number already exists!");
                        break;
                    }

                    Console.Write("Enter Room Type (Single/Double/Suite): ");
                    string newRoomType = Console.ReadLine();

                    Console.Write("Enter Price Per Night: ");
                    double newPrice;
                    if (!double.TryParse(Console.ReadLine(), out newPrice) || newPrice <= 0)
                    {
                        Console.WriteLine("Error: Price must be a positive number.");
                        break;
                    }

                    Room newRoom = new Room(newRoomNum, newRoomType, newPrice);
                    rooms.Add(newRoom);

                    Console.WriteLine("Success! Room #" + newRoomNum + " (" + newRoomType + ") added at OMR " +
                                      newPrice.ToString("F2") + " per night.");
                    Console.WriteLine("Total Rooms now in System: " + rooms.Count);
                    break;
                
                case "2":
                    Console.Write("Enter Guest Name: ");
                    string nameInput = Console.ReadLine();

                    Console.Write("Enter Check-In Date (e.g. DD/MM/YYYY): ");
                    string dateInput = Console.ReadLine();

                    Console.Write("Enter Number of Nights: ");
                    int nightsInput;
                    if (!int.TryParse(Console.ReadLine(), out nightsInput) || nightsInput <= 0)
                    {
                        Console.WriteLine("Error: Nights must be a positive integer.");
                        break;
                    }
                    
                    int nextNumber = guests.Count + 1;
                    string generatedId = "G" + nextNumber.ToString("D3");
                    
                    Guest newGuest = new Guest(generatedId, nameInput, dateInput, nightsInput);
                    guests.Add(newGuest);

                    Console.WriteLine("Confirmation: Guest Registered!");
                    Console.WriteLine("Assigned ID: " + newGuest.GuestId);
                    Console.WriteLine("Name: " + newGuest.GuestName);
                    Console.WriteLine("Check-In: " + newGuest.CheckInDate);
                    Console.WriteLine("Nights: " + newGuest.TotalNights);
                    Console.WriteLine("Room Assignment: " + newGuest.RoomNumber);
                    break;
                    
                
            }
        }
    }
}