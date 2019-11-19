namespace WindowsFormsApplication1
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.RID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Rpassword = new System.Windows.Forms.TextBox();
            this.Rpassword2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RID
            // 
            this.RID.Location = new System.Drawing.Point(216, 104);
            this.RID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RID.Name = "RID";
            this.RID.Size = new System.Drawing.Size(163, 21);
            this.RID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(124, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "账号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // login2
            // 
            this.login2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login2.Location = new System.Drawing.Point(166, 250);
            this.login2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login2.Name = "login2";
            this.login2.Size = new System.Drawing.Size(82, 30);
            this.login2.TabIndex = 2;
            this.login2.Text = "注册";
            this.login2.UseVisualStyleBackColor = true;
            this.login2.Click += new System.EventHandler(this.login2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(124, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(116, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "确认密码";
            // 
            // Rpassword
            // 
            this.Rpassword.Location = new System.Drawing.Point(216, 142);
            this.Rpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rpassword.Name = "Rpassword";
            this.Rpassword.Size = new System.Drawing.Size(163, 21);
            this.Rpassword.TabIndex = 0;
            // 
            // Rpassword2
            // 
            this.Rpassword2.Location = new System.Drawing.Point(216, 186);
            this.Rpassword2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rpassword2.Name = "Rpassword2";
            this.Rpassword2.Size = new System.Drawing.Size(163, 21);
            this.Rpassword2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(134, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "GoldenPoint";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(479, 339);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rpassword2);
            this.Controls.Add(this.Rpassword);
            this.Controls.Add(this.RID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Rpassword;
        private System.Windows.Forms.TextBox Rpassword2;
        private System.Windows.Forms.Label label5;
    }
}