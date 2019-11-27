namespace WindowsFormsApplication1
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.CreateRoom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RoomNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.LeftTime = new System.Windows.Forms.TextBox();
            this.Times = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.HRecord = new System.Windows.Forms.Button();
            this.roundrecord = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.roundrecord)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "GoldenPoint";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CreateRoom
            // 
            this.CreateRoom.BackColor = System.Drawing.Color.Transparent;
            this.CreateRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateRoom.Image = ((System.Drawing.Image)(resources.GetObject("CreateRoom.Image")));
            this.CreateRoom.Location = new System.Drawing.Point(190, 7);
            this.CreateRoom.Margin = new System.Windows.Forms.Padding(4);
            this.CreateRoom.Name = "CreateRoom";
            this.CreateRoom.Size = new System.Drawing.Size(148, 51);
            this.CreateRoom.TabIndex = 3;
            this.CreateRoom.UseVisualStyleBackColor = false;
            this.CreateRoom.Click += new System.EventHandler(this.CreateRoom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "欢迎玩家，";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.BackColor = System.Drawing.Color.Transparent;
            this.PlayerName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PlayerName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PlayerName.Location = new System.Drawing.Point(131, 94);
            this.PlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(237, 25);
            this.PlayerName.TabIndex = 6;
            this.PlayerName.Text = "张新明杨汶桐是我儿";
            this.PlayerName.Click += new System.EventHandler(this.PlayerName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(16, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "当前房间";
            // 
            // RoomNum
            // 
            this.RoomNum.AutoSize = true;
            this.RoomNum.BackColor = System.Drawing.Color.Transparent;
            this.RoomNum.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RoomNum.ForeColor = System.Drawing.SystemColors.Info;
            this.RoomNum.Location = new System.Drawing.Point(131, 135);
            this.RoomNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoomNum.Name = "RoomNum";
            this.RoomNum.Size = new System.Drawing.Size(51, 25);
            this.RoomNum.TabIndex = 8;
            this.RoomNum.Text = "XXX";
            this.RoomNum.Click += new System.EventHandler(this.RoomNum_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(16, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "已进行了";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(177, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "回合";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(16, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "已进行游戏时长";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(323, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "秒";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(16, 256);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "你的数字";
            // 
            // Num
            // 
            this.Num.BackColor = System.Drawing.Color.Black;
            this.Num.ForeColor = System.Drawing.Color.Red;
            this.Num.Location = new System.Drawing.Point(136, 256);
            this.Num.Margin = new System.Windows.Forms.Padding(4);
            this.Num.Multiline = true;
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(131, 25);
            this.Num.TabIndex = 16;
            this.Num.TextChanged += new System.EventHandler(this.Num_TextChanged);
            this.Num.Enter += new System.EventHandler(this.Num_Enter);
            this.Num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num_KeyPress);
            this.Num.Leave += new System.EventHandler(this.Num_Leave);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Transparent;
            this.Submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Submit.BackgroundImage")));
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Image = ((System.Drawing.Image)(resources.GetObject("Submit.Image")));
            this.Submit.Location = new System.Drawing.Point(411, 239);
            this.Submit.Margin = new System.Windows.Forms.Padding(4);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(103, 44);
            this.Submit.TabIndex = 17;
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(585, 174);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 15);
            this.label10.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(547, 135);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 25);
            this.label11.TabIndex = 22;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(413, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 25);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Start
            // 
            this.Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Start.BackgroundImage")));
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Image = ((System.Drawing.Image)(resources.GetObject("Start.Image")));
            this.Start.Location = new System.Drawing.Point(413, 174);
            this.Start.Margin = new System.Windows.Forms.Padding(4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 42);
            this.Start.TabIndex = 25;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // LeftTime
            // 
            this.LeftTime.BackColor = System.Drawing.SystemColors.Control;
            this.LeftTime.Enabled = false;
            this.LeftTime.ForeColor = System.Drawing.Color.DarkRed;
            this.LeftTime.Location = new System.Drawing.Point(223, 219);
            this.LeftTime.Margin = new System.Windows.Forms.Padding(4);
            this.LeftTime.Name = "LeftTime";
            this.LeftTime.ReadOnly = true;
            this.LeftTime.Size = new System.Drawing.Size(101, 25);
            this.LeftTime.TabIndex = 26;
            this.LeftTime.TextChanged += new System.EventHandler(this.LeftTime_TextChanged);
            // 
            // Times
            // 
            this.Times.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Times.Enabled = false;
            this.Times.ForeColor = System.Drawing.Color.DarkRed;
            this.Times.Location = new System.Drawing.Point(129, 178);
            this.Times.Margin = new System.Windows.Forms.Padding(4);
            this.Times.Name = "Times";
            this.Times.ReadOnly = true;
            this.Times.Size = new System.Drawing.Size(52, 25);
            this.Times.TabIndex = 27;
            this.Times.TextChanged += new System.EventHandler(this.Times_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(669, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(669, 234);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(521, 180);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "上一轮G值";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(522, 234);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 25);
            this.label13.TabIndex = 31;
            this.label13.Text = "本轮胜利者";
            // 
            // HRecord
            // 
            this.HRecord.Location = new System.Drawing.Point(427, 76);
            this.HRecord.Name = "HRecord";
            this.HRecord.Size = new System.Drawing.Size(75, 23);
            this.HRecord.TabIndex = 32;
            this.HRecord.Text = "历史纪录";
            this.HRecord.UseVisualStyleBackColor = true;
            this.HRecord.Click += new System.EventHandler(this.HRecord_Click);
            // 
            // roundrecord
            // 
            this.roundrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roundrecord.Location = new System.Drawing.Point(21, 334);
            this.roundrecord.Name = "roundrecord";
            this.roundrecord.RowHeadersWidth = 51;
            this.roundrecord.RowTemplate.Height = 27;
            this.roundrecord.Size = new System.Drawing.Size(427, 183);
            this.roundrecord.TabIndex = 33;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(961, 565);
            this.Controls.Add(this.roundrecord);
            this.Controls.Add(this.HRecord);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Times);
            this.Controls.Add(this.LeftTime);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RoomNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreateRoom);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roundrecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RoomNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox LeftTime;
        private System.Windows.Forms.TextBox Times;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button HRecord;
        private System.Windows.Forms.DataGridView roundrecord;
    }
}