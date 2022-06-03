namespace B22_Ex03.Forms
{
    public partial class FormActivityFriendsProfileFeature
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
            this.comboBoxFakeFriendList = new System.Windows.Forms.ComboBox();
            this.buttonViewActivityFriend = new System.Windows.Forms.Button();
            this.listBoxFriendActivities = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxFakeFriendList
            // 
            this.comboBoxFakeFriendList.FormattingEnabled = true;
            this.comboBoxFakeFriendList.Location = new System.Drawing.Point(32, 43);
            this.comboBoxFakeFriendList.Name = "comboBoxFakeFriendList";
            this.comboBoxFakeFriendList.Size = new System.Drawing.Size(172, 24);
            this.comboBoxFakeFriendList.TabIndex = 0;
            // 
            // buttonViewActivityFriend
            // 
            this.buttonViewActivityFriend.Location = new System.Drawing.Point(226, 44);
            this.buttonViewActivityFriend.Name = "buttonViewActivityFriend";
            this.buttonViewActivityFriend.Size = new System.Drawing.Size(131, 23);
            this.buttonViewActivityFriend.TabIndex = 1;
            this.buttonViewActivityFriend.Text = "friend activities";
            this.buttonViewActivityFriend.UseVisualStyleBackColor = true;
            this.buttonViewActivityFriend.Click += new System.EventHandler(this.buttonViewActivityFriend_Click);
            // 
            // listBoxFriendActivities
            // 
            this.listBoxFriendActivities.FormattingEnabled = true;
            this.listBoxFriendActivities.ItemHeight = 16;
            this.listBoxFriendActivities.Location = new System.Drawing.Point(32, 103);
            this.listBoxFriendActivities.Name = "listBoxFriendActivities";
            this.listBoxFriendActivities.Size = new System.Drawing.Size(325, 180);
            this.listBoxFriendActivities.TabIndex = 2;
            // 
            // FormActivityFriendsProfileFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 306);
            this.Controls.Add(this.listBoxFriendActivities);
            this.Controls.Add(this.buttonViewActivityFriend);
            this.Controls.Add(this.comboBoxFakeFriendList);
            this.Name = "FormActivityFriendsProfileFeature";
            this.Text = "Activity Friends Profile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFakeFriendList;
        private System.Windows.Forms.Button buttonViewActivityFriend;
        private System.Windows.Forms.ListBox listBoxFriendActivities;
    }
}