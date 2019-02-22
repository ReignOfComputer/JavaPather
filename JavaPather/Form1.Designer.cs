namespace JavaPather
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListBox_PathMachine = new System.Windows.Forms.ListBox();
            this.GroupBox_Machine = new System.Windows.Forms.GroupBox();
            this.ListBox_PathUser = new System.Windows.Forms.ListBox();
            this.GroupBox_User = new System.Windows.Forms.GroupBox();
            this.GroupBox_Controls = new System.Windows.Forms.GroupBox();
            this.ComboBox_JavaBin = new System.Windows.Forms.ComboBox();
            this.Label_JavaBin = new System.Windows.Forms.Label();
            this.Label_CustomPath = new System.Windows.Forms.Label();
            this.RadioButton_Automatic = new System.Windows.Forms.RadioButton();
            this.RadioButton_Custom = new System.Windows.Forms.RadioButton();
            this.TextBox_CustomPath = new System.Windows.Forms.TextBox();
            this.Button_AddMachine = new System.Windows.Forms.Button();
            this.Button_AddUser = new System.Windows.Forms.Button();
            this.LinkLabel_DownloadJava = new System.Windows.Forms.LinkLabel();
            this.Button_Refresh = new System.Windows.Forms.Button();
            this.Button_RemoveMachine = new System.Windows.Forms.Button();
            this.Button_RemoveUser = new System.Windows.Forms.Button();
            this.Button_RunAsAdmin = new System.Windows.Forms.Button();
            this.GroupBox_Machine.SuspendLayout();
            this.GroupBox_User.SuspendLayout();
            this.GroupBox_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBox_PathMachine
            // 
            this.ListBox_PathMachine.Enabled = false;
            this.ListBox_PathMachine.FormattingEnabled = true;
            this.ListBox_PathMachine.Location = new System.Drawing.Point(6, 19);
            this.ListBox_PathMachine.Name = "ListBox_PathMachine";
            this.ListBox_PathMachine.Size = new System.Drawing.Size(314, 173);
            this.ListBox_PathMachine.TabIndex = 0;
            // 
            // GroupBox_Machine
            // 
            this.GroupBox_Machine.Controls.Add(this.ListBox_PathMachine);
            this.GroupBox_Machine.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_Machine.Name = "GroupBox_Machine";
            this.GroupBox_Machine.Size = new System.Drawing.Size(326, 199);
            this.GroupBox_Machine.TabIndex = 1;
            this.GroupBox_Machine.TabStop = false;
            this.GroupBox_Machine.Text = "Path (Machine)";
            // 
            // ListBox_PathUser
            // 
            this.ListBox_PathUser.FormattingEnabled = true;
            this.ListBox_PathUser.Location = new System.Drawing.Point(6, 19);
            this.ListBox_PathUser.Name = "ListBox_PathUser";
            this.ListBox_PathUser.Size = new System.Drawing.Size(314, 173);
            this.ListBox_PathUser.TabIndex = 0;
            // 
            // GroupBox_User
            // 
            this.GroupBox_User.Controls.Add(this.ListBox_PathUser);
            this.GroupBox_User.Location = new System.Drawing.Point(12, 217);
            this.GroupBox_User.Name = "GroupBox_User";
            this.GroupBox_User.Size = new System.Drawing.Size(326, 199);
            this.GroupBox_User.TabIndex = 2;
            this.GroupBox_User.TabStop = false;
            this.GroupBox_User.Text = "Path (User)";
            // 
            // GroupBox_Controls
            // 
            this.GroupBox_Controls.Controls.Add(this.LinkLabel_DownloadJava);
            this.GroupBox_Controls.Controls.Add(this.Button_AddUser);
            this.GroupBox_Controls.Controls.Add(this.Button_AddMachine);
            this.GroupBox_Controls.Controls.Add(this.TextBox_CustomPath);
            this.GroupBox_Controls.Controls.Add(this.RadioButton_Custom);
            this.GroupBox_Controls.Controls.Add(this.RadioButton_Automatic);
            this.GroupBox_Controls.Controls.Add(this.Label_CustomPath);
            this.GroupBox_Controls.Controls.Add(this.Label_JavaBin);
            this.GroupBox_Controls.Controls.Add(this.ComboBox_JavaBin);
            this.GroupBox_Controls.Location = new System.Drawing.Point(344, 121);
            this.GroupBox_Controls.Name = "GroupBox_Controls";
            this.GroupBox_Controls.Size = new System.Drawing.Size(325, 199);
            this.GroupBox_Controls.TabIndex = 3;
            this.GroupBox_Controls.TabStop = false;
            this.GroupBox_Controls.Text = "Controls";
            // 
            // ComboBox_JavaBin
            // 
            this.ComboBox_JavaBin.FormattingEnabled = true;
            this.ComboBox_JavaBin.Location = new System.Drawing.Point(6, 66);
            this.ComboBox_JavaBin.Name = "ComboBox_JavaBin";
            this.ComboBox_JavaBin.Size = new System.Drawing.Size(313, 21);
            this.ComboBox_JavaBin.TabIndex = 0;
            // 
            // Label_JavaBin
            // 
            this.Label_JavaBin.AutoSize = true;
            this.Label_JavaBin.Location = new System.Drawing.Point(4, 50);
            this.Label_JavaBin.Name = "Label_JavaBin";
            this.Label_JavaBin.Size = new System.Drawing.Size(52, 13);
            this.Label_JavaBin.TabIndex = 1;
            this.Label_JavaBin.Text = "Java \\bin";
            // 
            // Label_CustomPath
            // 
            this.Label_CustomPath.AutoSize = true;
            this.Label_CustomPath.Location = new System.Drawing.Point(4, 102);
            this.Label_CustomPath.Name = "Label_CustomPath";
            this.Label_CustomPath.Size = new System.Drawing.Size(67, 13);
            this.Label_CustomPath.TabIndex = 2;
            this.Label_CustomPath.Text = "Custom Path";
            // 
            // RadioButton_Automatic
            // 
            this.RadioButton_Automatic.AutoSize = true;
            this.RadioButton_Automatic.Checked = true;
            this.RadioButton_Automatic.Location = new System.Drawing.Point(7, 21);
            this.RadioButton_Automatic.Name = "RadioButton_Automatic";
            this.RadioButton_Automatic.Size = new System.Drawing.Size(72, 17);
            this.RadioButton_Automatic.TabIndex = 3;
            this.RadioButton_Automatic.TabStop = true;
            this.RadioButton_Automatic.Text = "Automatic";
            this.RadioButton_Automatic.UseVisualStyleBackColor = true;
            this.RadioButton_Automatic.CheckedChanged += new System.EventHandler(this.RadioButton_Automatic_CheckedChanged);
            // 
            // RadioButton_Custom
            // 
            this.RadioButton_Custom.AutoSize = true;
            this.RadioButton_Custom.Location = new System.Drawing.Point(85, 21);
            this.RadioButton_Custom.Name = "RadioButton_Custom";
            this.RadioButton_Custom.Size = new System.Drawing.Size(60, 17);
            this.RadioButton_Custom.TabIndex = 4;
            this.RadioButton_Custom.Text = "Custom";
            this.RadioButton_Custom.UseVisualStyleBackColor = true;
            this.RadioButton_Custom.CheckedChanged += new System.EventHandler(this.RadioButton_Custom_CheckedChanged);
            // 
            // TextBox_CustomPath
            // 
            this.TextBox_CustomPath.Enabled = false;
            this.TextBox_CustomPath.Location = new System.Drawing.Point(6, 119);
            this.TextBox_CustomPath.Name = "TextBox_CustomPath";
            this.TextBox_CustomPath.Size = new System.Drawing.Size(313, 20);
            this.TextBox_CustomPath.TabIndex = 5;
            this.TextBox_CustomPath.Text = "C:\\Program Files\\Java";
            // 
            // Button_AddMachine
            // 
            this.Button_AddMachine.Enabled = false;
            this.Button_AddMachine.Location = new System.Drawing.Point(59, 150);
            this.Button_AddMachine.Name = "Button_AddMachine";
            this.Button_AddMachine.Size = new System.Drawing.Size(96, 35);
            this.Button_AddMachine.TabIndex = 6;
            this.Button_AddMachine.Text = "Add to Machine";
            this.Button_AddMachine.UseVisualStyleBackColor = true;
            this.Button_AddMachine.Click += new System.EventHandler(this.Button_AddMachine_Click);
            // 
            // Button_AddUser
            // 
            this.Button_AddUser.Location = new System.Drawing.Point(161, 150);
            this.Button_AddUser.Name = "Button_AddUser";
            this.Button_AddUser.Size = new System.Drawing.Size(96, 35);
            this.Button_AddUser.TabIndex = 7;
            this.Button_AddUser.Text = "Add to User";
            this.Button_AddUser.UseVisualStyleBackColor = true;
            this.Button_AddUser.Click += new System.EventHandler(this.Button_AddUser_Click);
            // 
            // LinkLabel_DownloadJava
            // 
            this.LinkLabel_DownloadJava.AutoSize = true;
            this.LinkLabel_DownloadJava.Location = new System.Drawing.Point(241, 23);
            this.LinkLabel_DownloadJava.Name = "LinkLabel_DownloadJava";
            this.LinkLabel_DownloadJava.Size = new System.Drawing.Size(78, 13);
            this.LinkLabel_DownloadJava.TabIndex = 8;
            this.LinkLabel_DownloadJava.TabStop = true;
            this.LinkLabel_DownloadJava.Text = "Download JDK";
            this.LinkLabel_DownloadJava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_DownloadJava_LinkClicked);
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.Location = new System.Drawing.Point(629, 376);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(40, 40);
            this.Button_Refresh.TabIndex = 10;
            this.Button_Refresh.Text = "R";
            this.Button_Refresh.UseVisualStyleBackColor = true;
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // Button_RemoveMachine
            // 
            this.Button_RemoveMachine.Enabled = false;
            this.Button_RemoveMachine.Location = new System.Drawing.Point(344, 31);
            this.Button_RemoveMachine.Name = "Button_RemoveMachine";
            this.Button_RemoveMachine.Size = new System.Drawing.Size(75, 23);
            this.Button_RemoveMachine.TabIndex = 11;
            this.Button_RemoveMachine.Text = "<- Remove";
            this.Button_RemoveMachine.UseVisualStyleBackColor = true;
            this.Button_RemoveMachine.Click += new System.EventHandler(this.Button_RemoveMachine_Click);
            // 
            // Button_RemoveUser
            // 
            this.Button_RemoveUser.Location = new System.Drawing.Point(344, 386);
            this.Button_RemoveUser.Name = "Button_RemoveUser";
            this.Button_RemoveUser.Size = new System.Drawing.Size(75, 23);
            this.Button_RemoveUser.TabIndex = 12;
            this.Button_RemoveUser.Text = "<- Remove";
            this.Button_RemoveUser.UseVisualStyleBackColor = true;
            this.Button_RemoveUser.Click += new System.EventHandler(this.Button_RemoveUser_Click);
            // 
            // Button_RunAsAdmin
            // 
            this.Button_RunAsAdmin.Location = new System.Drawing.Point(548, 12);
            this.Button_RunAsAdmin.Name = "Button_RunAsAdmin";
            this.Button_RunAsAdmin.Size = new System.Drawing.Size(121, 23);
            this.Button_RunAsAdmin.TabIndex = 13;
            this.Button_RunAsAdmin.Text = "Run As Administrator";
            this.Button_RunAsAdmin.UseVisualStyleBackColor = true;
            this.Button_RunAsAdmin.Click += new System.EventHandler(this.Button_RunAsAdmin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 421);
            this.Controls.Add(this.Button_RunAsAdmin);
            this.Controls.Add(this.Button_RemoveUser);
            this.Controls.Add(this.Button_RemoveMachine);
            this.Controls.Add(this.Button_Refresh);
            this.Controls.Add(this.GroupBox_Controls);
            this.Controls.Add(this.GroupBox_User);
            this.Controls.Add(this.GroupBox_Machine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "JavaPather";
            this.GroupBox_Machine.ResumeLayout(false);
            this.GroupBox_User.ResumeLayout(false);
            this.GroupBox_Controls.ResumeLayout(false);
            this.GroupBox_Controls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_PathMachine;
        private System.Windows.Forms.GroupBox GroupBox_Machine;
        private System.Windows.Forms.ListBox ListBox_PathUser;
        private System.Windows.Forms.GroupBox GroupBox_User;
        private System.Windows.Forms.GroupBox GroupBox_Controls;
        private System.Windows.Forms.Button Button_AddUser;
        private System.Windows.Forms.Button Button_AddMachine;
        private System.Windows.Forms.TextBox TextBox_CustomPath;
        private System.Windows.Forms.RadioButton RadioButton_Custom;
        private System.Windows.Forms.RadioButton RadioButton_Automatic;
        private System.Windows.Forms.Label Label_CustomPath;
        private System.Windows.Forms.Label Label_JavaBin;
        private System.Windows.Forms.ComboBox ComboBox_JavaBin;
        private System.Windows.Forms.LinkLabel LinkLabel_DownloadJava;
        private System.Windows.Forms.Button Button_Refresh;
        private System.Windows.Forms.Button Button_RemoveMachine;
        private System.Windows.Forms.Button Button_RemoveUser;
        private System.Windows.Forms.Button Button_RunAsAdmin;
    }
}

