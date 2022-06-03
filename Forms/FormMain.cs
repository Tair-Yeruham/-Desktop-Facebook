using System;
using System.Collections.Generic;
using System.Windows.Forms;
using B22_Ex03.Enum;
using B22_Ex03.Facade;
using B22_Ex03.FactoryMethod;
using FacebookWrapper;

namespace B22_Ex03.Forms
{
    public partial class FormMain : Form
    {
        private readonly LoginFacade r_LoginFacade;
        private readonly FeatureFactory r_FeatureFactory;
        private Dictionary<eFeatureOption, Action> m_FeaturesOptions;
        private LoginResult m_LoginResult;

        public FormMain()
        {
            r_LoginFacade = new LoginFacade();
            r_FeatureFactory = new FeatureFactory();
            InitializeComponent();
            loadFeaturesOptions();
            FacebookService.s_CollectionLimit = 100;
        }

        private void loadFeaturesOptions()
        {
            m_FeaturesOptions = new Dictionary<eFeatureOption, Action>()
            {
                { eFeatureOption.SearchPostAndShowDetails, () => displayFeature(eFeatureOption.SearchPostAndShowDetails) },
                { eFeatureOption.WhoWatchMyProfile, () => displayFeature(eFeatureOption.WhoWatchMyProfile) },
                { eFeatureOption.ActivityFriendsProfile, () => displayFeature(eFeatureOption.ActivityFriendsProfile) },
            };
            comboBoxFeatuersOptions.DataSource = new BindingSource(m_FeaturesOptions, null);
            comboBoxFeatuersOptions.DisplayMember = "Key";
            comboBoxFeatuersOptions.ValueMember = "Value";
            m_ButtonLoginSubject.AddObserver(m_ButtonObserver.Update);
            m_ButtonLoginSubject.AddObserver(m_ComboBoxObserver.Update);
        }

        private void displayFeature(eFeatureOption i_FeatureOption)
        {
            IFeatures feature = r_FeatureFactory.LoadFeature(i_FeatureOption, m_LoginResult);

            feature.RunFeature();
        }

        private void buttonLogin_Click(object i_Sender, EventArgs i_Event)
        {
            Clipboard.SetText("design.patterns20cc");
            if(loginToFacebook())
            {
                buttonLogin.Text = $@"Logged in as {m_LoginResult.LoggedInUser.Name}";
                m_ButtonLoginSubject.IsLoggedIn = true;
                m_ButtonLoginSubject.Notify();
                pictureBoxProfile.LoadAsync(m_LoginResult.LoggedInUser.PictureNormalURL);
            }
        }

        private bool loginToFacebook()
        {
            bool isSuccessLogin = true;

            m_LoginResult = r_LoginFacade.Login();
            if (m_LoginResult == null)
            {
                MessageBox.Show(@"Login failed..", @"Login failed");
                isSuccessLogin = false;
            }

            return isSuccessLogin;
        }

        private void buttonLogout_Click(object i_Sender, EventArgs i_Event)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = @"Login";
            m_ButtonLoginSubject.IsLoggedIn = false;
            m_ButtonLoginSubject.Notify();
            pictureBoxProfile.Image = null;
        }

        private void buttonFeatureOption_Click(object i_Sender, EventArgs i_Event)
        {
            eFeatureOption feature = ((KeyValuePair<eFeatureOption, Action>) comboBoxFeatuersOptions.SelectedItem).Key;

            m_FeaturesOptions[feature].Invoke();
        }
    }
}
