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
            this.label2 = new System.Windows.Forms.Label();
            this.PlaySubmit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RoundTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IsActive = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.AllPlayer = new System.Windows.Forms.TextBox();
            this.ConfirmRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(179, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "新房间创建";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(30, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "玩家提交数字个数(1或2)";
            // 
            // PlaySubmit
            // 
            this.PlaySubmit.BackColor = System.Drawing.Color.Black;
            this.PlaySubmit.CausesValidation = false;
            this.PlaySubmit.ForeColor = System.Drawing.Color.Red;
            this.PlaySubmit.Location = new System.Drawing.Point(34, 148);
            this.PlaySubmit.MaxLength = 1;
            this.PlaySubmit.Multiline = true;
            this.PlaySubmit.Name = "PlaySubmit";
            this.PlaySubmit.Size = new System.Drawing.Size(259, 31);
            this.PlaySubmit.TabIndex = 2;
            this.PlaySubmit.TextChanged += new System.EventHandler(this.PlaySubmit_TextChanged_1);
            this.PlaySubmit.Enter += new System.EventHandler(this.PlaySubmit_Enter);
            this.PlaySubmit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlaySubmit_KeyPress);
            this.PlaySubmit.Leave += new System.EventHandler(this.PlaySubmit_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(30, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "游戏总时长（s）";
            // 
            // RoundTime
            // 
            this.RoundTime.BackColor = System.Drawing.Color.Black;
            this.RoundTime.ForeColor = System.Drawing.Color.Red;
            this.RoundTime.Location = new System.Drawing.Point(34, 209);
            this.RoundTime.MaxLength = 3;
            this.RoundTime.Multiline = true;
            this.RoundTime.Name = "RoundTime";
            this.RoundTime.Size = new System.Drawing.Size(259, 31);
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
            this.label4.Location = new System.Drawing.Point(30, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 5;
            // 
            // IsActive
            // 
            this.IsActive.AutoSize = true;
            this.IsActive.BackColor = System.Drawing.Color.Transparent;
            this.IsActive.Checked = true;
            this.IsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsActive.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IsActive.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.IsActive.Location = new System.Drawing.Point(37, 250);
            this.IsActive.Name = "IsActive";
            this.IsActive.Size = new System.Drawing.Size(88, 20);
            this.IsActive.TabIndex = 6;
            this.IsActive.Text = "手动开始";
            this.IsActive.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.checkBox2.Location = new System.Drawing.Point(34, 276);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(184, 20);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "限制玩家总数（1-99）";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // AllPlayer
            // 
            this.AllPlayer.BackColor = System.Drawing.Color.Black;
            this.AllPlayer.ForeColor = System.Drawing.Color.Red;
            this.AllPlayer.Location = new System.Drawing.Point(34, 302);
            this.AllPlayer.MaxLength = 2;
            this.AllPlayer.Multiline = true;
            this.AllPlayer.Name = "AllPlayer";
            this.AllPlayer.Size = new System.Drawing.Size(259, 31);
            this.AllPlayer.TabIndex = 10;
            this.AllPlayer.TextChanged += new System.EventHandler(this.AllPlayer_TextChanged_1);
            this.AllPlayer.Enter += new System.EventHandler(this.AllPlayer_Enter);
            this.AllPlayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllPlayer_KeyPress);
            this.AllPlayer.Leave += new System.EventHandler(this.AllPlayer_Leave);
            // 
            // ConfirmRoom
            // 
            this.ConfirmRoom.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmRoom.Image = ((System.Drawing.Image)(resources.GetObject("ConfirmRoom.Image")));
            this.ConfirmRoom.Location = new System.Drawing.Point(393, 203);
            this.ConfirmRoom.Name = "ConfirmRoom";
            this.ConfirmRoom.Size = new System.Drawing.Size(99, 37);
            this.ConfirmRoom.TabIndex = 11;
            this.ConfirmRoom.UseMnemonic = false;
            this.ConfirmRoom.UseVisualStyleBackColor = false;
            this.ConfirmRoom.Click += new System.EventHandler(this.ConfirmRoom_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(642, 425);
            this.Controls.Add(this.ConfirmRoom);
            this.Controls.Add(this.AllPlayer);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.IsActive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RoundTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlaySubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PlaySubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RoundTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox IsActive;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox AllPlayer;
        private System.Windows.Forms.Button ConfirmRoom;
    }
}