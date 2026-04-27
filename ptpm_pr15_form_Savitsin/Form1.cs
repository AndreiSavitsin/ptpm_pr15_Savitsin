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
using System.ComponentModel;
using prakt15_Savitsin;

namespace ptpm_pr15_form_Savitsin
{
    public partial class Form1 : Form
    {
        string filePath = "RoomInfo.txt";
        public Form1()
        {
            InitializeComponent();

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn() { Name = "lengthRoom", HeaderText = "Длина комнаты" };
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn() { Name = "widthRoom", HeaderText = "Ширина комнаты" };
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn() { Name = "heightRoom", HeaderText = "Высота комнаты" };
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn() { Name = "countWindow", HeaderText = "Количество окон" };
            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn() { Name = "heightWindow", HeaderText = "Высота окон" };
            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn() { Name = "widthWindow", HeaderText = "Ширина окон" };

            dataGridView1.Columns.AddRange(new DataGridViewTextBoxColumn[] { column1, column2, column3, column4, column5, column6 });
        }
        private void LoadFromFile1() // Зашрузка из текстового файла в datagrid (Способ 1)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] parts = line.Split(' ');

                        dataGridView1.Rows.Add(parts[2], parts[5], parts[8], parts[11], parts[14], parts[17]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Текстовый файл не найден");
            }
        }
        private void LoadFromFile2() //Загрузка из текстового файла в list (Способ 2)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string str = sr.ReadLine();
                        string[] parts = str.Split(' ');
                        Room room = new Room(0, 0, 0, 0, 0, 0);
                        if (!double.TryParse(parts[2], out double lengthRoom))
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

                        if (!double.TryParse(parts[5], out double widthRoom))
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

                        if (!double.TryParse(parts[8], out double heightRoom))
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

                        if (!int.TryParse(parts[11], out int countWindow))
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

                        if (!double.TryParse(parts[14], out double heightWindow))
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

                        if (!double.TryParse(parts[17], out double widthWindow))
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

                        Room.RoomList.Add(room);
                    }
                }
            }
            else
            {
                MessageBox.Show("Текстовый файл не найден");
            }
        }
        private void FillDataGrid() //Заполнение dataGridView
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn() { Name = "lengthRoom", HeaderText = "Длина комнаты" };
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn() { Name = "widthRoom", HeaderText = "Ширина комнаты" };
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn() { Name = "heightRoom", HeaderText = "Высота комнаты" };
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn() { Name = "countWindow", HeaderText = "Количество окон" };
            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn() { Name = "heightWindow", HeaderText = "Высота окон" };
            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn() { Name = "widthWindow", HeaderText = "Ширина окон" };

            dataGridView1.Columns.AddRange(new DataGridViewTextBoxColumn[] { column1, column2, column3, column4, column5, column6});

            for (int i = 0; i < Room.RoomList.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = Room.RoomList[i].LengthRoom;
                dataGridView1[1, i].Value = Room.RoomList[i].WidthRoom;
                dataGridView1[2, i].Value = Room.RoomList[i].HeightRoom;
                dataGridView1[3, i].Value = Room.RoomList[i].CountWindow;
                dataGridView1[4, i].Value = Room.RoomList[i].HeightWindow;
                dataGridView1[5, i].Value = Room.RoomList[i].WidthWindow;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) //Кнопка создать комнату
        {
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
            FillDataGrid();

            double widthRoll;
            if (!double.TryParse(txtWidthRoll.Text, out double wRoll))
            {
                widthRoll = 1;
            }
            else
            {
                widthRoll = wRoll;
            }

            string info1 = Room.RepairRoom(widthRoll, room);
            double info2 = Room.AreaAllWindow();

            MessageBox.Show(info1, "Информация о рулонах", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show($"Площадь всех окон: {info2}", "Информация о площади", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Room.FillInfo();
        }

        private void btnBinding_Click(object sender, EventArgs e) //Кнопка загрузить из файла (binding)
        {
            LoadFromFile2();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            BindingList<Room> bindingList = new BindingList<Room>(Room.RoomList);

            dataGridView1.DataSource = bindingList;
        }

        private void btnLoadFromFile2_Click(object sender, EventArgs e) //Кнопка загрузить из файла (Способ 2)
        {
            LoadFromFile2();
            FillDataGrid();
        }

        private void btnLoadFromFile1_Click(object sender, EventArgs e) //Кнопка загрузить из файла (Способ 1)
        {
            LoadFromFile1();
        }
    }
}
