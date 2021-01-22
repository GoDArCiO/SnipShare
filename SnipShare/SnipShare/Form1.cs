using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnipShare
{
    public partial class Form1 : Form
    {
        public string url = "http://margasiewicz.pythonanywhere.com/";
        public string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public string userName;
        public int activeRooms;
        public List<Room> roomList=new List<Room>();
        public Form1()
        {
            InitializeComponent();
            InitializeRoomButtons();
            DisbleRoomButtons();

        }

        private void InitializeRoomButtons()
        {

            roomList.Add(new Room("", false, room1));
            roomList.Add(new Room("", false, button1));
            roomList.Add(new Room("", false, button2));
            roomList.Add(new Room("", false, button3));
            roomList.Add(new Room("", false, button4));

            foreach (Room r in roomList)
            {
                r.button.Visible = false;
            }
        }

        private void DisbleRoomButtons()
        {
            foreach (Room r in roomList)
            {
                r.button.Visible = false;
            }

            activeRooms = 0;
        }

        public void DeleteActiveRoom(string roomName)
        {
            foreach (Room r in roomList)
            {
                if (r.name == roomName)
                {
                    r.button.Visible = false;
                    r.active = false;
                    r.name = "";
                }
                
            }

            activeRooms--;
            label1.Text = activeRooms + "/5 rooms";
        }

        public bool CanMakeRoom(string roomName)
        {

            if (activeRooms == 5)
            {
                return false;
            }

            foreach (Room r in roomList)
            {
                if (r.name == roomName)
                {
                    return false;
                }
            }

            return true;
        }

        public void enableNextRoom(string roomName)
        {
            foreach (Room r in roomList)
            {
                if (!r.active)
                {
                    r.name = roomName;
                    r.active = true;
                    r.button.Text = r.name;
                    r.button.Visible = r.active;
                    activeRooms++;
                    label1.Text = activeRooms + "/5 rooms";
                    return;
                }
            }
        }

        private void Room_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2(this));
        }

        private void room1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3(this, roomList[0].name));
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3(this, roomList[1].name));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3(this, roomList[2].name));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3(this, roomList[3].name));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3(this, roomList[4].name));
        }

    }
}
