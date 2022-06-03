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
    public partial class FormWhoWatchMyProfileFeature : Form, IFeatures
    {
        private readonly WhoWatchMyProfileFeature r_WhoWatchMyProfileFeature;

        public FormWhoWatchMyProfileFeature(LoginResult i_LoginResult)
        {
            r_WhoWatchMyProfileFeature = new WhoWatchMyProfileFeature(i_LoginResult);
            InitializeComponent();
            CenterToScreen();
        }
        public void RunFeature()
        {
            ShowDialog();
        }

        private void linkLabelWhoFetchWatchMyProfile_LinkClicked(object i_Sender, LinkLabelLinkClickedEventArgs i_Event)
        {
            listBoxWhoWatchMeProfile.Items.Clear();
            List<FakeProfile> fakeDataModel = r_WhoWatchMyProfileFeature.WhoWatchMeProfile();

            new Thread(() => loadWhoWatchMeProfileToListBox(fakeDataModel)).Start();
        }

        private void loadWhoWatchMeProfileToListBox(List<FakeProfile> i_FakeProfileDataModels)
        {
            foreach (FakeProfile dataModel in i_FakeProfileDataModels)
            {
                listBoxWhoWatchMeProfile.Invoke(new Action(() => listBoxWhoWatchMeProfile.Items.Add(dataModel)));
            }
        }
    }
}
