namespace B22_Ex03.Forms
{
    public partial class FormSearchPostAndShowDetailsBasicExperience
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchPosts = new System.Windows.Forms.TextBox();
            this.buttonSearchPosts = new System.Windows.Forms.Button();
            this.comboBoxSortType = new System.Windows.Forms.ComboBox();
            this.checkBoxShouldAscending = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search posts";
            // 
            // textBoxSearchPosts
            // 
            this.textBoxSearchPosts.Location = new System.Drawing.Point(140, 40);
            this.textBoxSearchPosts.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchPosts.Name = "textBoxSearchPosts";
            this.textBoxSearchPosts.Size = new System.Drawing.Size(265, 22);
            this.textBoxSearchPosts.TabIndex = 1;
            // 
            // buttonSearchPosts
            // 
            this.buttonSearchPosts.Location = new System.Drawing.Point(741, 38);
            this.buttonSearchPosts.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchPosts.Name = "buttonSearchPosts";
            this.buttonSearchPosts.Size = new System.Drawing.Size(144, 25);
            this.buttonSearchPosts.TabIndex = 2;
            this.buttonSearchPosts.Text = "Search";
            this.buttonSearchPosts.UseVisualStyleBackColor = true;
            this.buttonSearchPosts.Click += new System.EventHandler(this.buttonSearchPosts_Click);
            // 
            // comboBoxSortType
            // 
            this.comboBoxSortType.FormattingEnabled = true;
            this.comboBoxSortType.Location = new System.Drawing.Point(438, 38);
            this.comboBoxSortType.Name = "comboBoxSortType";
            this.comboBoxSortType.Size = new System.Drawing.Size(147, 24);
            this.comboBoxSortType.TabIndex = 3;
            // 
            // checkBoxShouldAscending
            // 
            this.checkBoxShouldAscending.AutoSize = true;
            this.checkBoxShouldAscending.Location = new System.Drawing.Point(612, 40);
            this.checkBoxShouldAscending.Name = "checkBoxShouldAscending";
            this.checkBoxShouldAscending.Size = new System.Drawing.Size(91, 20);
            this.checkBoxShouldAscending.TabIndex = 4;
            this.checkBoxShouldAscending.Text = "Ascending";
            this.checkBoxShouldAscending.UseVisualStyleBackColor = true;
            // 
            // FormSearchPostAndShowDetailsBasicExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 504);
            this.Controls.Add(this.checkBoxShouldAscending);
            this.Controls.Add(this.comboBoxSortType);
            this.Controls.Add(this.buttonSearchPosts);
            this.Controls.Add(this.textBoxSearchPosts);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSearchPostAndShowDetailsBasicExperience";
            this.Text = "Search Post And Show Detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchPosts;
        private System.Windows.Forms.Button buttonSearchPosts;
        private System.Windows.Forms.ComboBox comboBoxSortType;
        private System.Windows.Forms.CheckBox checkBoxShouldAscending;
    }
}