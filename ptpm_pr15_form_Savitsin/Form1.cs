using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prakt15_Savitsin;

namespace ptpm_pr15_form_Savitsin
{
    public partial class Form1 : Form
    {
        string filePath = "RoomInfo.txt";
        public Form1()
        {
            InitializeComponent();
            FillDataGrid();
            int i = 0;
            using (StreamReader sr = new StreamReader(filePath))
            {
                while(!sr.EndOfStream)
                {
                    string str = sr.ReadLine();
                    if (i == 1)
                    {
                        string[] parts = str.Split(' ');
                        Room room = new Room(0, 0, 0, 0, 0, 0);

                        if (!double.TryParse(parts[2], out double lengthRoom))
                        {
                            room.LengthRoom = 5;
                        }
                        else
                        {
                            room.LengthRoom = lengthRoom;
                        }

                        if (!double.TryParse(parts[5], out double widthRoom))
                        {
                            room.WidthRoom = 5;
                        }
                        else
                        {
                            room.WidthRoom = widthRoom;
                        }

                        if (!double.TryParse(parts[8], out double heightRoom))
                        {
                            room.HeightRoom = 5;
                        }
                        else
                        {
                            room.HeightRoom = heightRoom;
                        }

                        if (!int.TryParse(parts[11], out int countWindow))
                        {
                            room.CountWindow = 1;
                        }
                        else
                        {
                            room.CountWindow = countWindow;
                        }

                        if (!double.TryParse(parts[14], out double heightWindow))
                        {
                            room.HeightWindow = 2;
                        }
                        else
                        {
                            room.HeightWindow = heightWindow;
                        }

                        if (!double.TryParse(parts[17], out double widthWindow))
                        {
                            room.WidthWindow = 2;
                        }
                        else
                        {
                            room.WidthWindow = widthWindow;
                        }

                        Room.AddRoom(room);
                    }
                    textBoxInfo.Text += str + Environment.NewLine;
                    if (i == 4)
                    {
                        i = 0;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
        }
        int numberRoom = Room.RoomList.Count + 1;
        private void FillDataGrid() //Заполнение dataGridView
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn() { Name = "numberRoom", HeaderText = "Номер комнаты" };
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn() { Name = "lengthRoom", HeaderText = "Длина комнаты" };
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn() { Name = "widthRoom", HeaderText = "Ширина комнаты" };
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn() { Name = "heightRoom", HeaderText = "Высота комнаты" };
            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn() { Name = "countWindow", HeaderText = "Количество окон" };
            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn() { Name = "heightWindow", HeaderText = "Высота окон" };
            DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn() { Name = "widthWindow", HeaderText = "Ширина окон" };
            //DataGridViewTextBoxColumn column8 = new DataGridViewTextBoxColumn() { Name = "areaRoom", HeaderText = "Площадь комнаты" };
            //DataGridViewTextBoxColumn column9 = new DataGridViewTextBoxColumn() { Name = "volumeRoom", HeaderText = "Объём комнаты" };
            //DataGridViewTextBoxColumn column10 = new DataGridViewTextBoxColumn() { Name = "RollLength10", HeaderText = "Рулон: длина = 10" };
            //DataGridViewTextBoxColumn column11 = new DataGridViewTextBoxColumn() { Name = "RollLength15", HeaderText = "Рулон: длина = 15" };

            dataGridView1.Columns.AddRange(new DataGridViewTextBoxColumn[] { column1, column2, column3, column4, column5, column6, column7/*, column8, column9, column10, column11*/});

            for (int i = 0; i < Room.RoomList.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = numberRoom;
                dataGridView1[1, i].Value = Room.RoomList[i].LengthRoom;
                dataGridView1[2, i].Value = Room.RoomList[i].WidthRoom;
                dataGridView1[3, i].Value = Room.RoomList[i].HeightRoom;
                dataGridView1[4, i].Value = Room.RoomList[i].CountWindow;
                dataGridView1[5, i].Value = Room.RoomList[i].HeightWindow;
                dataGridView1[6, i].Value = Room.RoomList[i].WidthWindow;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int numberRoom = Room.RoomList.Count + 1;

            Room room = new Room(0, 0, 0, 0, 0, 0);
            if (!double.TryParse(txtLengthRoom.Text, out double lengthRoom))
            {
                room.LengthRoom = 5.0;
            }
            else
            {
                if (lengthRoom <= 0)
                {
                    room.LengthRoom = 5.0;
                }
                else
                {
                    room.LengthRoom = lengthRoom;
                }
            }

            if (!double.TryParse(txtWidthRoom.Text, out double widthRoom))
            {
                room.WidthRoom = 5.0;
            }
            else
            {
                if (widthRoom <= 0)
                {
                    room.WidthRoom = 5.0;
                }
                else
                {
                    room.WidthRoom = widthRoom;
                }
            }

            if (!double.TryParse(txtHeightRoom.Text, out double heightRoom))
            {
                room.HeightRoom = 5.0;
            }
            else
            {
                if (heightRoom <= 0)
                {
                    room.HeightRoom = 5.0;
                }
                else
                {
                    room.HeightRoom = heightRoom;
                }
            }

            if (!int.TryParse(txtCountWindow.Text, out int countWindow))
            {
                room.CountWindow = 1;
            }
            else
            {
                if (countWindow <= 0)
                {
                    room.CountWindow = 1;
                }
                else
                {
                    room.CountWindow = countWindow;
                }
            }

            if (!double.TryParse(txtHeightWindow.Text, out double heightWindow))
            {
                room.HeightWindow = 2;
            }
            else
            {
                if (heightWindow <= 0)
                {
                    room.HeightWindow = 2;
                }
                else
                {
                    room.HeightWindow = heightWindow;
                }
            }

            if (!double.TryParse(txtWidthWindow.Text, out double widthWindow))
            {
                room.WidthWindow = 2;
            }
            else
            {
                if (widthWindow <= 0)
                {
                    room.WidthWindow = 2;
                }
                else
                {
                    room.WidthWindow = widthWindow;
                }
            }

            Room.AddRoom(room);

            textBoxInfo.Text += ($"Комната {numberRoom}" + Environment.NewLine);
            textBoxInfo.Text += ($"{Room.RoomInfo(room)}" + Environment.NewLine);
            textBoxInfo.Text += ($"Площадь комнаты: {room.AreaRoom()}" + Environment.NewLine);
            textBoxInfo.Text += ($"Объём комнаты: {room.VolumeRoom()}" + Environment.NewLine);

            double widthRoll;
            if (!double.TryParse(txtWidthRoll.Text, out double wRoll))
            {
                widthRoll = 1;
            }
            else
            {
                widthRoll = wRoll;
            }

            textBoxInfo.Text += ($"{Room.RepairRoom(widthRoll, room)}" + Environment.NewLine);
            textBoxInfo.Text += ("" + Environment.NewLine);

            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"Комната {numberRoom}");
                sw.WriteLine($"{Room.RoomInfo(room)}");
                sw.WriteLine($"Площадь комнаты: {room.AreaRoom()}");
                sw.WriteLine($"Объём комнаты: {room.VolumeRoom()}");
                sw.WriteLine($"{Room.RepairRoom(widthRoll, room)}");
            }

            numberRoom++;
        }
    }
}
