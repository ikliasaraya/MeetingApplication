using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Timers;

namespace MeetingApplication
{
    public partial class MainForm : Form
    {
        private System.Timers.Timer dataUpdateTimer;
        public MainForm()
        {
            InitializeComponent();



            dataUpdateTimer = new System.Timers.Timer(10000);
            dataUpdateTimer.Elapsed += dataUpdateTimer_Elapsed;
            dataUpdateTimer.AutoReset = true;
            dataUpdateTimer.Enabled = true;

            disableControlsInGroupBox(toplantilar);
            disableControlsInGroupBox(olustur);

        }

        // Control Groupbox

        private void disableControlsInGroupBox(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                control.Enabled = false;
            }
        }

        private void activateControlsInGroupBox(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                control.Enabled = true;
            }
        }

        // Veri senkronizasyonu

        private void dataUpdateTimer_Elapsed(object sender, ElapsedEventArgs e)
        {

            readJsonUsers();
            readJsonMeetings();
            listMeetings();
        }

        // Json islemleri ////////////////////////////////////

        // users oku

        private void readJsonUsers()
        {
            string relativePath = @"..\..\users.json";
            string fullPath = Path.GetFullPath(relativePath);

            if (File.Exists(fullPath))
            {
                string userJson = File.ReadAllText(fullPath);
                users = JsonConvert.DeserializeObject<List<User>>(userJson);
            }
        }

        // meetings oku

        private void readJsonMeetings()
        {
            string relativePath = @"..\..\meetings.json";
            string fullPath = Path.GetFullPath(relativePath);

            if (File.Exists(fullPath))
            {
                string meetingJson = File.ReadAllText(fullPath);
                meetings = JsonConvert.DeserializeObject<List<Meeting>>(meetingJson);
            }
        }


        // users yaz
        private void writeJsonUsers() {
            string relativePath = @"..\..\users.json";
            string fullPath = Path.GetFullPath(relativePath);
            string userJson = JsonConvert.SerializeObject(users);
            File.WriteAllText(fullPath, userJson);
        }

        // meetings yaz

        private void writeJsonMeetings() {
            string relativePath = @"..\..\meetings.json";
            string fullPath = Path.GetFullPath(relativePath);
            string meetingJson = JsonConvert.SerializeObject(meetings);
            File.WriteAllText(fullPath, meetingJson);
        }

        // kullanici kayit kontrol

        private bool userExists(string userName)
        {
            return users.Any(user => user.name == userName);
        }


        // Kullanicilar ve toplantilar
        List<Meeting> meetings = new List<Meeting>();
        List<User> users = new List<User>();

        // COMPONENT FONKSIYONLARII ///////////////////////////////////////////////
        
        // Toplantilar listView
        private void listMeetings()
        {
            if (mList.InvokeRequired)
            {
                mList.Invoke(new Action(listMeetings));
            }
            else
            {
                mList.Items.Clear();
                string activeUser = nameTxt.Text;
                foreach (Meeting meeting in meetings)
                {
                    if (meeting.users.Any(user => user.name == activeUser))
                    {
                        ListViewItem item = new ListViewItem(meeting.id);
                        item.SubItems.Add(meeting.title);
                        item.SubItems.Add(meeting.date.ToString("yyyy-MM-dd"));
                        item.SubItems.Add(meeting.desc);
                        string allUserNames = string.Join(", ", meeting.users.Select(user => user.name));
                        item.SubItems.Add(allUserNames);
                        mList.Items.Add(item);
                    }
                }
            }
        }

        private void selectUser()
    
        {
            selectUserBox.Items.Clear();
            foreach (User user in users)
            {
                readJsonUsers();
                selectUserBox.Items.Add(user.name);
            }
        }


        private void createBtn_Click(object sender, EventArgs e)
        {
            // inv code
            Random random = new Random();
            int randomNum = random.Next(1000000, 10000000);
            string invCode = randomNum.ToString("D6");
            // meeting nesne
            Meeting newMeeting = new Meeting(invCode,titleTxt.Text,dateCalender.SelectionStart,descTxt.Text);
            
            foreach (var item in selectUserBox.CheckedItems)
            {
                string selectedUserName = item.ToString();
                User selectedUser = users.Find(user => user.name == selectedUserName);

                if (selectedUser != null)
                {
                    newMeeting.users.Add(selectedUser);
                }
            }

            meetings.Add(newMeeting);
            writeJsonMeetings();
            listMeetings();

        }


        private void nameBtn_Click(object sender, EventArgs e)
        {
            string userName = nameTxt.Text;

            if (!userExists(userName))
            {
                User newUser = new User(userName);
                users.Add(newUser);
                writeJsonUsers();
                readJsonUsers();
                readJsonMeetings();
                nameTxt.Enabled = false;
                nameBtn.Enabled = false;
                selectUser();
                activateControlsInGroupBox(toplantilar);
                activateControlsInGroupBox(olustur);
            }
            else
            {
                User newUser = new User(userName);
                users.Add(newUser);
                readJsonUsers();
                readJsonMeetings();
                nameTxt.Enabled = false;
                nameBtn.Enabled = false;
                selectUser();
                activateControlsInGroupBox(toplantilar);
                activateControlsInGroupBox(olustur);
            }
            dataUpdateTimer.Start();
        }



        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchTxt.Text.ToLower();

            mList.Items.Clear();

            foreach (Meeting item in meetings)
            {
                if (item.title.ToLower().Contains(searchTerm) || item.desc.ToLower().Contains(searchTerm) || item.date.ToString().ToLower().Contains(searchTerm))
                {
                    ListViewItem item1 = new ListViewItem(item.id);
                    item1.SubItems.Add(item.title);
                    item1.SubItems.Add(item.date.ToString("yyyy-MM-dd"));
                    item1.SubItems.Add(item.desc);
                    mList.Items.Add(item1);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            readJsonUsers();
            readJsonMeetings();
        }


        private void createBtn_MouseEnter(object sender, EventArgs e)
        {
            int activeUser = selectUserBox.FindStringExact(nameTxt.Text);
            if (activeUser != ListBox.NoMatches)
            {
                selectUserBox.SetItemChecked(activeUser, true);
            }
        }

        private void titleTxt_MouseEnter(object sender, EventArgs e)
        {
            selectUser();
        }

        private void descTxt_MouseEnter(object sender, EventArgs e)
        {
            selectUser();
        }

        private void dateCalender_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectUser();
        }

        private void joinBtn_Click(object sender, EventArgs e)
        {
            readJsonMeetings();
            string activeUser = nameTxt.Text;
            string selectedMeetingCode = invCodeTxt.Text;

            Meeting selectedMeeting = meetings.FirstOrDefault(meeting => meeting.id == selectedMeetingCode);

            if (selectedMeeting != null)
            {
                if (!selectedMeeting.users.Any(user=>user.name == activeUser))
                {
                    User user = users.FirstOrDefault(u => u.name == activeUser);

                    if (user != null)
                    {
                        selectedMeeting.users.Add(user);
                        writeJsonMeetings();
                        listMeetings();
                    }
                }
            }
        }

        private void mList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (e.IsSelected)
            {
                string selectedMeetingCode = e.Item.SubItems[0].Text;
                Meeting selectedMeeting = meetings.FirstOrDefault(meeting => meeting.id == selectedMeetingCode);

                if (selectedMeeting != null) {
                    using (meetingDetailsForm detailsForm = new meetingDetailsForm(selectedMeeting,nameTxt.Text))
                    {
                        if (detailsForm.ShowDialog() == DialogResult.OK)
                        {
                            meetings.Remove(selectedMeeting);
                            writeJsonMeetings();
                            listMeetings();
                        }
                    }
                }

            }

        }
    }
}
