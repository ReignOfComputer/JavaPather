using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace JavaPather
{
    public partial class Form1 : Form
    {
        private string PathMachine, PathUser;
        private string[] pathMachineSplit, pathUserSplit;
        private enum PathType { MACHINE = 0, USER = 1 };
        private bool ControlTypeAuto = true;

        public Form1(bool isElevated)
        {
            InitializeComponent();

            if (isElevated)
            {
                Button_RemoveMachine.Enabled = true;
                Button_AddMachine.Enabled = true;
                Button_RunAsAdmin.Visible = false;
                ListBox_PathMachine.Enabled = true;
            }

            Button_Refresh.Font = new Font("Wingdings 3", 20, FontStyle.Bold);
            Button_Refresh.Text = Char.ConvertFromUtf32(81);

            RefreshAll();
        }

        private void RefreshAll()
        {
            getPathMachine();
            getPathUser();
            getJavaPath();
        }

        private void getPathMachine()
        {
            ListBox_PathMachine.Items.Clear();
            PathMachine = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine).Trim();

            if (!PathMachine.EndsWith(";"))
                PathMachine += ";";

            pathMachineSplit = PathMachine.Split(new Char[] { ';' });

            foreach (string path in pathMachineSplit)
            {
                if (path != "")
                    ListBox_PathMachine.Items.Add(path);
            }

            if (ListBox_PathMachine.Items.Count > 0)
                ListBox_PathMachine.SelectedIndex = 0;
        }

        private void getPathUser()
        {
            ListBox_PathUser.Items.Clear();
            PathUser = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User).Trim();
            if (!PathUser.EndsWith(";"))
                PathUser += ";";

            pathUserSplit = PathUser.Split(new Char[] { ';' });

            foreach (string path in pathUserSplit)
            {
                if (path != "")
                    ListBox_PathUser.Items.Add(path);
            }

            if (ListBox_PathUser.Items.Count > 0)
                ListBox_PathUser.SelectedIndex = 0;
        }

        private void getJavaPath()
        {
            ComboBox_JavaBin.Items.Clear();
            

            try
            {
                string[] directories = Directory.GetDirectories("C:\\Program Files\\Java");

                foreach (string directory in directories)
                {
                    ComboBox_JavaBin.Items.Add(directory + "\\bin");
                }
            }
            catch (DirectoryNotFoundException)
            { }

            try
            {
                string[] directoriesx86 = Directory.GetDirectories("C:\\Program Files (x86)\\Java");

                foreach (string directory in directoriesx86)
                {
                    ComboBox_JavaBin.Items.Add(directory + "\\bin");
                }
            }
            catch (DirectoryNotFoundException)
            { }
            finally
            {
                if (ComboBox_JavaBin.Items.Count > 0)
                    ComboBox_JavaBin.SelectedIndex = 0;
            }
        }

        private void LinkLabel_DownloadJava_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.oracle.com/technetwork/java/javase/downloads/index.html");
        }

        private void RadioButton_Automatic_CheckedChanged(object sender, EventArgs e)
        {
            ControlTypeAuto = true;
            TextBox_CustomPath.Enabled = false;
            ComboBox_JavaBin.Enabled = true;
        }

        private void RadioButton_Custom_CheckedChanged(object sender, EventArgs e)
        {
            ControlTypeAuto = false;
            TextBox_CustomPath.Enabled = true;
            ComboBox_JavaBin.Enabled = false;
        }

        private void Button_AddMachine_Click(object sender, EventArgs e)
        {
            AddPath(PathType.MACHINE);
        }

        private void Button_AddUser_Click(object sender, EventArgs e)
        {
            AddPath(PathType.USER);
        }

        private void Button_RemoveMachine_Click(object sender, EventArgs e)
        {
            RemovePath(PathType.MACHINE);
        }

        private void Button_RemoveUser_Click(object sender, EventArgs e)
        {
            RemovePath(PathType.USER);
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void Button_RunAsAdmin_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.UseShellExecute = true;
            proc.WorkingDirectory = Environment.CurrentDirectory;
            proc.FileName = Application.ExecutablePath;
            proc.Verb = "runas";

            try
            {
                Process.Start(proc);
                Application.Exit();
            }
            catch
            {
                return;
            }
        }

        private void AddPath(PathType pathType)
        {
            string addPath = "";
            if (ControlTypeAuto)
                addPath = ComboBox_JavaBin.SelectedItem.ToString();
            else
            {
                addPath = TextBox_CustomPath.Text;
                if (!Directory.Exists(addPath))
                {
                    MessageBox.Show(addPath + " is not a valid directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DialogResult dialogResult = MessageBox.Show("Adding " + addPath + " to " + ((pathType == PathType.MACHINE) ? "Machine" : "User") + " Path!", "JavaPather", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            bool canContinue = true;

            if (pathType == PathType.MACHINE)
            {
                getPathMachine();
                BackupPath(PathType.MACHINE);

                foreach (string path in pathMachineSplit)
                {
                    if (path == addPath)
                        canContinue = false;
                }
            }
            else
            {
                getPathUser();
                BackupPath(PathType.USER);

                foreach (string path in pathUserSplit)
                {
                    if (path == addPath)
                        canContinue = false;
                }
            }

            string pathConcat = "";
            int javaCount = 0;

            if (canContinue && pathType == PathType.MACHINE)
            {
                Array.Resize(ref pathMachineSplit, pathMachineSplit.Length + 1);
                pathMachineSplit[pathMachineSplit.Length - 2] = addPath;
                pathMachineSplit[pathMachineSplit.Length - 1] = "";

                pathConcat += pathMachineSplit[0];

                for (int i = 1; i < pathMachineSplit.Length; i++)
                {
                    if (pathMachineSplit[i].ToLower().Contains("java"))
                        javaCount++;

                    pathConcat += String.Format(";{0:S}", pathMachineSplit[i]);
                }
                Environment.SetEnvironmentVariable("Path", pathConcat, EnvironmentVariableTarget.Machine);
            }
            else if (canContinue && pathType == PathType.USER)
            {
                Array.Resize(ref pathUserSplit, pathUserSplit.Length + 1);
                pathUserSplit[pathUserSplit.Length - 2] = addPath;
                pathUserSplit[pathUserSplit.Length - 1] = "";

                pathConcat += pathUserSplit[0].ToString();

                for (int i = 1; i < pathUserSplit.Length; i++)
                {
                    if (pathUserSplit[i].ToLower().Contains("java"))
                        javaCount++;

                    pathConcat += String.Format(";{0:S}", pathUserSplit[i]);
                }
                Environment.SetEnvironmentVariable("Path", pathConcat, EnvironmentVariableTarget.User);
            }
            else
            {
                MessageBox.Show("Path already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (javaCount > 1)
                MessageBox.Show(javaCount + " Java Paths detected - you might want to remove " + (javaCount - 1) + ".", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            RefreshAll();

        }

        private void RemovePath(PathType pathType)
        {
            string removePath = "";
            string pathConcat = "";
            if (pathType == PathType.MACHINE)
            {
                removePath = ListBox_PathMachine.SelectedItem.ToString();

                DialogResult dialogResult = MessageBox.Show("Removing " + removePath + " from " + ((pathType == PathType.MACHINE) ? "Machine" : "User") + " Path!", "JavaPather", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                getPathMachine();

                BackupPath(PathType.MACHINE);

                pathMachineSplit = pathMachineSplit.Where(s => s != removePath).ToArray();

                pathConcat += pathMachineSplit[0];

                for (int i = 1; i < pathMachineSplit.Length; i++)
                {
                    pathConcat += String.Format(";{0:S}", pathMachineSplit[i]);
                }
                Environment.SetEnvironmentVariable("Path", pathConcat, EnvironmentVariableTarget.Machine);
            }
            else
            {
                removePath = ListBox_PathUser.SelectedItem.ToString();

                DialogResult dialogResult = MessageBox.Show("Removing " + removePath + " from " + ((pathType == PathType.MACHINE) ? "Machine" : "User") + " Path!", "JavaPather", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                getPathUser();

                BackupPath(PathType.USER);

                pathUserSplit = pathUserSplit.Where(s => s != removePath).ToArray();

                pathConcat += pathUserSplit[0].ToString();

                for (int i = 1; i < pathUserSplit.Length; i++)
                {
                    pathConcat += String.Format(";{0:S}", pathUserSplit[i]);
                }
                Environment.SetEnvironmentVariable("Path", pathConcat, EnvironmentVariableTarget.User);
            }
                
            RefreshAll();
        }

        private void BackupPath(PathType pathType)
        {
            DialogResult dialogResult = MessageBox.Show("Backup as a Text File?", "JavaPather", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string backupPaths = "";
                    if (pathType == PathType.MACHINE)
                    {
                        foreach (string path in pathMachineSplit)
                        {
                            backupPaths += path + Environment.NewLine;
                        }
                        File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\machine.txt", backupPaths);
                    }
                    else
                    {
                        foreach (string path in pathUserSplit)
                        {
                            backupPaths += path + Environment.NewLine;
                        }
                        File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\user.txt", backupPaths);
                    }
                }
                catch
                {
                    MessageBox.Show("Current directory unwritable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
