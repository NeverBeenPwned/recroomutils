
namespace RecRoom_Utils
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
            this.getusername = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accountid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.displayname = new System.Windows.Forms.TextBox();
            this.isjunor = new System.Windows.Forms.TextBox();
            this.createdat = new System.Windows.Forms.TextBox();
            this.worldcreationdate = new System.Windows.Forms.TextBox();
            this.isdevowned = new System.Windows.Forms.TextBox();
            this.MaxPlayers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RoomID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.WorldName = new System.Windows.Forms.TextBox();
            this.GetWorld = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.worldusername = new System.Windows.Forms.TextBox();
            this.worlddisplayname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.plattext = new System.Windows.Forms.TextBox();
            this.consoletext = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.accountidtotarget = new System.Windows.Forms.TextBox();
            this.amountoffriendrequests = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.sendfriendrequests = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.unfriend = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // getusername
            // 
            this.getusername.Location = new System.Drawing.Point(181, 6);
            this.getusername.Name = "getusername";
            this.getusername.Size = new System.Drawing.Size(75, 23);
            this.getusername.TabIndex = 0;
            this.getusername.Text = "Get User";
            this.getusername.UseVisualStyleBackColor = true;
            this.getusername.Click += new System.EventHandler(this.getusername_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(75, 6);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 1;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username :";
            // 
            // accountid
            // 
            this.accountid.Location = new System.Drawing.Point(75, 45);
            this.accountid.Name = "accountid";
            this.accountid.ReadOnly = true;
            this.accountid.Size = new System.Drawing.Size(181, 20);
            this.accountid.TabIndex = 3;
            this.accountid.TextChanged += new System.EventHandler(this.accountid_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Account ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Display Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Is Junior";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "createdAt";
            // 
            // displayname
            // 
            this.displayname.Location = new System.Drawing.Point(74, 71);
            this.displayname.Name = "displayname";
            this.displayname.ReadOnly = true;
            this.displayname.Size = new System.Drawing.Size(181, 20);
            this.displayname.TabIndex = 8;
            this.displayname.TextChanged += new System.EventHandler(this.displayname_TextChanged);
            // 
            // isjunor
            // 
            this.isjunor.Location = new System.Drawing.Point(74, 101);
            this.isjunor.Name = "isjunor";
            this.isjunor.ReadOnly = true;
            this.isjunor.Size = new System.Drawing.Size(181, 20);
            this.isjunor.TabIndex = 9;
            this.isjunor.TextChanged += new System.EventHandler(this.isjunor_TextChanged);
            // 
            // createdat
            // 
            this.createdat.Location = new System.Drawing.Point(73, 127);
            this.createdat.Name = "createdat";
            this.createdat.ReadOnly = true;
            this.createdat.Size = new System.Drawing.Size(182, 20);
            this.createdat.TabIndex = 10;
            this.createdat.TextChanged += new System.EventHandler(this.createdat_TextChanged);
            // 
            // worldcreationdate
            // 
            this.worldcreationdate.Location = new System.Drawing.Point(409, 123);
            this.worldcreationdate.Name = "worldcreationdate";
            this.worldcreationdate.ReadOnly = true;
            this.worldcreationdate.Size = new System.Drawing.Size(182, 20);
            this.worldcreationdate.TabIndex = 21;
            // 
            // isdevowned
            // 
            this.isdevowned.Location = new System.Drawing.Point(409, 97);
            this.isdevowned.Name = "isdevowned";
            this.isdevowned.ReadOnly = true;
            this.isdevowned.Size = new System.Drawing.Size(181, 20);
            this.isdevowned.TabIndex = 20;
            // 
            // MaxPlayers
            // 
            this.MaxPlayers.Location = new System.Drawing.Point(409, 71);
            this.MaxPlayers.Name = "MaxPlayers";
            this.MaxPlayers.ReadOnly = true;
            this.MaxPlayers.Size = new System.Drawing.Size(181, 20);
            this.MaxPlayers.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "createdAt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "IsDeveloperOwned";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "MaxPlayers";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Room ID";
            // 
            // RoomID
            // 
            this.RoomID.Location = new System.Drawing.Point(409, 45);
            this.RoomID.Name = "RoomID";
            this.RoomID.ReadOnly = true;
            this.RoomID.Size = new System.Drawing.Size(181, 20);
            this.RoomID.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Worldname :";
            // 
            // WorldName
            // 
            this.WorldName.Location = new System.Drawing.Point(409, 5);
            this.WorldName.Name = "WorldName";
            this.WorldName.Size = new System.Drawing.Size(100, 20);
            this.WorldName.TabIndex = 12;
            // 
            // GetWorld
            // 
            this.GetWorld.Location = new System.Drawing.Point(515, 3);
            this.GetWorld.Name = "GetWorld";
            this.GetWorld.Size = new System.Drawing.Size(75, 23);
            this.GetWorld.TabIndex = 11;
            this.GetWorld.Text = "Get World";
            this.GetWorld.UseVisualStyleBackColor = true;
            this.GetWorld.Click += new System.EventHandler(this.GetWorld_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "World Creator Username";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(266, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "World Creator DisplayName";
            // 
            // worldusername
            // 
            this.worldusername.Location = new System.Drawing.Point(409, 149);
            this.worldusername.Name = "worldusername";
            this.worldusername.ReadOnly = true;
            this.worldusername.Size = new System.Drawing.Size(182, 20);
            this.worldusername.TabIndex = 24;
            // 
            // worlddisplayname
            // 
            this.worlddisplayname.Location = new System.Drawing.Point(409, 175);
            this.worlddisplayname.Name = "worlddisplayname";
            this.worlddisplayname.ReadOnly = true;
            this.worlddisplayname.Size = new System.Drawing.Size(182, 20);
            this.worlddisplayname.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "platforms";
            // 
            // plattext
            // 
            this.plattext.Location = new System.Drawing.Point(74, 153);
            this.plattext.Name = "plattext";
            this.plattext.ReadOnly = true;
            this.plattext.Size = new System.Drawing.Size(182, 20);
            this.plattext.TabIndex = 27;
            // 
            // consoletext
            // 
            this.consoletext.Location = new System.Drawing.Point(638, 137);
            this.consoletext.Name = "consoletext";
            this.consoletext.ReadOnly = true;
            this.consoletext.Size = new System.Drawing.Size(151, 28);
            this.consoletext.TabIndex = 28;
            this.consoletext.Text = "";
            this.consoletext.TextChanged += new System.EventHandler(this.consoletext_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(661, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Target Account ID";
            // 
            // accountidtotarget
            // 
            this.accountidtotarget.Location = new System.Drawing.Point(638, 19);
            this.accountidtotarget.Name = "accountidtotarget";
            this.accountidtotarget.Size = new System.Drawing.Size(151, 20);
            this.accountidtotarget.TabIndex = 30;
            this.accountidtotarget.TextChanged += new System.EventHandler(this.accountidtotarget_TextChanged);
            // 
            // amountoffriendrequests
            // 
            this.amountoffriendrequests.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.amountoffriendrequests.Location = new System.Drawing.Point(679, 64);
            this.amountoffriendrequests.MaxLength = 9999;
            this.amountoffriendrequests.Name = "amountoffriendrequests";
            this.amountoffriendrequests.Size = new System.Drawing.Size(64, 20);
            this.amountoffriendrequests.TabIndex = 31;
            this.amountoffriendrequests.TextChanged += new System.EventHandler(this.amountoffriendrequests_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(646, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Ammount of Friend Requests";
            // 
            // sendfriendrequests
            // 
            this.sendfriendrequests.Location = new System.Drawing.Point(649, 94);
            this.sendfriendrequests.Name = "sendfriendrequests";
            this.sendfriendrequests.Size = new System.Drawing.Size(130, 23);
            this.sendfriendrequests.TabIndex = 33;
            this.sendfriendrequests.Text = "SendFriendRequests";
            this.sendfriendrequests.UseVisualStyleBackColor = true;
            this.sendfriendrequests.Click += new System.EventHandler(this.sendfriendrequests_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(676, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Debug Console";
            // 
            // unfriend
            // 
            this.unfriend.Location = new System.Drawing.Point(649, 171);
            this.unfriend.Name = "unfriend";
            this.unfriend.Size = new System.Drawing.Size(125, 24);
            this.unfriend.TabIndex = 35;
            this.unfriend.Text = "UnFriend";
            this.unfriend.UseVisualStyleBackColor = true;
            this.unfriend.Click += new System.EventHandler(this.unfriend_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(664, 203);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 17);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "Notification Spam";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(789, 232);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.unfriend);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.sendfriendrequests);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.amountoffriendrequests);
            this.Controls.Add(this.accountidtotarget);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.consoletext);
            this.Controls.Add(this.plattext);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.worlddisplayname);
            this.Controls.Add(this.worldusername);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.worldcreationdate);
            this.Controls.Add(this.isdevowned);
            this.Controls.Add(this.MaxPlayers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RoomID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.WorldName);
            this.Controls.Add(this.GetWorld);
            this.Controls.Add(this.createdat);
            this.Controls.Add(this.isjunor);
            this.Controls.Add(this.displayname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accountid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.getusername);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Form1";
            this.Text = "Rec Room Utils By NeverBeenPwnd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getusername;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accountid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox displayname;
        private System.Windows.Forms.TextBox isjunor;
        private System.Windows.Forms.TextBox createdat;
        private System.Windows.Forms.TextBox worldcreationdate;
        private System.Windows.Forms.TextBox isdevowned;
        private System.Windows.Forms.TextBox MaxPlayers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RoomID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox WorldName;
        private System.Windows.Forms.Button GetWorld;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox worldusername;
        private System.Windows.Forms.TextBox worlddisplayname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox plattext;
        private System.Windows.Forms.RichTextBox consoletext;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox accountidtotarget;
        private System.Windows.Forms.TextBox amountoffriendrequests;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button sendfriendrequests;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button unfriend;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

