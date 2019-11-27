namespace WindowsFormsApplication1
{
    partial class Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RoundTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(239, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "新房间创建";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(40, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "游戏总时长（s）";
            // 
            // RoundTime
            // 
            this.RoundTime.BackColor = System.Drawing.Color.Black;
            this.RoundTime.ForeColor = System.Drawing.Color.Red;
            this.RoundTime.Location = new System.Drawing.Point(45, 261);
            this.RoundTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoundTime.MaxLength = 3;
            this.RoundTime.Multiline = true;
            this.RoundTime.Name = "RoundTime";
            this.RoundTime.Size = new System.Drawing.Size(344, 38);
            this.RoundTime.TabIndex = 4;
            this.RoundTime.Enter += new System.EventHandler(this.RoundTime_Enter);
            this.RoundTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RoundTime_KeyPress);
            this.RoundTime.Leave += new System.EventHandler(this.RoundTime_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(40, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 30);
            this.label4.TabIndex = 5;
            // 
            // ConfirmRoom
            // 
            this.ConfirmRoom.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmRoom.Image = ((System.Drawing.Image)(resources.GetObject("ConfirmRoom.Image")));
            this.ConfirmRoom.Location = new System.Drawing.Point(452, 248);
            this.ConfirmRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmRoom.Name = "ConfirmRoom";
            this.ConfirmRoom.Size = new System.Drawing.Size(132, 46);
            this.ConfirmRoom.TabIndex = 11;
            this.ConfirmRoom.UseMnemonic = false;
            this.ConfirmRoom.UseVisualStyleBackColor = false;
            this.ConfirmRoom.Click += new System.EventHandler(this.ConfirmRoom_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(648, 432);
            this.Controls.Add(this.ConfirmRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RoundTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RoundTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ConfirmRoom;
    }
}