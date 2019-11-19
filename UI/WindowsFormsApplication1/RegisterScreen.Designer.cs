namespace WindowsFormsApplication1
{
    partial class RegisterScreen
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.landing = new System.Windows.Forms.Button();
            this.visitor = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(148, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号\r\n";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(148, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "密码";
            this.label2.UseWaitCursor = true;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(268, 135);
            this.ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(193, 25);
            this.ID.TabIndex = 1;
            this.ID.UseWaitCursor = true;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(268, 210);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(193, 25);
            this.password.TabIndex = 1;
            this.password.UseWaitCursor = true;
            // 
            // landing
            // 
            this.landing.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.landing.Location = new System.Drawing.Point(116, 315);
            this.landing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.landing.Name = "landing";
            this.landing.Size = new System.Drawing.Size(75, 38);
            this.landing.TabIndex = 2;
            this.landing.Text = "登录";
            this.landing.UseVisualStyleBackColor = true;
            this.landing.UseWaitCursor = true;
            this.landing.Click += new System.EventHandler(this.button1_Click);
            // 
            // visitor
            // 
            this.visitor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.visitor.Location = new System.Drawing.Point(376, 315);
            this.visitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visitor.Name = "visitor";
            this.visitor.Size = new System.Drawing.Size(168, 38);
            this.visitor.TabIndex = 2;
            this.visitor.Text = "以游客身份登录";
            this.visitor.UseVisualStyleBackColor = true;
            this.visitor.UseWaitCursor = true;
            this.visitor.Click += new System.EventHandler(this.button2_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.Location = new System.Drawing.Point(240, 315);
            this.login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 38);
            this.login.TabIndex = 2;
            this.login.Text = "注册";
            this.login.UseVisualStyleBackColor = true;
            this.login.UseWaitCursor = true;
            this.login.Click += new System.EventHandler(this.button3_Click);
            this.login.MouseCaptureChanged += new System.EventHandler(this.Form1_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(173, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "GoldenPoint";
            this.label3.UseWaitCursor = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 428);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.visitor);
            this.Controls.Add(this.login);
            this.Controls.Add(this.landing);
            this.Controls.Add(this.password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterScreen";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button landing;
        private System.Windows.Forms.Button visitor;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label3;
    }
}

