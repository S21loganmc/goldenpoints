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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.Rule = new System.Windows.Forms.Button();
            this.Ai = new System.Windows.Forms.Button();
            this.CreateRoom = new System.Windows.Forms.Button();
            this.Invite = new System.Windows.Forms.Button();
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
            this.label9 = new System.Windows.Forms.Label();
            this.Record = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.LeftTime = new System.Windows.Forms.TextBox();
            this.Times = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Record)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "GoldenPoint";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Rule
            // 
            this.Rule.BackColor = System.Drawing.Color.Transparent;
            this.Rule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Rule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rule.Image = ((System.Drawing.Image)(resources.GetObject("Rule.Image")));
            this.Rule.Location = new System.Drawing.Point(151, 4);
            this.Rule.Name = "Rule";
            this.Rule.Size = new System.Drawing.Size(93, 44);
            this.Rule.TabIndex = 1;
            this.Rule.Text = "规则";
            this.Rule.UseVisualStyleBackColor = false;
            // 
            // Ai
            // 
            this.Ai.BackColor = System.Drawing.Color.Transparent;
            this.Ai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Ai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ai.Image = ((System.Drawing.Image)(resources.GetObject("Ai.Image")));
            this.Ai.Location = new System.Drawing.Point(272, 4);
            this.Ai.Name = "Ai";
            this.Ai.Size = new System.Drawing.Size(93, 44);
            this.Ai.TabIndex = 2;
            this.Ai.UseVisualStyleBackColor = false;
            // 
            // CreateRoom
            // 
            this.CreateRoom.BackColor = System.Drawing.Color.Transparent;
            this.CreateRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateRoom.Image = ((System.Drawing.Image)(resources.GetObject("CreateRoom.Image")));
            this.CreateRoom.Location = new System.Drawing.Point(395, 7);
            this.CreateRoom.Name = "CreateRoom";
            this.CreateRoom.Size = new System.Drawing.Size(111, 41);
            this.CreateRoom.TabIndex = 3;
            this.CreateRoom.UseVisualStyleBackColor = false;
            this.CreateRoom.Click += new System.EventHandler(this.CreateRoom_Click);
            // 
            // Invite
            // 
            this.Invite.BackColor = System.Drawing.Color.Transparent;
            this.Invite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Invite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Invite.Image = ((System.Drawing.Image)(resources.GetObject("Invite.Image")));
            this.Invite.Location = new System.Drawing.Point(530, 6);
            this.Invite.Name = "Invite";
            this.Invite.Size = new System.Drawing.Size(68, 41);
            this.Invite.TabIndex = 4;
            this.Invite.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
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
            this.PlayerName.Location = new System.Drawing.Point(98, 75);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(189, 20);
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
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "当前房间";
            // 
            // RoomNum
            // 
            this.RoomNum.AutoSize = true;
            this.RoomNum.BackColor = System.Drawing.Color.Transparent;
            this.RoomNum.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RoomNum.ForeColor = System.Drawing.SystemColors.Info;
            this.RoomNum.Location = new System.Drawing.Point(98, 108);
            this.RoomNum.Name = "RoomNum";
            this.RoomNum.Size = new System.Drawing.Size(39, 20);
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
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "已进行了";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(133, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "回合";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(12, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "已进行游戏时长";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(242, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "秒";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(12, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "你的数字";
            // 
            // Num
            // 
            this.Num.BackColor = System.Drawing.Color.Black;
            this.Num.ForeColor = System.Drawing.Color.Red;
            this.Num.Location = new System.Drawing.Point(102, 205);
            this.Num.Multiline = true;
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(99, 21);
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
            this.Submit.Location = new System.Drawing.Point(308, 191);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(77, 35);
            this.Submit.TabIndex = 17;
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(12, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "对局历史";
            // 
            // Record
            // 
            this.Record.AllowUserToAddRows = false;
            this.Record.AllowUserToDeleteRows = false;
            this.Record.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Record.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Record.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Record.Location = new System.Drawing.Point(12, 265);
            this.Record.Name = "Record";
            this.Record.ReadOnly = true;
            this.Record.RowTemplate.Height = 23;
            this.Record.Size = new System.Drawing.Size(240, 150);
            this.Record.TabIndex = 20;
            this.Record.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Record_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(439, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 12);
            this.label10.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(410, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "黄金点走势";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(395, 143);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(247, 281);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "Chart";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(362, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 20);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
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
            this.Start.Location = new System.Drawing.Point(310, 139);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 34);
            this.Start.TabIndex = 25;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // LeftTime
            // 
            this.LeftTime.BackColor = System.Drawing.SystemColors.Control;
            this.LeftTime.Enabled = false;
            this.LeftTime.ForeColor = System.Drawing.Color.DarkRed;
            this.LeftTime.Location = new System.Drawing.Point(167, 175);
            this.LeftTime.Name = "LeftTime";
            this.LeftTime.ReadOnly = true;
            this.LeftTime.Size = new System.Drawing.Size(77, 21);
            this.LeftTime.TabIndex = 26;
            this.LeftTime.TextChanged += new System.EventHandler(this.LeftTime_TextChanged);
            // 
            // Times
            // 
            this.Times.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Times.Enabled = false;
            this.Times.ForeColor = System.Drawing.Color.DarkRed;
            this.Times.Location = new System.Drawing.Point(97, 142);
            this.Times.Name = "Times";
            this.Times.ReadOnly = true;
            this.Times.Size = new System.Drawing.Size(40, 21);
            this.Times.TabIndex = 27;
            this.Times.TextChanged += new System.EventHandler(this.Times_TextChanged);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(642, 427);
            this.Controls.Add(this.Times);
            this.Controls.Add(this.LeftTime);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.Invite);
            this.Controls.Add(this.CreateRoom);
            this.Controls.Add(this.Ai);
            this.Controls.Add(this.Rule);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Record)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Rule;
        private System.Windows.Forms.Button Ai;
        private System.Windows.Forms.Button CreateRoom;
        private System.Windows.Forms.Button Invite;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Record;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox LeftTime;
        private System.Windows.Forms.TextBox Times;
    }
}