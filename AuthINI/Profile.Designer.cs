namespace AuthINI
{
    partial class Profile
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
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.groupBoxProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.Controls.Add(this.labelGroup);
            this.groupBoxProfile.Controls.Add(this.labelLogin);
            this.groupBoxProfile.Controls.Add(this.labelPatronymic);
            this.groupBoxProfile.Controls.Add(this.labelName);
            this.groupBoxProfile.Controls.Add(this.labelSurname);
            this.groupBoxProfile.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(476, 169);
            this.groupBoxProfile.TabIndex = 0;
            this.groupBoxProfile.TabStop = false;
            this.groupBoxProfile.Text = "Профиль";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(16, 116);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(36, 13);
            this.labelGroup.TabIndex = 4;
            this.labelGroup.Text = "Group";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(16, 142);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Login";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(16, 89);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(59, 13);
            this.labelPatronymic.TabIndex = 2;
            this.labelPatronymic.Text = "Patronymic";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 57);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(16, 28);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(49, 13);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "Surname";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 348);
            this.Controls.Add(this.groupBoxProfile);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(516, 386);
            this.MinimumSize = new System.Drawing.Size(516, 386);
            this.Name = "Profile";
            this.Text = "Вы авторизированы: <login>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Profile_FormClosing);
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProfile;
        public System.Windows.Forms.Label labelLogin;
        public System.Windows.Forms.Label labelPatronymic;
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Label labelSurname;
        public System.Windows.Forms.Label labelGroup;
    }
}