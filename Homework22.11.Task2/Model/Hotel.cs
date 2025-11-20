using Homework22._11.Task2.Excep;

namespace Homework22._11.Task2.Model
{
    internal class Hotel
    {
        public string Name { get; set; }
        private Room[] _rooms { get; set; } = new Room[0];
        
        public Room this[int index]
        {
            get
            {
                if (index >= 0 && index < _rooms.Length)
                {
                    return _rooms[index];
                }
                throw new IndexOutOfRangeException("Index is out of range");
            }
            set
            {
                if (index >= 0 && index < _rooms.Length)
                {
                    _rooms[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
            }
        }
        
        public void AddRoom(Room room)
        {
            Room[] newRooms = new Room[_rooms.Length + 1];
            for (int i = 0; i < _rooms.Length; i++)
            {
                newRooms[i] = _rooms[i];
            }
            newRooms[_rooms.Length] = room;
            _rooms = newRooms;
        }
        
        public Hotel(string name)
        {
            Name = name;
        }

        public void Reserve(int? roomId)
        {
            if (roomId == null)
                throw new ArgumentNullException(nameof(roomId), "RoomId cannot be null.");

            Room room = null;

            foreach (var r in _rooms)
            {
                if (r.Id == roomId)
                {
                    room = r;
                    break;
                }
            }

            if (room == null)
                throw new NotFoundException("Room not found.");

            if (!room.IsAvailable)
                throw new NotAvailableException("This room is already reserved.");

            room.IsAvailable = false;
        }
    }
}
