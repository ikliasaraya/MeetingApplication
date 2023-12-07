using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApplication
{
    public class Meeting
    {
        public string id { get; set; }
        public string title{ get; set; }
        public DateTime date { get; set; }
        public string desc { get; set; }
        public List<User> users { get; set; }

        public Meeting(string id, string title, DateTime date, string desc) {
            this.id = id;
            this.title = title;
            this.date = date;
            this.desc = desc;
            this.users = new List<User>();
        }

    }
}
