namespace B22_Ex03.Forms
{
    public partial class FormWhoWatchMyProfileFeature
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
            this.linkLabelWhoFetchWatchMyProfile = new System.Windows.Forms.LinkLabel();
            this.listBoxWhoWatchMeProfile = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // linkLabelWhoFetchWatchMyProfile
            // 
            this.linkLabelWhoFetchWatchMyProfile.AutoSize = true;
            this.linkLabelWhoFetchWatchMyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabelWhoFetchWatchMyProfile.Location = new System.Drawing.Point(24, 23);
            this.linkLabelWhoFetchWatchMyProfile.Name = "linkLabelWhoFetchWatchMyProfile";
            this.linkLabelWhoFetchWatchMyProfile.Size = new System.Drawing.Size(200, 20);
            this.linkLabelWhoFetchWatchMyProfile.TabIndex = 0;
            this.linkLabelWhoFetchWatchMyProfile.TabStop = true;
            this.linkLabelWhoFetchWatchMyProfile.Text = "Fetch who watch my profile";
            this.linkLabelWhoFetchWatchMyProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWhoFetchWatchMyProfile_LinkClicked);
            // 
            // listBoxWhoWatchMeProfile
            // 
            this.listBoxWhoWatchMeProfile.FormattingEnabled = true;
            this.listBoxWhoWatchMeProfile.Location = new System.Drawing.Point(62, 60);
            this.listBoxWhoWatchMeProfile.Name = "listBoxWhoWatchMeProfile";
            this.listBoxWhoWatchMeProfile.Size = new System.Drawing.Size(310, 147);
            this.listBoxWhoWatchMeProfile.TabIndex = 1;
            // 
            // FormWhoWatchMeProfileFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 239);
            this.Controls.Add(this.listBoxWhoWatchMeProfile);
            this.Controls.Add(this.linkLabelWhoFetchWatchMyProfile);
            this.Name = "FormWhoWatchMeProfileFeature";
            this.Text = "Who Watch My Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelWhoFetchWatchMyProfile;
        private System.Windows.Forms.ListBox listBoxWhoWatchMeProfile;
    }
}