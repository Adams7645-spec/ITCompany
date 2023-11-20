namespace ITCompany
{
    partial class LoginWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWin));
            this.button_CloseLoginWin = new System.Windows.Forms.PictureBox();
            this.label_main = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.PictureBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_logins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.button_CloseLoginWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_login)).BeginInit();
            this.SuspendLayout();
            // 
            // button_CloseLoginWin
            // 
            this.button_CloseLoginWin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CloseLoginWin.Image = ((System.Drawing.Image)(resources.GetObject("button_CloseLoginWin.Image")));
            this.button_CloseLoginWin.Location = new System.Drawing.Point(445, 12);
            this.button_CloseLoginWin.Name = "button_CloseLoginWin";
            this.button_CloseLoginWin.Size = new System.Drawing.Size(35, 35);
            this.button_CloseLoginWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_CloseLoginWin.TabIndex = 0;
            this.button_CloseLoginWin.TabStop = false;
            this.button_CloseLoginWin.Click += new System.EventHandler(this.button_CloseLoginWin_Click);
            // 
            // label_main
            // 
            this.label_main.AutoSize = true;
            this.label_main.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_main.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_main.Location = new System.Drawing.Point(89, 132);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(305, 37);
            this.label_main.TabIndex = 1;
            this.label_main.Text = "IT Company Login";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_info.Location = new System.Drawing.Point(57, 180);
            this.label_info.MaximumSize = new System.Drawing.Size(400, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(370, 48);
            this.label_info.TabIndex = 2;
            this.label_info.Text = "You can log in as a manager or company admin";
            this.label_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_login
            // 
            this.textBox_login.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_login.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(146, 280);
            this.textBox_login.MaxLength = 20;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(200, 26);
            this.textBox_login.TabIndex = 3;
            this.textBox_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_login_KeyPress);
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_password.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(146, 331);
            this.textBox_password.MaxLength = 20;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(200, 26);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_password_KeyPress);
            // 
            // button_login
            // 
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.Image = ((System.Drawing.Image)(resources.GetObject("button_login.Image")));
            this.button_login.Location = new System.Drawing.Point(221, 385);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(50, 50);
            this.button_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_login.TabIndex = 5;
            this.button_login.TabStop = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(221, 252);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(0, 13);
            this.label_login.TabIndex = 6;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password.Location = new System.Drawing.Point(142, 309);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(81, 19);
            this.label_password.TabIndex = 7;
            this.label_password.Text = "Password";
            // 
            // label_logins
            // 
            this.label_logins.AutoSize = true;
            this.label_logins.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_logins.Location = new System.Drawing.Point(142, 258);
            this.label_logins.Name = "label_logins";
            this.label_logins.Size = new System.Drawing.Size(54, 19);
            this.label_logins.TabIndex = 7;
            this.label_logins.Text = "Login";
            // 
            // LoginWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(492, 469);
            this.Controls.Add(this.label_logins);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.label_main);
            this.Controls.Add(this.button_CloseLoginWin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT company login";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginWin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginWin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.button_CloseLoginWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox button_CloseLoginWin;
        private System.Windows.Forms.Label label_main;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.PictureBox button_login;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_logins;
    }
}

