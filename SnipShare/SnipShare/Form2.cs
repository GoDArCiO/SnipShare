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
    public partial class Form2 : Form
    {
        public Form1 menu;
        public Form2(Form1 menu)
        {
            InitializeComponent();
            label1.Text = "";
            this.menu = menu;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (menu.CanMakeRoom(roomCodeInput.Text))
            {
                menu.enableNextRoom(GetRoomName(roomCodeInput.Text));
                label1.Text = "";
            }
            else
            {
                label1.Text = "Invalid Name!";
            }
            
            if (menu.activeRooms == 5)
            {
                label1.Text = "Max Rooms!";
            }
            
        }

        private void roomCodeInput_TextChanged(object sender, EventArgs e)
        {

        }


        private string GetRoomName(string code)
        {
            string userName=code;

            return userName;
        }


    }
}
