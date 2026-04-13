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
            Room room1 = new Room(0, 0, 0, 0, 0, 0);
            room1.LengthRoom = 10.0;
            room1.WidthRoom = 7.0;
            room1.HeightRoom = 3.0;
            room1.CountWindow = 2;
            room1.HeightWindow = 1.3;
            room1.WidthWindow = 1.0;

            Room room2 = new Room(0, 0, 0, 0, 0, 0);
            room2.LengthRoom = 9.0;
            room2.WidthRoom = 8.0;
            room2.HeightRoom = 3.0;
            room2.CountWindow = 3;
            room2.HeightWindow = 1.3;
            room2.WidthWindow = 1.0;

            Room room3 = new Room(0, 0, 0, 0, 0, 0);
            room3.LengthRoom = 7.0;
            room3.WidthRoom = 7.0;
            room3.HeightRoom = 3.0;
            room3.CountWindow = 1;
            room3.HeightWindow = 1.3;
            room3.WidthWindow = 1.0;

            Room.AddRoom(room1);
            Room.AddRoom(room2);
            Room.AddRoom(room3);

            Console.WriteLine("Комната 1:");
            string text1 = Room.RoomInfo(room1);
            Console.WriteLine(text1);
            Console.WriteLine($"Площадь комнаты: {room1.AreaRoom()}");
            Console.WriteLine($"Объём комнаты: {room1.VolumeRoom()}");
            string repair1 = Room.RepairRoom(room1);
            Console.WriteLine(repair1);
            Console.WriteLine();

            Console.WriteLine("Комната 2:");
            string text2 = Room.RoomInfo(room2);
            Console.WriteLine(text2);
            Console.WriteLine($"Площадь комнаты: {room2.AreaRoom()}");
            Console.WriteLine($"Объём комнаты: {room2.VolumeRoom()}");
            string repair2 = Room.RepairRoom(room2);
            Console.WriteLine(repair2);
            Console.WriteLine();

            Console.WriteLine("Комната 3:");
            string text3 = Room.RoomInfo(room3);
            Console.WriteLine(text3);
            Console.WriteLine($"Площадь комнаты: {room3.AreaRoom()}");
            Console.WriteLine($"Объём комнаты: {room3.VolumeRoom()}");
            string repair3 = Room.RepairRoom(room3);
            Console.WriteLine(repair3);
            Console.WriteLine();

            Console.WriteLine($"Площадь всех окон в помещении: {Room.AreaAllWindow()}");

            Console.ReadKey();
        }
    }
}
