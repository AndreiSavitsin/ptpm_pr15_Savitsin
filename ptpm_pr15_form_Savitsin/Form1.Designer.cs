namespace ptpm_pr15_form_Savitsin
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLengthRoom = new System.Windows.Forms.TextBox();
            this.txtWidthRoom = new System.Windows.Forms.TextBox();
            this.txtHeightRoom = new System.Windows.Forms.TextBox();
            this.txtCountWindow = new System.Windows.Forms.TextBox();
            this.txtHeightWindow = new System.Windows.Forms.TextBox();
            this.txtWidthWindow = new System.Windows.Forms.TextBox();
            this.txtWidthRoll = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Создать комнату";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите длину комнаты";
            // 
            // txtLengthRoom
            // 
            this.txtLengthRoom.Location = new System.Drawing.Point(44, 69);
            this.txtLengthRoom.Name = "txtLengthRoom";
            this.txtLengthRoom.Size = new System.Drawing.Size(100, 20);
            this.txtLengthRoom.TabIndex = 22;
            // 
            // txtWidthRoom
            // 
            this.txtWidthRoom.Location = new System.Drawing.Point(44, 120);
            this.txtWidthRoom.Name = "txtWidthRoom";
            this.txtWidthRoom.Size = new System.Drawing.Size(100, 20);
            this.txtWidthRoom.TabIndex = 23;
            // 
            // txtHeightRoom
            // 
            this.txtHeightRoom.Location = new System.Drawing.Point(44, 173);
            this.txtHeightRoom.Name = "txtHeightRoom";
            this.txtHeightRoom.Size = new System.Drawing.Size(100, 20);
            this.txtHeightRoom.TabIndex = 24;
            // 
            // txtCountWindow
            // 
            this.txtCountWindow.Location = new System.Drawing.Point(44, 225);
            this.txtCountWindow.Name = "txtCountWindow";
            this.txtCountWindow.Size = new System.Drawing.Size(100, 20);
            this.txtCountWindow.TabIndex = 25;
            // 
            // txtHeightWindow
            // 
            this.txtHeightWindow.Location = new System.Drawing.Point(44, 276);
            this.txtHeightWindow.Name = "txtHeightWindow";
            this.txtHeightWindow.Size = new System.Drawing.Size(100, 20);
            this.txtHeightWindow.TabIndex = 26;
            // 
            // txtWidthWindow
            // 
            this.txtWidthWindow.Location = new System.Drawing.Point(44, 330);
            this.txtWidthWindow.Name = "txtWidthWindow";
            this.txtWidthWindow.Size = new System.Drawing.Size(100, 20);
            this.txtWidthWindow.TabIndex = 27;
            // 
            // txtWidthRoll
            // 
            this.txtWidthRoll.Location = new System.Drawing.Point(44, 384);
            this.txtWidthRoll.Name = "txtWidthRoll";
            this.txtWidthRoll.Size = new System.Drawing.Size(100, 20);
            this.txtWidthRoll.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите ширину комнаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите высоту комнаты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Введите количество окон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Введите высоту окон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Введите ширину окон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Введите ширину рулона";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(432, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 351);
            this.dataGridView1.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 659);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtWidthRoll);
            this.Controls.Add(this.txtWidthWindow);
            this.Controls.Add(this.txtHeightWindow);
            this.Controls.Add(this.txtCountWindow);
            this.Controls.Add(this.txtHeightRoom);
            this.Controls.Add(this.txtWidthRoom);
            this.Controls.Add(this.txtLengthRoom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLengthRoom;
        private System.Windows.Forms.TextBox txtWidthRoom;
        private System.Windows.Forms.TextBox txtHeightRoom;
        private System.Windows.Forms.TextBox txtCountWindow;
        private System.Windows.Forms.TextBox txtHeightWindow;
        private System.Windows.Forms.TextBox txtWidthWindow;
        private System.Windows.Forms.TextBox txtWidthRoll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

