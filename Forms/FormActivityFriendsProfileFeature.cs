using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using B22_Ex03.FactoryMethod;
using B22_Ex03.Features;
using B22_Ex03.Models;
using FacebookWrapper;

namespace B22_Ex03.Forms
{
    public partial class FormActivityFriendsProfileFeature : Form, IFeatures
    {
        private readonly ActivityFriendsProfileFeature r_ActivityFriendsProfileFeature;

        public FormActivityFriendsProfileFeature(LoginResult i_LoginResult)
        {
            r_ActivityFriendsProfileFeature = new ActivityFriendsProfileFeature(i_LoginResult);
            InitializeComponent();
            CenterToScreen();
            loadFriendsIntoComboBox();
        }

        public void RunFeature()
        {
            ShowDialog();
        }

        private void loadFriendsIntoComboBox()
        {
            comboBoxFakeFriendList.Items.Clear();
            List<string> fakeFriends = r_ActivityFriendsProfileFeature.GetFriends();

            foreach(string fakeFriend in fakeFriends)
            {
                comboBoxFakeFriendList.Items.Add(fakeFriend);
            }
        }

        private void buttonViewActivityFriend_Click(object i_Sender, System.EventArgs i_Event)
        {
            listBoxFriendActivities.Items.Clear();
            string friendName = comboBoxFakeFriendList.SelectedItem.ToString();
            FakeActivityProfile fakeActivityProfile = r_ActivityFriendsProfileFeature.GetFriendActivities(friendName);

            new Thread(() => loadFriendActivitiesToListBox(fakeActivityProfile)).Start();
        }

        private void loadFriendActivitiesToListBox(FakeActivityProfile i_FakeActivityProfile)
        {
            for (int i = 0; i < i_FakeActivityProfile.CountActivity; i++)
            {
                string item = string.Join(", ",
                    i_FakeActivityProfile.NameFrom,
                    i_FakeActivityProfile.ActivityOption[i].ToString(),
                    i_FakeActivityProfile.ActivityToData[i].ToString(),
                    i_FakeActivityProfile.NameTo[i]);

                listBoxFriendActivities.Invoke(new Action(() => listBoxFriendActivities.Items.Add(item)));
            }
        }
    }
}
