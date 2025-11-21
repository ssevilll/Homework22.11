namespace Homework22._11.Task2.Model
{
    internal class Room
    {
        private static int _id=0;
        public int Id { get { return _id; } }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; }
        public Room(string name, double price, int capacity)
        {
            _id++;
            Name = name;
            Price = price;
            PersonCapacity = capacity;
            IsAvailable= true;
        }
        public string ShowInfo()
        {
            return $"Room ID: {Id}, Name: {Name}, Price: {Price}, Capacity: {PersonCapacity}, Available: {IsAvailable}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
