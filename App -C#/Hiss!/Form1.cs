using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;

namespace Hiss_
{
    public partial class Form1 : Form
    {
        // Start Move $
        public bool Drag = false;
        public int MouseX = 0;
        public int MouseY = 0;
        // End Move $

        // Start Config $
        public string server_url = "http://localhost/v1.0" + "/";
        public string token_file_name = "Config.Data";
        // End Config $

        // Start Hiss! Gap $
        public string token;
        public bool user_login = false;
        public string user_id;
        public string token_file_tmp;
        public bool update;
        public int update_id = 0;
        public bool notification = false;
        // End Hiss! Gap $

        public Form1()
        {
            InitializeComponent();
        }

        // Start Post
        string Post(string purl, string pdta)
        {
            WebClient wc = new WebClient();
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            string HtmlResult = wc.UploadString(purl, pdta);
            return HtmlResult;
        }
        // End Post

        // Start Base64Encode
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        // End Base64Encode

        // Start Base64Decode 
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        // End Base64Decode

        // Start Function Get Server - And Send Data 
        // Get Login - Token
        public static bool login_token(string server_ads,string token_user)
        {
            WebClient wc = new WebClient();
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            string chek_login =  wc.UploadString(server_ads + "action.php?com=login1", "token="+token_user);
            if (chek_login == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        // Get Login - User And Pass
        public static bool login_up(string server_ads, string user, string pass)
        {
            WebClient wc = new WebClient();
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            string chek_login = wc.UploadString(server_ads + "action.php?com=login2", "user="+ user + "&pass=" + pass );
            if (chek_login == "1")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // Get Token Server
        public static string get_token_server(string server_ads, string user, string pass)
        {
            WebClient wc = new WebClient();
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            string get_data = wc.UploadString(server_ads + "action.php?com=gettoken", "user=" + user + "&pass=" + pass);
            if (get_data != "0")
            {
                return get_data;
            }
            else
            {
                return "0";
            }

        }
        // Get User id U-P Server
        public static string get_user_id1(string server_ads, string token)
        {
            WebClient wc = new WebClient();
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            string get_data = wc.UploadString(server_ads + "action.php?com=userid1", "token=" + token);
            if (get_data != "0")
            {
                get_data = get_data.Replace("\n", String.Empty);
                get_data = get_data.Replace("\r", String.Empty);
                return get_data.Replace("\t", String.Empty);
            }
            else
            {
                return "0";
            }

        }
        // Get User id U-P Server
        public static string get_user_id2(string server_ads, string user, string pass)
        {
            WebClient wc = new WebClient();
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            string get_data = wc.UploadString(server_ads + "action.php?com=userid2", "user=" + user + "&pass=" + pass);
            if (get_data != "0")
            {
                get_data = get_data.Replace("\n", String.Empty);
                get_data = get_data.Replace("\r", String.Empty);
                return get_data.Replace("\t", String.Empty);
            }
            else
            {
                return "0";
            }

        }
        // Get Login - User And Pass
        public static bool singup(string server_ads, string user, string email,string pass)
        {
            WebClient wc = new WebClient();
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            string get_singup = wc.UploadString(server_ads + "action.php?com=singup", "user=" + user + "&email=" + email + "&pass=" + pass);
            if (get_singup == "1")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // Get Update Count
        public static int get_update_count(string server_ads, string forum)
            {
                WebClient wc = new WebClient();
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string get_data = wc.UploadString(server_ads + "action.php?com=update&d=update", "forum=" + forum);
                if (get_data != "0")
                {
                    return Int32.Parse(get_data);
                }
                else {  return 0; }
            }
        // Get New Msg
        public static string get_new_msg(string server_ads, string forum,int id)
        {
            WebClient wc = new WebClient();
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            string get_data = wc.UploadString(server_ads + "action.php?com=update&d=log", "forum=" + forum + "&id=" + id);
            get_data = get_data.Replace("\n", String.Empty);
            get_data = get_data.Replace("\r", String.Empty);
            return get_data.Replace("\t", String.Empty);
           
        }
        // Send Msg
        public static bool send_msg(string server_ads, string forum_id ,string id,string txt_msg)
        {
            WebClient wc = new WebClient();
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            string get_data = wc.UploadString(server_ads + "action.php?com=chat", "forum=" + forum_id + "&id=" + id + "&msg="+ txt_msg);
            if (get_data == "0")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // End Function Get Server

        // Start Dl line
        public static string rline(string txt)
        {
            txt = txt.Replace("\n", String.Empty);
            txt = txt.Replace("\r", String.Empty);
            return txt.Replace("\t", String.Empty);
        }
        //End Dl Line

        // start Main Visible And Hide
        private void Show_main()
        {
            box_users.Visible = true;
            box_msgs.Visible = true;
            txt_msg.Visible = true;
            btn_send.Visible = true;
            btn_emoji.Visible = true;

        }
        private void Hide_main()
        {
            box_users.Visible = false;
            box_msgs.Visible = false;
            txt_msg.Visible = false;
            btn_send.Visible = false;
            btn_emoji.Visible = false;

        }
        // End Main Visible Hide

        // Start Login Visible Hide
        private void Show_login()
        {
            la_user.Visible = true;
            txt_loginuser.Visible = true;
            la_pass.Visible = true;
            txt_loginpass.Visible = true;
            btn_login.Visible = true;
            btn_gosingup.Visible = true;
        }
        private void Hide_login()
        {
            la_user.Visible = false;
            txt_loginuser.Visible = false;
            la_pass.Visible = false;
            txt_loginpass.Visible = false;
            btn_login.Visible = false;
            btn_gosingup.Visible = false;
        }
        // End Login Visible Hide

        // Start Singup Visible Hide
        private void Show_singup()
        {
            la_supuser.Visible = true;
            txt_supuser.Visible = true;
            la_supemail.Visible = true;
            txt_supemail.Visible = true;
            la_suppass.Visible = true;
            txt_suppass.Visible = true;
            btn_singup.Visible = true;
            btn_gologin.Visible = true;
        }
        private void Hide_singup()
        {
            la_supuser.Visible = false;
            txt_supuser.Visible = false;
            la_supemail.Visible = false;
            txt_supemail.Visible = false;
            la_suppass.Visible = false;
            txt_suppass.Visible = false;
            btn_singup.Visible = false;
            btn_gologin.Visible = false;
        }
        // End Singup Visible Hide
       

        // Start Load Main
        private void Form1_Load(object sender, EventArgs e)
        {
            timer_update.Enabled = true;
            Hide_main();
            Hide_login();
            Hide_singup();
            emoji_box.Visible = false;
            btn_settings.Visible = false;
            token_file_tmp = Base64Encode(token_file_name);
            if (File.Exists(@"C:\ProgramData\Hiss! Gap\" + token_file_tmp)) // Check Exists File
            {
                
                token = File.ReadAllText(@"C:\ProgramData\Hiss! Gap\" + token_file_tmp); // Get Config File
                if (token != string.Empty) // Check Empty File
                {
                    try
                    {
                        bool get_login = login_token(server_url, token);
                        if (get_login) // Get login And Send Data
                        {
                            user_id = get_user_id1(server_url, token);
                            user_login = true;
                            Hide_login();
                            Show_main();
                            txt_msg.Focus();
                        }
                        else
                        {
                            Show_login();
                            MessageBox.Show("Login Error !","Hiss! Message",MessageBoxButtons.OK,MessageBoxIcon.Warning); // Show Login Error Message
                        } // Get login And Send Data
                    }
                    catch
                    {
                        Application.Exit();
                    }
                }
                else {
                    Show_login();
                  // MessageBox.Show("Login Error !", "Hiss! Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Show Login Error Message
                } // End Check Empty File
            }else
            {
                Show_login();
                if (!Directory.Exists(@"C:\ProgramData"))
                {
                    Directory.CreateDirectory(@"C:\ProgramData");
                }
                if (!Directory.Exists(@"C:\ProgramData\Hiss! Gap"))
                {
                    Directory.CreateDirectory(@"C:\ProgramData\Hiss! Gap");
                }
                File.CreateText(@"C:\ProgramData\Hiss! Gap\"+token_file_tmp);
            }// End Check Exists File

       


        }
        // End Load Main

        // Start Login
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_loginuser.Text != string.Empty && txt_loginpass.Text != string.Empty)
            {
                try
                {
                    bool get_login = login_up(server_url, txt_loginuser.Text, txt_loginpass.Text);
                    if (get_login) // Get login And Send Data
                    {
                        user_login = true;
                        user_id = get_user_id2(server_url, txt_loginuser.Text, txt_loginpass.Text);
                        string gettoken = get_token_server(server_url, txt_loginuser.Text, txt_loginpass.Text);
                        File.WriteAllText(@"C:\ProgramData\Hiss! Gap\" + token_file_tmp, gettoken);
                        Hide_login();
                        Show_main();
                        txt_msg.Focus();
                    }
                    else
                    {
                        Show_login();
                      MessageBox.Show("Login Error !","Hiss! Message",MessageBoxButtons.OK,MessageBoxIcon.Warning); // Show Login Error Message
                    } // Get login And Send Data
                }
                catch
                {
                    Application.Exit();
                }
            }
            else {

            }
        }
        // End Login 

        // Start Singup
        private void btn_singup_Click(object sender, EventArgs e)
        {
            if (txt_supuser.Text != string.Empty && txt_supemail.Text != string.Empty && txt_suppass.Text != string.Empty)
            {
                try
                {
                    bool get_singup = singup(server_url, txt_supuser.Text, txt_supemail.Text,txt_suppass.Text);
                    if (get_singup) // Get Singup And Send Data
                    {
                        user_login = true;
                        user_id = get_user_id2(server_url, txt_supuser.Text, txt_suppass.Text);
                        string gettoken = get_token_server(server_url, txt_supuser.Text, txt_suppass.Text);
                        File.WriteAllText(@"C:\ProgramData\Hiss! Gap\" + token_file_tmp, gettoken);
                        Hide_singup();
                        Show_main();
                        txt_msg.Focus();
                    }
                    else
                    {
                        Show_login();
                        MessageBox.Show("Singup Error !", "Hiss! Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Show Login Error Message
                    } // Get login And Send Data
                }
                catch
                {
                    Application.Exit();
                }
            }
            else { 

                }
        }
        // End Singup

        // Start Update Data
        private void timer_update_Tick(object sender, EventArgs e)
        {
            // Start Ping
            //Ping ping = new Ping();
            //PingReply pingStatus = ping.Send("4.2.2.4"); // Check Connect Internet
            //if (pingStatus.Status == IPStatus.Success){update = true; } else{ update = false; }
            // End Ping

            // Start Update Msg And Get New Msg
            if ((user_login == true))
            {
                try
                {
                    int data = get_update_count(server_url, "1");
                    if (update_id < data)
                    {
                        int all_update = data - update_id;
                        for (int z = update_id; z <= data - 1; z++)
                        {
                            string get_msg = get_new_msg(server_url, "1", z);
                            string utf8_String = get_msg;
                            byte[] bytes = Encoding.Default.GetBytes(utf8_String);
                            utf8_String = Encoding.UTF8.GetString(bytes);
                            box_msgs.Items.Add(utf8_String);
                            box_msgs.SelectedIndex = box_msgs.Items.Count - 1;
                            update_id = update_id + 1;
                            string aa = String.Join("", utf8_String);
                            string[] pieces = aa.Split(new string[] { " : " }, StringSplitOptions.None);
                            if (rline(pieces[0]) != rline(user_id) && notification == true)
                            {
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                                player.SoundLocation = "notification.wav";
                                player.Play();
                            }

                        }
                        notification = true;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
            // End Update Msg And Get New Msg
        }
        // End Update Data

        // Start Send MSG
        private void btn_send_Click(object sender, EventArgs e)
        {
            emoji_box.Visible = false;
            if (txt_msg.Text != string.Empty)
            {
                bool ok_send = send_msg(server_url, "1", user_id, Base64Encode(txt_msg.Text));
                txt_msg.Text = string.Empty;

                //box_users.Items.Add("Reuest :"+ ok_send);
                txt_msg.Focus();
            }

        }

        private void btn_emoji_Click(object sender, EventArgs e)
        {
            if (emoji_box.Visible == false)
            {
                emoji_box.Visible = true;
            }
            else
            {
                emoji_box.Visible = false;
            }
        }
        // End Semd MSG 
        // Start Go Singup
        private void btn_gosingup_Click(object sender, EventArgs e)
        {
            Hide_login();
            Show_singup();
        }
        // End Go Singup

        // Start Go Login
        private void btn_gologin_Click(object sender, EventArgs e)
        {
            Hide_singup();
            Show_login();
        }
        // End Go Login

        // Start Exit Btn
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // End Exit Btn

        // Start Main Move
        private void Mouse(string Action)
        {
            if (Action == "MDown")
            {
                MouseX = System.Windows.Forms.Cursor.Position.X - this.Left;
                MouseY = System.Windows.Forms.Cursor.Position.Y - this.Top;
                Drag = true;
            }
            else if (Action == "MUp") { Drag = false; }
            else if (Action == "MMove")
            {
                if (Drag)
                {
                    this.Left = System.Windows.Forms.Cursor.Position.X - MouseX;
                    this.Top = System.Windows.Forms.Cursor.Position.Y - MouseY;
                }
            }
        }
        private void hed_bar_MouseDown(object sender, MouseEventArgs e){ Mouse("MDown"); }
        private void hed_bar_MouseUp(object sender, MouseEventArgs e){ Mouse("MUp"); }
        private void hed_bar_MouseMove(object sender, MouseEventArgs e){ Mouse("MMove"); }
        // End Main Move
        // Start Emoji Add MSG
        private void emoji_1_Click(object sender, EventArgs e)
        {
            txt_msg.Text = txt_msg.Text + "☻";
           
        }

        private void emoji_2_Click(object sender, EventArgs e)
        {
            txt_msg.Text = txt_msg.Text + "♥";
         
        }

        private void emoji_3_Click(object sender, EventArgs e)
        {
            txt_msg.Text = txt_msg.Text + "☼";
           
        }

        private void emoji_4_Click(object sender, EventArgs e)
        {
            txt_msg.Text = txt_msg.Text + "♫";
           
        }

        private void emoji_5_Click(object sender, EventArgs e)
        {
            txt_msg.Text = txt_msg.Text + "☺";
          
        }

        private void emoji_6_Click(object sender, EventArgs e)
        {
            txt_msg.Text = txt_msg.Text + "↓";
          
        }

        private void emoji_7_Click(object sender, EventArgs e)
        {
            txt_msg.Text = txt_msg.Text + "↑";
            
        }

        private void emoji_8_Click(object sender, EventArgs e)
        {
            txt_msg.Text = txt_msg.Text + "←";
            
        }

        private void emoji_9_Click(object sender, EventArgs e)
        {
            txt_msg.Text = txt_msg.Text + "→";
           
        }

        private void emoji_10_Click(object sender, EventArgs e)
        {
            txt_msg.Text = txt_msg.Text + "♠";
          
        }

        private void txt_msg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                emoji_box.Visible = false;
                if (txt_msg.Text != string.Empty)
                {
                    bool ok_send = send_msg(server_url, "1", user_id, Base64Encode(txt_msg.Text));
                    txt_msg.Text = string.Empty;
                    txt_msg.Focus();
                    //box_users.Items.Add("Reuest :"+ ok_send);

                }
            }
        }

        private void txt_msg_Click(object sender, EventArgs e)
        {
            emoji_box.Visible = false;
        }

        // End Emoji Add MSG
    }
}
