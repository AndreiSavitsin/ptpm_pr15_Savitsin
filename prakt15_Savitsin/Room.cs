using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt15_Savitsin
{
    public class Room
    {
        static public List<Room> RoomList = new List<Room>();
        static string filePath = "RoomInfo.txt";

        double lengthRoom;
        double widthRoom;
        double heightRoom;
        int countWindow;
        double heightWindow;
        double widthWindow;

        public Room(double lengthRoom, double widthRoom, double heightRoom, int countWindow, double heightWindow, double widthWindow)
        {
            this.lengthRoom = lengthRoom; //Длина комнаты
            this.widthRoom = widthRoom; //Ширина комнаты
            this.heightRoom = heightRoom; //Высота комнаты
            this.countWindow = countWindow; //Количество окон
            this.heightWindow = heightWindow; //Высота окон
            this.widthWindow = widthWindow; //Ширина окон
        }

        public double LengthRoom
        {
            get { return lengthRoom; }
            set { lengthRoom = value; }
        }
        public double WidthRoom
        {
            get { return widthRoom; }
            set { widthRoom = value; }
        }
        public double HeightRoom
        {
            get { return heightRoom; }
            set { heightRoom = value; }
        }
        public int CountWindow
        {
            get { return countWindow; }
            set { countWindow = value; }
        }
        public double HeightWindow
        {
            get { return heightWindow; }
            set { heightWindow = value; }
        }
        public double WidthWindow
        {
            get { return widthWindow; }
            set { widthWindow = value; }
        }
        static public void AddRoom(Room room) //Добавление комнаты в лист
        {
            RoomList.Add(room);
        }
        public double AreaRoom() //Площадь комнаты
        {
            return lengthRoom * widthRoom;
        }
        public double VolumeRoom() //Объём комнаты
        {
            return lengthRoom * widthRoom * heightRoom;
        }
        static public string RoomInfo(Room room) //Информация о комнате
        {
            return $"Длина комнаты: {room.lengthRoom} Ширина комнаты: {room.widthRoom} Высота комнаты: {room.heightRoom} Количество окон: {room.countWindow} Высота окон: {room.heightWindow} Ширина окон: {room.widthWindow}";
        }
        static public List<string> ListRoomInfo()
        {
            List<string> room = new List<string>();
            foreach (var item in RoomList)
            {
                room.Add($"Длина комнаты: {item.lengthRoom} Ширина комнаты: {item.widthRoom} Высота комнаты: {item.heightRoom} Количество окон: {item.countWindow} Высота окон: {item.heightWindow} Ширина окон: {item.widthWindow}");
            }
            return room;
        }
        static public void FillInfo()
        {
            using (StreamWriter sw = File.CreateText(filePath))
            {
                foreach (var item in RoomList)
                {
                    sw.WriteLine($"Длина комнаты: {item.lengthRoom} Ширина комнаты: {item.widthRoom} Высота комнаты: {item.heightRoom} Количество окон: {item.countWindow} Высота окон: {item.heightWindow} Ширина окон: {item.widthWindow}");
                }
            }
        }
        static public string RepairRoom(Room room) //Количество рулонов обоев (для консоли)
        {
            try
            {
                Console.Write("Введите ширину рулона: ");
                double widthRoll = Convert.ToDouble(Console.ReadLine());
                if (widthRoll <= 0.0)
                {
                    return "Ширина рулона не может быть <= 0";
                }
                else
                {
                    double wall1 = room.heightRoom * room.lengthRoom;
                    double wall2 = room.heightRoom * room.widthRoom;
                    double AreaWallsRoom = 2 * (wall1 + wall2);

                    double AreaRoll1 = 10 * widthRoll;
                    double AreaRoll2 = 15 * widthRoll;

                    double countRoll1 = AreaWallsRoom / AreaRoll1;
                    double countRoll2 = AreaWallsRoom / AreaRoll2;

                    return $"Рулон: длина = 10 ширина = {widthRoll}\n" + $"Количество рулонов: {Math.Ceiling(countRoll1)}\n" 
                        + $"Рулон: длина = 15 ширина = {widthRoll}\n" + $"Количество рулонов: {Math.Ceiling(countRoll2)}\n";
                }
            }
            catch
            {
                return "Неверный формат значения";
            }
        }
        static public string RepairRoom(double width, Room room) //Количество рулонов обоев (для форма)
        {
            double wall1 = room.heightRoom * room.lengthRoom;
            double wall2 = room.heightRoom * room.widthRoom;
            double AreaWallsRoom = 2 * (wall1 + wall2);

            double AreaRoll1 = 10 * width;
            double AreaRoll2 = 15 * width;

            double countRoll1 = AreaWallsRoom / AreaRoll1;
            double countRoll2 = AreaWallsRoom / AreaRoll2;

            return $"Рулон: длина = 10 ширина = {width} " + $"Количество рулонов: {Math.Ceiling(countRoll1)} \n"
                + $"Рулон: длина = 15 ширина = {width} " + $"Количество рулонов: {Math.Ceiling(countRoll2)}";
        }
        static public double AreaAllWindow() //Площадь всех окон
        {
            double areaAllWindowAllRoom = 0;
            foreach (var item in RoomList)
            {
                double areaWindow = item.HeightWindow * item.WidthWindow;
                double areaAllWindowOneRoom = item.CountWindow * areaWindow;
                areaAllWindowAllRoom += areaAllWindowOneRoom;
            }
            return areaAllWindowAllRoom;
        }
    }
}
