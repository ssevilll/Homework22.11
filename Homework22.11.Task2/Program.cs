using Homework22._11.Task2.Model;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a name for your hotel: \n");
        string name= Console.ReadLine();
        Hotel hotel = new Hotel(name);
        Console.WriteLine("How many rooms you want t add?: \n");
        int count=Convert.ToInt32(Console.ReadLine());
        for (int i=0; i < count; i++)
        {
            Console.WriteLine($"Enter the name of room {i+1}: \n");
            string roomName= Console.ReadLine();
            Console.WriteLine($"Enter the price of room {i+1}: \n");
            double price=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Enter the person capacity of room {i+1}: \n");
            int capacity=Convert.ToInt32(Console.ReadLine());
            Room room = new Room(roomName,price,capacity);
            hotel.AddRoom(room);
        }

        Room firstRoom = hotel[0];  
        Console.WriteLine($"First room: {firstRoom.Name}");

        Room lastroom = hotel[count-1]; 
        Console.WriteLine($"Last room: {lastroom.Name}");

        bool running = true;

        while (running)
        {
            Console.WriteLine("What you want to do \n(1.Change room 2.See all rooms 3. Add room 0.Quit)?: \n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the index of the room you want to change: \n");
                    int index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the new name of the room: \n");
                    string newName = Console.ReadLine();
                    Console.WriteLine("Enter the new price of the room: \n");
                    double newPrice = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the new person capacity of the room: \n");
                    int newCapacity = Convert.ToInt32(Console.ReadLine());
                    Room Room = new Room(newName, newPrice, newCapacity);
                    hotel[index] = Room;
                    Console.WriteLine($"Room no {index + 1} updated to: {hotel[index].Name}");
                    break;
                case 2:
                    Console.WriteLine("\nAll rooms:");
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine($"Room {i + 1}: {hotel[i].Name} - ${hotel[i].Price}");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter the name of the new room: \n");
                    string roomName = Console.ReadLine();
                    Console.WriteLine("Enter the price of the new room: \n");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the person capacity of the new room: \n");
                    int capacity = Convert.ToInt32(Console.ReadLine());
                    Room room = new Room(roomName, price, capacity);
                    hotel.AddRoom(room);
                    Console.WriteLine($"Added new room: {room.Name}");
                    count++;
                    break;
                case 0:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        }
    }
}
