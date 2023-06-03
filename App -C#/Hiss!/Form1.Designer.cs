namespace Hiss_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Label();
            this.hed_bar = new System.Windows.Forms.Panel();
            this.hed_txt = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.box_msgs = new System.Windows.Forms.ListBox();
            this.box_users = new System.Windows.Forms.ListBox();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_loginuser = new System.Windows.Forms.TextBox();
            this.txt_loginpass = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.la_pass = new System.Windows.Forms.Label();
            this.la_user = new System.Windows.Forms.Label();
            this.btn_singup = new System.Windows.Forms.Button();
            this.txt_supuser = new System.Windows.Forms.TextBox();
            this.txt_supemail = new System.Windows.Forms.TextBox();
            this.txt_suppass = new System.Windows.Forms.TextBox();
            this.la_supuser = new System.Windows.Forms.Label();
            this.la_supemail = new System.Windows.Forms.Label();
            this.la_suppass = new System.Windows.Forms.Label();
            this.btn_gologin = new System.Windows.Forms.Button();
            this.btn_gosingup = new System.Windows.Forms.Button();
            this.timer_update = new System.Windows.Forms.Timer(this.components);
            this.emoji_box = new System.Windows.Forms.GroupBox();
            this.emoji_9 = new System.Windows.Forms.Label();
            this.emoji_4 = new System.Windows.Forms.Label();
            this.emoji_7 = new System.Windows.Forms.Label();
            this.emoji_2 = new System.Windows.Forms.Label();
            this.emoji_10 = new System.Windows.Forms.Label();
            this.emoji_5 = new System.Windows.Forms.Label();
            this.emoji_8 = new System.Windows.Forms.Label();
            this.emoji_6 = new System.Windows.Forms.Label();
            this.emoji_3 = new System.Windows.Forms.Label();
            this.emoji_1 = new System.Windows.Forms.Label();
            this.btn_emoji = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.hed_bar.SuspendLayout();
            this.emoji_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_settings);
            this.panel1.Controls.Add(this.hed_bar);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 21);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hed_bar_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hed_bar_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hed_bar_MouseUp);
            // 
            // btn_settings
            // 
            this.btn_settings.AutoSize = true;
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Location = new System.Drawing.Point(418, 2);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(51, 15);
            this.btn_settings.TabIndex = 2;
            this.btn_settings.Text = "Settings";
            this.btn_settings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hed_bar_MouseDown);
            this.btn_settings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hed_bar_MouseMove);
            this.btn_settings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hed_bar_MouseUp);
            // 
            // hed_bar
            // 
            this.hed_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.hed_bar.Controls.Add(this.hed_txt);
            this.hed_bar.Dock = System.Windows.Forms.DockStyle.Left;
            this.hed_bar.Location = new System.Drawing.Point(0, 0);
            this.hed_bar.Name = "hed_bar";
            this.hed_bar.Size = new System.Drawing.Size(188, 21);
            this.hed_bar.TabIndex = 1;
            this.hed_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hed_bar_MouseDown);
            this.hed_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hed_bar_MouseMove);
            this.hed_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hed_bar_MouseUp);
            // 
            // hed_txt
            // 
            this.hed_txt.AutoSize = true;
            this.hed_txt.ForeColor = System.Drawing.Color.White;
            this.hed_txt.Location = new System.Drawing.Point(54, 5);
            this.hed_txt.Name = "hed_txt";
            this.hed_txt.Size = new System.Drawing.Size(53, 13);
            this.hed_txt.TabIndex = 0;
            this.hed_txt.Text = "Hiss! Gap";
            this.hed_txt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hed_bar_MouseDown);
            this.hed_txt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hed_bar_MouseMove);
            this.hed_txt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hed_bar_MouseUp);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(478, -2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 26);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "✖";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 2);
            this.panel2.TabIndex = 1;
            // 
            // box_msgs
            // 
            this.box_msgs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.box_msgs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_msgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_msgs.ForeColor = System.Drawing.Color.White;
            this.box_msgs.FormattingEnabled = true;
            this.box_msgs.ItemHeight = 16;
            this.box_msgs.Location = new System.Drawing.Point(187, 24);
            this.box_msgs.Name = "box_msgs";
            this.box_msgs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.box_msgs.Size = new System.Drawing.Size(313, 272);
            this.box_msgs.TabIndex = 2;
            // 
            // box_users
            // 
            this.box_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.box_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_users.FormattingEnabled = true;
            this.box_users.Location = new System.Drawing.Point(0, 24);
            this.box_users.Name = "box_users";
            this.box_users.Size = new System.Drawing.Size(181, 325);
            this.box_users.TabIndex = 3;
            // 
            // txt_msg
            // 
            this.txt_msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_msg.ForeColor = System.Drawing.Color.White;
            this.txt_msg.Location = new System.Drawing.Point(232, 319);
            this.txt_msg.MaxLength = 50;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_msg.Size = new System.Drawing.Size(217, 19);
            this.txt_msg.TabIndex = 4;
            this.txt_msg.Tag = "Write a Message...";
            this.txt_msg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_msg.Click += new System.EventHandler(this.txt_msg_Click);
            this.txt_msg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_msg_KeyDown);
            // 
            // btn_send
            // 
            this.btn_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(131)))));
            this.btn_send.Location = new System.Drawing.Point(455, 309);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(40, 41);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "➤";
            this.btn_send.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Visible = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_loginuser
            // 
            this.txt_loginuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_loginuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_loginuser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loginuser.ForeColor = System.Drawing.Color.White;
            this.txt_loginuser.Location = new System.Drawing.Point(138, 104);
            this.txt_loginuser.Name = "txt_loginuser";
            this.txt_loginuser.Size = new System.Drawing.Size(215, 16);
            this.txt_loginuser.TabIndex = 6;
            this.txt_loginuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_loginpass
            // 
            this.txt_loginpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_loginpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_loginpass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loginpass.ForeColor = System.Drawing.Color.White;
            this.txt_loginpass.Location = new System.Drawing.Point(138, 167);
            this.txt_loginpass.Name = "txt_loginpass";
            this.txt_loginpass.Size = new System.Drawing.Size(215, 16);
            this.txt_loginpass.TabIndex = 7;
            this.txt_loginpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(138, 199);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // la_pass
            // 
            this.la_pass.AutoSize = true;
            this.la_pass.ForeColor = System.Drawing.Color.White;
            this.la_pass.Location = new System.Drawing.Point(217, 142);
            this.la_pass.Name = "la_pass";
            this.la_pass.Size = new System.Drawing.Size(53, 13);
            this.la_pass.TabIndex = 9;
            this.la_pass.Text = "Password";
            // 
            // la_user
            // 
            this.la_user.AutoSize = true;
            this.la_user.ForeColor = System.Drawing.Color.White;
            this.la_user.Location = new System.Drawing.Point(215, 79);
            this.la_user.Name = "la_user";
            this.la_user.Size = new System.Drawing.Size(55, 13);
            this.la_user.TabIndex = 10;
            this.la_user.Text = "Username";
            // 
            // btn_singup
            // 
            this.btn_singup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_singup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_singup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_singup.ForeColor = System.Drawing.Color.White;
            this.btn_singup.Location = new System.Drawing.Point(138, 199);
            this.btn_singup.Name = "btn_singup";
            this.btn_singup.Size = new System.Drawing.Size(75, 23);
            this.btn_singup.TabIndex = 11;
            this.btn_singup.Text = "Singup";
            this.btn_singup.UseVisualStyleBackColor = false;
            this.btn_singup.Click += new System.EventHandler(this.btn_singup_Click);
            // 
            // txt_supuser
            // 
            this.txt_supuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_supuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_supuser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supuser.ForeColor = System.Drawing.Color.White;
            this.txt_supuser.Location = new System.Drawing.Point(138, 79);
            this.txt_supuser.Name = "txt_supuser";
            this.txt_supuser.Size = new System.Drawing.Size(215, 16);
            this.txt_supuser.TabIndex = 12;
            this.txt_supuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_supemail
            // 
            this.txt_supemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_supemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_supemail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supemail.ForeColor = System.Drawing.Color.White;
            this.txt_supemail.Location = new System.Drawing.Point(138, 126);
            this.txt_supemail.Name = "txt_supemail";
            this.txt_supemail.Size = new System.Drawing.Size(215, 16);
            this.txt_supemail.TabIndex = 13;
            this.txt_supemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_suppass
            // 
            this.txt_suppass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txt_suppass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_suppass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suppass.ForeColor = System.Drawing.Color.White;
            this.txt_suppass.Location = new System.Drawing.Point(138, 167);
            this.txt_suppass.Name = "txt_suppass";
            this.txt_suppass.Size = new System.Drawing.Size(215, 16);
            this.txt_suppass.TabIndex = 14;
            this.txt_suppass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // la_supuser
            // 
            this.la_supuser.AutoSize = true;
            this.la_supuser.ForeColor = System.Drawing.Color.White;
            this.la_supuser.Location = new System.Drawing.Point(217, 63);
            this.la_supuser.Name = "la_supuser";
            this.la_supuser.Size = new System.Drawing.Size(55, 13);
            this.la_supuser.TabIndex = 15;
            this.la_supuser.Text = "Username";
            // 
            // la_supemail
            // 
            this.la_supemail.AutoSize = true;
            this.la_supemail.ForeColor = System.Drawing.Color.White;
            this.la_supemail.Location = new System.Drawing.Point(229, 110);
            this.la_supemail.Name = "la_supemail";
            this.la_supemail.Size = new System.Drawing.Size(32, 13);
            this.la_supemail.TabIndex = 15;
            this.la_supemail.Text = "Email";
            // 
            // la_suppass
            // 
            this.la_suppass.AutoSize = true;
            this.la_suppass.ForeColor = System.Drawing.Color.White;
            this.la_suppass.Location = new System.Drawing.Point(219, 151);
            this.la_suppass.Name = "la_suppass";
            this.la_suppass.Size = new System.Drawing.Size(53, 13);
            this.la_suppass.TabIndex = 15;
            this.la_suppass.Text = "Password";
            // 
            // btn_gologin
            // 
            this.btn_gologin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_gologin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_gologin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gologin.ForeColor = System.Drawing.Color.White;
            this.btn_gologin.Location = new System.Drawing.Point(278, 199);
            this.btn_gologin.Name = "btn_gologin";
            this.btn_gologin.Size = new System.Drawing.Size(75, 23);
            this.btn_gologin.TabIndex = 11;
            this.btn_gologin.Text = "Login";
            this.btn_gologin.UseVisualStyleBackColor = false;
            this.btn_gologin.Click += new System.EventHandler(this.btn_gologin_Click);
            // 
            // btn_gosingup
            // 
            this.btn_gosingup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_gosingup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_gosingup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gosingup.ForeColor = System.Drawing.Color.White;
            this.btn_gosingup.Location = new System.Drawing.Point(278, 199);
            this.btn_gosingup.Name = "btn_gosingup";
            this.btn_gosingup.Size = new System.Drawing.Size(75, 23);
            this.btn_gosingup.TabIndex = 16;
            this.btn_gosingup.Text = "Singup";
            this.btn_gosingup.UseVisualStyleBackColor = false;
            this.btn_gosingup.Click += new System.EventHandler(this.btn_gosingup_Click);
            // 
            // timer_update
            // 
            this.timer_update.Interval = 2000;
            this.timer_update.Tick += new System.EventHandler(this.timer_update_Tick);
            // 
            // emoji_box
            // 
            this.emoji_box.Controls.Add(this.emoji_9);
            this.emoji_box.Controls.Add(this.emoji_4);
            this.emoji_box.Controls.Add(this.emoji_7);
            this.emoji_box.Controls.Add(this.emoji_2);
            this.emoji_box.Controls.Add(this.emoji_10);
            this.emoji_box.Controls.Add(this.emoji_5);
            this.emoji_box.Controls.Add(this.emoji_8);
            this.emoji_box.Controls.Add(this.emoji_6);
            this.emoji_box.Controls.Add(this.emoji_3);
            this.emoji_box.Controls.Add(this.emoji_1);
            this.emoji_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emoji_box.ForeColor = System.Drawing.Color.White;
            this.emoji_box.Location = new System.Drawing.Point(187, 189);
            this.emoji_box.Name = "emoji_box";
            this.emoji_box.Size = new System.Drawing.Size(200, 121);
            this.emoji_box.TabIndex = 17;
            this.emoji_box.TabStop = false;
            this.emoji_box.Text = "Emoji";
            // 
            // emoji_9
            // 
            this.emoji_9.AutoSize = true;
            this.emoji_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emoji_9.ForeColor = System.Drawing.Color.White;
            this.emoji_9.Location = new System.Drawing.Point(128, 89);
            this.emoji_9.Name = "emoji_9";
            this.emoji_9.Size = new System.Drawing.Size(25, 20);
            this.emoji_9.TabIndex = 1;
            this.emoji_9.Text = "→";
            this.emoji_9.Click += new System.EventHandler(this.emoji_9_Click);
            // 
            // emoji_4
            // 
            this.emoji_4.AutoSize = true;
            this.emoji_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emoji_4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.emoji_4.Location = new System.Drawing.Point(122, 16);
            this.emoji_4.Name = "emoji_4";
            this.emoji_4.Size = new System.Drawing.Size(32, 31);
            this.emoji_4.TabIndex = 1;
            this.emoji_4.Text = "♫";
            this.emoji_4.Click += new System.EventHandler(this.emoji_4_Click);
            // 
            // emoji_7
            // 
            this.emoji_7.AutoSize = true;
            this.emoji_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emoji_7.ForeColor = System.Drawing.Color.White;
            this.emoji_7.Location = new System.Drawing.Point(51, 89);
            this.emoji_7.Name = "emoji_7";
            this.emoji_7.Size = new System.Drawing.Size(17, 20);
            this.emoji_7.TabIndex = 1;
            this.emoji_7.Text = "↑";
            this.emoji_7.Click += new System.EventHandler(this.emoji_7_Click);
            // 
            // emoji_2
            // 
            this.emoji_2.AutoSize = true;
            this.emoji_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emoji_2.ForeColor = System.Drawing.Color.Red;
            this.emoji_2.Location = new System.Drawing.Point(41, 13);
            this.emoji_2.Name = "emoji_2";
            this.emoji_2.Size = new System.Drawing.Size(55, 39);
            this.emoji_2.TabIndex = 1;
            this.emoji_2.Text = "♥";
            this.emoji_2.Click += new System.EventHandler(this.emoji_2_Click);
            // 
            // emoji_10
            // 
            this.emoji_10.AutoSize = true;
            this.emoji_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emoji_10.ForeColor = System.Drawing.Color.ForestGreen;
            this.emoji_10.Location = new System.Drawing.Point(10, 52);
            this.emoji_10.Name = "emoji_10";
            this.emoji_10.Size = new System.Drawing.Size(44, 31);
            this.emoji_10.TabIndex = 0;
            this.emoji_10.Text = "♠";
            this.emoji_10.Click += new System.EventHandler(this.emoji_10_Click);
            // 
            // emoji_5
            // 
            this.emoji_5.AutoSize = true;
            this.emoji_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emoji_5.ForeColor = System.Drawing.Color.OrangeRed;
            this.emoji_5.Location = new System.Drawing.Point(160, 19);
            this.emoji_5.Name = "emoji_5";
            this.emoji_5.Size = new System.Drawing.Size(39, 29);
            this.emoji_5.TabIndex = 0;
            this.emoji_5.Text = "☺";
            this.emoji_5.Click += new System.EventHandler(this.emoji_5_Click);
            // 
            // emoji_8
            // 
            this.emoji_8.AutoSize = true;
            this.emoji_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emoji_8.ForeColor = System.Drawing.Color.White;
            this.emoji_8.Location = new System.Drawing.Point(86, 89);
            this.emoji_8.Name = "emoji_8";
            this.emoji_8.Size = new System.Drawing.Size(25, 20);
            this.emoji_8.TabIndex = 0;
            this.emoji_8.Text = "←";
            this.emoji_8.Click += new System.EventHandler(this.emoji_8_Click);
            // 
            // emoji_6
            // 
            this.emoji_6.AutoSize = true;
            this.emoji_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emoji_6.ForeColor = System.Drawing.Color.White;
            this.emoji_6.Location = new System.Drawing.Point(16, 88);
            this.emoji_6.Name = "emoji_6";
            this.emoji_6.Size = new System.Drawing.Size(17, 20);
            this.emoji_6.TabIndex = 0;
            this.emoji_6.Text = "↓";
            this.emoji_6.Click += new System.EventHandler(this.emoji_6_Click);
            // 
            // emoji_3
            // 
            this.emoji_3.AutoSize = true;
            this.emoji_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emoji_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emoji_3.Location = new System.Drawing.Point(80, 16);
            this.emoji_3.Name = "emoji_3";
            this.emoji_3.Size = new System.Drawing.Size(33, 31);
            this.emoji_3.TabIndex = 0;
            this.emoji_3.Text = "☼";
            this.emoji_3.Click += new System.EventHandler(this.emoji_3_Click);
            // 
            // emoji_1
            // 
            this.emoji_1.AutoSize = true;
            this.emoji_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emoji_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(61)))));
            this.emoji_1.Location = new System.Drawing.Point(6, 16);
            this.emoji_1.Name = "emoji_1";
            this.emoji_1.Size = new System.Drawing.Size(36, 31);
            this.emoji_1.TabIndex = 0;
            this.emoji_1.Text = "☻";
            this.emoji_1.Click += new System.EventHandler(this.emoji_1_Click);
            // 
            // btn_emoji
            // 
            this.btn_emoji.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_emoji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emoji.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emoji.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(131)))));
            this.btn_emoji.Location = new System.Drawing.Point(187, 312);
            this.btn_emoji.Name = "btn_emoji";
            this.btn_emoji.Size = new System.Drawing.Size(39, 37);
            this.btn_emoji.TabIndex = 18;
            this.btn_emoji.Text = "☻";
            this.btn_emoji.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_emoji.UseVisualStyleBackColor = true;
            this.btn_emoji.Click += new System.EventHandler(this.btn_emoji_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.btn_emoji);
            this.Controls.Add(this.emoji_box);
            this.Controls.Add(this.btn_gosingup);
            this.Controls.Add(this.la_suppass);
            this.Controls.Add(this.la_supemail);
            this.Controls.Add(this.la_supuser);
            this.Controls.Add(this.txt_suppass);
            this.Controls.Add(this.txt_supemail);
            this.Controls.Add(this.txt_supuser);
            this.Controls.Add(this.btn_gologin);
            this.Controls.Add(this.btn_singup);
            this.Controls.Add(this.la_user);
            this.Controls.Add(this.la_pass);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_loginpass);
            this.Controls.Add(this.txt_loginuser);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.box_users);
            this.Controls.Add(this.box_msgs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_send);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.hed_bar.ResumeLayout(false);
            this.hed_bar.PerformLayout();
            this.emoji_box.ResumeLayout(false);
            this.emoji_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel hed_bar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox box_msgs;
        private System.Windows.Forms.ListBox box_users;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label hed_txt;
        private System.Windows.Forms.TextBox txt_loginuser;
        private System.Windows.Forms.TextBox txt_loginpass;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label la_pass;
        private System.Windows.Forms.Label la_user;
        private System.Windows.Forms.Button btn_singup;
        private System.Windows.Forms.TextBox txt_supuser;
        private System.Windows.Forms.TextBox txt_supemail;
        private System.Windows.Forms.TextBox txt_suppass;
        private System.Windows.Forms.Label la_supuser;
        private System.Windows.Forms.Label la_supemail;
        private System.Windows.Forms.Label la_suppass;
        private System.Windows.Forms.Button btn_gologin;
        private System.Windows.Forms.Button btn_gosingup;
        private System.Windows.Forms.Label btn_settings;
        private System.Windows.Forms.Timer timer_update;
        private System.Windows.Forms.GroupBox emoji_box;
        private System.Windows.Forms.Label emoji_9;
        private System.Windows.Forms.Label emoji_4;
        private System.Windows.Forms.Label emoji_7;
        private System.Windows.Forms.Label emoji_2;
        private System.Windows.Forms.Label emoji_10;
        private System.Windows.Forms.Label emoji_5;
        private System.Windows.Forms.Label emoji_8;
        private System.Windows.Forms.Label emoji_6;
        private System.Windows.Forms.Label emoji_3;
        private System.Windows.Forms.Label emoji_1;
        private System.Windows.Forms.Button btn_emoji;
    }
}

