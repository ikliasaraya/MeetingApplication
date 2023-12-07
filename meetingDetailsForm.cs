using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingApplication
{
    public partial class meetingDetailsForm : Form
    {
        private Meeting meeting;
        private string activeUser;
        public meetingDetailsForm(Meeting meeting, string activeUser)
        {
            InitializeComponent();
            this.meeting = meeting;

            string info = $"Toplantı Kodu: {meeting.id}\nBaşlık: {meeting.title}\nTarih: {meeting.date.ToString("yyyy-MM-dd")}\nAçıklama: {meeting.desc}\nKatılımcılar: {string.Join(", ", meeting.users.Select(user => user.name))}";
            meetingInfo.Text = info;
            this.activeUser = activeUser;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.OK;
            Close();
        }

        private void leaveBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
