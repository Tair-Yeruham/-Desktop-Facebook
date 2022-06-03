using B22_Ex03.Observer;

namespace B22_Ex03.Forms
{
    public partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.comboBoxFeatuersOptions = new System.Windows.Forms.ComboBox();
            this.buttonFeatureOption = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            m_ButtonLoginSubject = new ButtonLoginSubject();
            m_ComboBoxObserver = new ComboBoxObserver(this.comboBoxFeatuersOptions);
            m_ButtonObserver = new ButtonObserver(this.buttonFeatureOption);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 18);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(478, 35);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(18, 63);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(478, 35);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // comboBoxFeatuersOptions
            // 
            this.comboBoxFeatuersOptions.Enabled = false;
            this.comboBoxFeatuersOptions.FormattingEnabled = true;
            this.comboBoxFeatuersOptions.Location = new System.Drawing.Point(18, 123);
            this.comboBoxFeatuersOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxFeatuersOptions.Name = "comboBoxFeatuersOptions";
            this.comboBoxFeatuersOptions.Size = new System.Drawing.Size(325, 28);
            this.comboBoxFeatuersOptions.TabIndex = 53;
            // 
            // buttonFeatureOption
            // 
            this.buttonFeatureOption.Enabled = false;
            this.buttonFeatureOption.Location = new System.Drawing.Point(384, 123);
            this.buttonFeatureOption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFeatureOption.Name = "buttonFeatureOption";
            this.buttonFeatureOption.Size = new System.Drawing.Size(112, 35);
            this.buttonFeatureOption.TabIndex = 54;
            this.buttonFeatureOption.Text = "Start";
            this.buttonFeatureOption.UseVisualStyleBackColor = true;
            this.buttonFeatureOption.Click += new System.EventHandler(this.buttonFeatureOption_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(514, 18);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(147, 140);
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 176);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonFeatureOption);
            this.Controls.Add(this.comboBoxFeatuersOptions);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Facebook app";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ComboBox comboBoxFeatuersOptions;
        private System.Windows.Forms.Button buttonFeatureOption;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private ButtonLoginSubject m_ButtonLoginSubject;
        private ComboBoxObserver m_ComboBoxObserver;
        private ButtonObserver m_ButtonObserver;
    }
}