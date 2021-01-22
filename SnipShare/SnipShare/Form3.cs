using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;

namespace SnipShare
{


    public partial class Form3 : Form
    {
        public Form1 menu;

        public string roomName;
        public Form3(Form1 menu,string roomName)
        {
            InitializeComponent();
            this.menu = menu;
            this.roomName = roomName;
        }

        private void download_Click(object sender, EventArgs e)
        {
            var json="";
            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(menu.url + "message/"+roomName+"/all/login");
            }

            Console.WriteLine("jsonString" + json);
            //JsonMsgGet wf = JsonSerializer.Deserialize<JsonMsgGet>(json);
            downText.Text = json;
        }

        private async void upload_Click(object sender, EventArgs e)
        {
            string msg = upText.Text;
            string author = "artur";
            
            JsonMsgPost wf = new JsonMsgPost(author, msg,roomName);
            string jsonString = JsonSerializer.Serialize(wf);
            

            using (var client = new HttpClient())
            {
                var response2 = await client.PostAsync(GetPostString(),new StringContent(jsonString, Encoding.UTF8, "application/json"));
                Console.WriteLine(response2);
            }

        }

        private void InitializeTextBox()
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private string GetPostString()
        {
            return menu.url + "message";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu.DeleteActiveRoom(roomName);
        }
    }

    public class JsonMsgPost
    {

        public string author { get; set; }
        public string msg { get; set; }
        public string roomname { get; set; }

        public JsonMsgPost(string author, string msg,string roomName)
        {
            this.author = author;
            this.msg = msg;
            this.roomname = roomName;
        }

        public string toString()
        {
            return author + msg + roomname;
        }

    }
    //"author":"artur","id":1,"msg":"asd","seen":"{\"username\": [\"elo\", \"login\"]}","title":"test"
    public class JsonMsgGet
    {

        public string author { get; set; }
        public int id { get; set; }
        public string msg { get; set; }


        public string toString()
        {
            return author +id+msg+msg;
        }

    }

}
