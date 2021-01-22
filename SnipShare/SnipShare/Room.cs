using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnipShare
{
    public class Room
    {
        public string name;
        public bool active;
        public Button button;
        public Room(string name, bool active, Button button)
        {
            this.name = name;
            this.active = active;
            this.button = button;
        }
    }
}
