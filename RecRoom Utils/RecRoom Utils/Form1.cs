using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Newtonsoft.Json;
using DateTimeConvert;
using Exploits;
namespace RecRoom_Utils
{
    public partial class Form1 : Form
    {
        private Thread Thread;

        public Form1()
        {
            InitializeComponent();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
        private void getusername_Click(object sender, EventArgs e)
        {
            string user = username.Text;

            int Accountid;

            int Platform;

            string DisplayName;

            string CreatedAt;

            bool IsJunior;

            string userinfo = http.http.GetUserInfo(user);
            if (userinfo != null)
            {
                Accountid = JsonConvert.DeserializeObject<userinfoget>(userinfo).accountid;
                DisplayName = JsonConvert.DeserializeObject<userinfoget>(userinfo).displayName;
                CreatedAt = JsonConvert.DeserializeObject<userinfoget>(userinfo).createdAt;
                IsJunior = JsonConvert.DeserializeObject<userinfoget>(userinfo).isJunior;
                Platform = JsonConvert.DeserializeObject<userinfoget>(userinfo).platforms;

                string datatime = "Date: " + DateTimeConvert.DateTimeConvert.betterdate(CreatedAt) + " Time: " + DateTimeConvert.DateTimeConvert.bettertime(CreatedAt);
                
                accountid.Text = Convert.ToString(Accountid);
                displayname.Text = Convert.ToString(DisplayName);
                //createdat.Text = Convert.ToString(CreatedAt);
                createdat.Text = Convert.ToString(datatime);
                isjunor.Text = Convert.ToString(IsJunior);
                if (Platform == 1)
                {
                    plattext.Text = "Pc";
                }
                if (Platform == 65)
                {
                    plattext.Text = "Pc and Mobile";
                }
                if (Platform == 0)
                {
                    plattext.Text = "Quest 2";
                }

            }
            

            
           

        }
        private void GetWorld_Click(object sender, EventArgs e)
        {
            
            string world = WorldName.Text;
            string roomid;
            int maxPlayers;
            string Worldcreationdate;
            bool IsDevOwned;
            int worldmakerid;
            string worldmakerusername;
            string worldmakerdisplayname;
            string worldinfo = http.http.GetWorldInfo(world);
            if (worldinfo != null)
            {
                roomid = JsonConvert.DeserializeObject<worldinfoget>(worldinfo).RoomId;
                maxPlayers = JsonConvert.DeserializeObject<worldinfoget>(worldinfo).MaxPlayers;
                Worldcreationdate = JsonConvert.DeserializeObject<worldinfoget>(worldinfo).CreatedAt;
                IsDevOwned = JsonConvert.DeserializeObject<worldinfoget>(worldinfo).IsDeveloperOwned;
                worldmakerid = JsonConvert.DeserializeObject<worldinfoget>(worldinfo).CreatorAccountId;


                string convertdate = "Date: " + DateTimeConvert.DateTimeConvert.betterdate(Worldcreationdate) + " Time: " + DateTimeConvert.DateTimeConvert.bettertime(Worldcreationdate); ;
                
                RoomID.Text = Convert.ToString(roomid);
                MaxPlayers.Text = Convert.ToString(maxPlayers);
                worldcreationdate.Text = Convert.ToString(convertdate);
                isdevowned.Text = Convert.ToString(IsDevOwned);
                string useridtoaccount = http.http.ConvertIDtoInfo(worldmakerid);

                worldmakerusername = JsonConvert.DeserializeObject<worldmakerinfo>(useridtoaccount).username;
                worldmakerdisplayname = JsonConvert.DeserializeObject<worldmakerinfo>(useridtoaccount).displayName;

                worldusername.Text = worldmakerusername;
                worlddisplayname.Text = worldmakerdisplayname;
                



            }
            
        }
        private void sendfriendrequests_Click(object sender, EventArgs e)
        {
            string targetid = accountidtotarget.Text;
            if (amountoffriendrequests.Text == "")
            {
                consoletext.Text = "Amount Cant Be Null";
            }
            else
            {
                int amount = Convert.ToInt32(amountoffriendrequests.Text);
                consoletext.Text = "TargetID and Amount Succesfully Converted!";
                for (int i = 0; i < amount; i++)
                {
                    string token = http.http.TokenGenerator(i);
                    consoletext.Text = "Token Generator Generated : " + token;
                    Exploits.Exploits.SendFriendRequest(targetid, token);
                }
            }   consoletext.Text = "Operation Done!";
            
        }
        private void unfriend_Click(object sender, EventArgs e)
        {
            string targetid = accountidtotarget.Text;
            int amount = Convert.ToInt32(amountoffriendrequests.Text);
            consoletext.Text = "UnFriend Begins!";
            for (int i = 0; i < amount; i++)
            {
                string token = http.http.TokenGenerator(i);
                consoletext.Text = "UnFriend " + i + " Done!";
                Exploits.Exploits.DeleteFriend(targetid, token);
            }
        }
        
        private void accountid_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayname_TextChanged(object sender, EventArgs e)
        {

        }

        private void isjunor_TextChanged(object sender, EventArgs e)
        {

        }

        private void createdat_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
                    }

        private void consoletext_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void accountidtotarget_TextChanged(object sender, EventArgs e)
        {

        }

        private void amountoffriendrequests_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
               
                Thread = new Thread(spam) { IsBackground = true };
                Thread.Start();
            }
            else if(checkBox1.Checked == false)
            {
                Thread.Interrupt();
            }
        }
        private void spam()
        {
            for (; ; )
            {
                string targetid = accountidtotarget.Text;
                int amount = Convert.ToInt32(amountoffriendrequests.Text);

                for (int i = 0; i < amount; i++)
                {
                    string token = http.http.TokenGenerator(i);
                    Exploits.Exploits.SendFriendRequest(targetid, token);
                }
                for (int i = 0; i < amount; i++)
                {
                    string token = http.http.TokenGenerator(i);
                    Exploits.Exploits.DeleteFriend(targetid, token);
                }
            }
        }
    }
    public class userinfoget
    {
        public int accountid { get; set; }
        public string displayName { get; set; }
        public string createdAt { get; set; }
        public bool isJunior { get; set; }
        public int platforms { get; set; }
    }
    public class worldinfoget
    {
        public string RoomId { get; set; }
        public int MaxPlayers { get; set; }
        public string CreatedAt { get; set; }
        public bool IsDeveloperOwned { get; set; }
        public int CreatorAccountId { get; set; }
    }
    public class worldmakerinfo
    {
        public string username { get; set; }
        public string displayName { get; set; }
    }

}
