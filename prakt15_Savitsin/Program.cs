using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt15_Savitsin
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room(10.0, 7.0, 3.0, 2, 1.3, 1.0);
            Room room2 = new Room(9.0, 8.0, 3.0, 3, 1.3, 1.0);
            Room room3 = new Room(7.0, 7.0, 3.0, 1, 1.3, 1.0);

            Room.AddRoom(room1);
            Room.AddRoom(room2);
            Room.AddRoom(room3);

            Console.WriteLine("Комната 1:");
            Room.RoomInfo(room1);
            Console.WriteLine($"Площадь комнаты: {room1.AreaRoom()}");
            Console.WriteLine($"Объём комнаты: {room1.VolumeRoom()}");
            Room.RepairRoom(room1);
            Console.WriteLine();

            Console.WriteLine("Комната 2:");
            Room.RoomInfo(room2);
            Console.WriteLine($"Площадь комнаты: {room2.AreaRoom()}");
            Console.WriteLine($"Объём комнаты: {room2.VolumeRoom()}");
            Room.RepairRoom(room2);
            Console.WriteLine();

            Console.WriteLine("Комната 3:");
            Room.RoomInfo(room3);
            Console.WriteLine($"Площадь комнаты: {room3.AreaRoom()}");
            Console.WriteLine($"Объём комнаты: {room3.VolumeRoom()}");
            Room.RepairRoom(room3);
            Console.WriteLine();

            Console.WriteLine($"Площадь всех окон в помещении: {Room.AreaAllWindow()}");

            Console.ReadKey();
        }
    }
}
