using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Media;
using System.IO;

namespace RcC_Menu_tool
{
    public partial class Add_Your_Tools : Form
    {
        public Add_Your_Tools()
        {
            InitializeComponent();
        }
        //Add your tool=====================
        public void ClearData()
        {
            textBox1.Clear(); textBox2.Clear(); textBox4.Clear(); textBox1.Focus();
            MessageBox.Show("Your Tool Is Add", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void KLASHSetValue(string NameOfTitle, string PathOfFile, string DllOrExe)
        {

            if (DllOrExe == "E")
            {
                RegistryKey regKey;
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\exefile\shell" , true);
                regKey.CreateSubKey(NameOfTitle);
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\exefile\shell\"+ NameOfTitle, true);
                regKey.SetValue("Icon", PathOfFile);
                regKey.CreateSubKey("command");
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\exefile\shell\"  + NameOfTitle + @"\command", true);
                regKey.SetValue("", Properties.Resources.File.Replace("PTH", PathOfFile));
                regKey.Close();
            }
            else if (DllOrExe == "D")
            {
                RegistryKey regKey;
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\dllfile\shell", true);
                regKey.CreateSubKey(NameOfTitle);
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\dllfile\shell\" + NameOfTitle, true);
                regKey.SetValue("Icon", PathOfFile);
                regKey.CreateSubKey("command");
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\dllfile\shell\" + NameOfTitle + @"\command", true);
                regKey.SetValue("", Properties.Resources.File.Replace("PTH", PathOfFile));
                regKey.Close();
            }
            else if (DllOrExe == "B")
            {
                RegistryKey regKey;
                regKey = Registry.ClassesRoot.OpenSubKey(@"Directory\Background\shell", true);
                regKey.CreateSubKey(NameOfTitle);
                regKey = Registry.ClassesRoot.OpenSubKey(@"Directory\Background\shell\" + NameOfTitle, true);
                if (Case == 1) regKey.SetValue("Icon", PathOfFile);
                else if (Case ==2)regKey.SetValue("Icon", op1 .FileName);
                regKey.CreateSubKey("command");
                regKey = Registry.ClassesRoot.OpenSubKey(@"Directory\Background\shell\" + NameOfTitle + @"\command", true);
                if (Case == 1)regKey.SetValue("", PathOfFile);
                else if(Case ==2)regKey.SetValue("", "explorer.exe " + PathOfFile);
                regKey.Close();
            }
        }
        public void Newsubmune(string SMName,string IconPath,string DllOrExe)
        {
            if (DllOrExe == "E")
            {
                RegistryKey regKey;
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\exefile\shell", true);
                regKey.CreateSubKey(SMName);
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\exefile\shell\" + SMName, true);
                regKey.SetValue("Icon", IconPath);
                regKey.SetValue("SubCommands", "");
                regKey.Close();
                treeView1.Nodes[0].Nodes.Add(SMName);
            }
            if (DllOrExe == "D")
            {
                RegistryKey regKey;
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\dllfile\shell", true);
                regKey.CreateSubKey(SMName);
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\dllfile\shell\" + SMName, true);
                regKey.SetValue("Icon", IconPath);
                regKey.SetValue("SubCommands", "");
                regKey.Close();
                treeView1.Nodes[1].Nodes.Add(SMName);
            }
            if (DllOrExe == "B")
            {
                RegistryKey regKey;
                regKey = Registry.ClassesRoot.OpenSubKey(@"Directory\Background\shell", true);
                regKey.CreateSubKey(SMName);
                regKey = Registry.ClassesRoot.OpenSubKey(@"Directory\Background\shell\" + SMName, true);
                regKey.SetValue("Icon", IconPath);
                regKey.SetValue("SubCommands", "");
                regKey.Close();
                treeView1.Nodes[2].Nodes.Add(SMName);
            }

        }
        //Add your tool=====================
        public void FolderSetValue(string NameOfTitle, string PathOfFile, string DllOrExe,string FolderPath)
        {

            if (DllOrExe == "E")
            {
                RegistryKey regKey;
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\exefile\shell\" + FolderPath, true);
                regKey.CreateSubKey("shell");
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\exefile\shell\"+FolderPath +@"\shell", true);
                regKey.CreateSubKey(NameOfTitle);
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\exefile\shell\" + FolderPath  + @"\shell\" + NameOfTitle, true);
                regKey.SetValue("",NameOfTitle );
                regKey.SetValue("Icon", PathOfFile);
                regKey.CreateSubKey("command");
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\exefile\shell\" +FolderPath+@"\shell\"+ NameOfTitle + @"\command", true);
                regKey.SetValue("", Properties.Resources.File.Replace("PTH", PathOfFile));
                regKey.Close();
            }
            else if (DllOrExe == "D")
            {
                RegistryKey regKey;
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\dllfile\shell\" + FolderPath, true);
                regKey.CreateSubKey("shell");
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\dllfile\shell\" + FolderPath + @"\shell", true);
                regKey.CreateSubKey(NameOfTitle);
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\dllfile\shell\" + FolderPath + @"\shell\" + NameOfTitle, true);
                regKey.SetValue("", NameOfTitle);
                regKey.SetValue("Icon", PathOfFile);
                regKey.CreateSubKey("command");
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\dllfile\shell\" + FolderPath + @"\shell\" + NameOfTitle + @"\command", true);
                regKey.SetValue("", Properties.Resources.File.Replace("PTH", PathOfFile));
                regKey.Close();
            }
            else if (DllOrExe == "B")
            {
                RegistryKey regKey;
                regKey = Registry.ClassesRoot.OpenSubKey(@"Directory\Background\shell\"+FolderPath , true);
                regKey.CreateSubKey("shell");
                regKey = Registry.ClassesRoot.OpenSubKey(@"Directory\Background\shell\" + FolderPath + @"\shell", true);
                regKey.CreateSubKey(NameOfTitle);
                regKey = Registry.ClassesRoot.OpenSubKey(@"Directory\Background\shell\" + FolderPath + @"\shell\" + NameOfTitle, true);
                regKey.SetValue("", NameOfTitle);
                regKey.SetValue("Icon", PathOfFile);
                regKey.CreateSubKey("command");
                regKey = Registry.ClassesRoot.OpenSubKey(@"Directory\Background\shell\" + FolderPath + @"\shell\" + NameOfTitle + @"\command", true);
                regKey.SetValue("", PathOfFile);
                regKey.Close();
            }
        }
        //Get folder=====================
        public void GetAllFolderinExeItem()
        {
            try
            {
                IEnumerable<string> onlyInFirstSet;
                string[] Exception = { "open", "runas", "runasuser" };
                RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("exefile\\shell", false);
                string[] subKeyNames = registryKey.GetSubKeyNames();
                onlyInFirstSet = subKeyNames.Except(Exception);
                if (onlyInFirstSet != null)
                {
                    foreach (string text in onlyInFirstSet)
                    {
                        RegistryKey registryKey2 = Registry.ClassesRoot.OpenSubKey("exefile\\shell\\" + text, false);
                        string[] subKeyNames2 = registryKey2.GetSubKeyNames();
                        string stremove = "";
                        if (subKeyNames != null)
                        {
                            for (int x = 0; x < subKeyNames2.Length; x += 1)
                            {
                                if (subKeyNames2[x] == "command") { stremove = text; }
                            }

                            if (text == stremove)
                            { stremove  = ""; }
                            else { treeView1.Nodes[0].Nodes .Add(text); }

                        }
                    }
                }
                else { return; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        public void GetAllFolderinDllAndRunItem(string path,int NumNodes)
        {
            try
            {

                RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(path , false);
                string[] subKeyNames = registryKey.GetSubKeyNames();
                if (subKeyNames != null)
                {
                    foreach (string text in subKeyNames)
                    {
                        RegistryKey registryKey2 = Registry.ClassesRoot.OpenSubKey(path  + "\\" + text, false);
                        string[] subKeyNames2 = registryKey2.GetSubKeyNames();
                        string stremove = "";
                        if (subKeyNames != null)
                        {
                            for (int x = 0; x < subKeyNames2.Length; x += 1)
                            {
                                if (subKeyNames2[x] == "command") { stremove = text; }
                            }

                            if (text == stremove)
                            { stremove = ""; }
                            else { treeView1.Nodes[NumNodes].Nodes.Add(text); }

                        }
                    }
                }
                else { return; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        //Get folder=====================
        int Case;
        private void Add_Your_Tools_Load(object sender, EventArgs e)
        {
            Case = 1;
            treeView1.SelectedNode = treeView1.Nodes[0];//تحديد عقدة
            GetAllFolderinExeItem();
            GetAllFolderinDllAndRunItem("dllfile\\shell", 1);
            GetAllFolderinDllAndRunItem("Directory\\Background\\shell", 2);
            label6.AutoSize = false;
            label6.Height = 2;
            label6.BorderStyle = BorderStyle.Fixed3D;
            Lblline2.AutoSize = false;
            Lblline2.Height = 2;
            Lblline2.BorderStyle = BorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
             if (textBox1 .Text .Trim ()!=""&& textBox4 .Text .Trim ()!="")
            {
                errorProvider1.Clear();
                if (radioButton1.Checked)// اضافة الادوات
                {
                        if (treeView1.Nodes[0].IsSelected)
                        { KLASHSetValue(textBox1.Text, textBox2.Text, "E"); ClearData(); }
                        else if (treeView1.Nodes[1].IsSelected)
                        { KLASHSetValue(textBox1.Text, textBox2.Text, "D"); ClearData(); }
                        else if (treeView1.Nodes[2].IsSelected)
                        { KLASHSetValue(textBox1.Text, textBox2.Text, "B"); ClearData(); }
                        else// اضافة الادوات داخل السب مينيو
                        {
                            for (int x = 0; x < treeView1.Nodes[0].GetNodeCount(true); x += 1)
                            {
                                try
                                {
                                    if (treeView1.Nodes[0].Nodes[x].IsSelected)
                                    {
                                        FolderSetValue(textBox1.Text, textBox2.Text, "E", treeView1.Nodes[0].Nodes[x].Text); ClearData();
                                    }
                                }
                                catch (IndexOutOfRangeException ex)
                                {
                                    return;
                                }
                            }
                            for (int x = 0; x < treeView1.Nodes[1].GetNodeCount(true); x += 1)
                            {
                                try
                                {
                                    if (treeView1.Nodes[1].Nodes[x].IsSelected)
                                    {
                                        FolderSetValue(textBox1.Text, textBox2.Text, "D", treeView1.Nodes[1].Nodes[x].Text); ClearData();
                                    }
                                }
                                catch (IndexOutOfRangeException ex)
                                {
                                    return;
                                }
                            }
                            for (int x = 0; x < treeView1.Nodes[2].GetNodeCount(true); x += 1)
                            {
                                try
                                {
                                    if (treeView1.Nodes[2].Nodes[x].IsSelected)
                                    {
                                        FolderSetValue(textBox1.Text, textBox2.Text, "B", treeView1.Nodes[2].Nodes[x].Text); ClearData();
                                    }
                                }
                                catch (IndexOutOfRangeException ex)
                                {
                                    return;
                                }
                            }
                        }
                 
                }
                else if (radioButton2.Checked)// اضافة الساب مينيو
                {
                            if (treeView1.Nodes[0].IsSelected)
                            { Newsubmune(textBox1.Text, textBox4.Text, "E"); ClearData(); }
                            else if (treeView1.Nodes[1].IsSelected)
                            { Newsubmune(textBox1.Text, textBox4.Text, "D"); ClearData(); }
                            else if (treeView1.Nodes[2].IsSelected)
                            { Newsubmune(textBox1.Text, textBox4.Text, "B"); ClearData(); }
                }
                else if (radioButton3.Checked)// اضافة فولدر
                {
                    if (treeView1.Nodes[2].IsSelected)
                    { KLASHSetValue(textBox1.Text, textBox2.Text, "B"); ClearData(); }
                }
            }
             
             else
             {
                 errorProvider1.SetError(textBox1, "You must enter the titel");
                 errorProvider1.SetError(textBox2, "You must enter Program path");
                 errorProvider1.SetError(textBox4, "You must enter Icon path");
                 SystemSounds.Beep.Play();
             }
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (Case == 1)
                {
                    OpenFileDialog op = new OpenFileDialog();
                    op.ShowDialog();
                    textBox2.Text = op.FileName;
                    textBox4.Text = op.FileName;
                    textBox1.Text = "Open With " + System.IO.Path.GetFileName(op.FileName).Replace(System.IO.Path.GetExtension(op.FileName), "");
                }
                else if (Case == 2)
                {
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        textBox2.Text = fbd.SelectedPath;
                    }
                }

            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Case = 1;
            textBox1.Text = "Sub Menu";
            textBox1.Focus();
            textBox1.SelectAll();
            textBox2.Clear();
            textBox4.Clear();
            button1.Enabled = false;
            button5.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Case = 1;
            textBox1.Clear();
            button1.Enabled = true;
            button2.Enabled = true;
            button5.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Case == 1)
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "EXE File |*.exe";
                op.ShowDialog();
                textBox2.Text = op.FileName;
            }
            else if (Case == 2)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    textBox2.Text = fbd.SelectedPath;
                }
            }

        }
        OpenFileDialog op1 = new OpenFileDialog();
        private void button2_Click(object sender, EventArgs e)
        {
            
            op1.Filter = "EXE & Icon File |*.exe;*.ico";
            op1.ShowDialog();
            textBox4.Text = op1.FileName;
        }

        private void Add_Your_Tools_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.Nodes[2].IsSelected) radioButton3.Enabled = true ;
            else radioButton3.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Case = 2;
            textBox1.Clear();
            textBox1.Text = "Folder Name";
            textBox1.SelectAll();
            textBox1.Focus();
            textBox2.Clear();
            textBox4.Clear();
            button1.Enabled = true;
            button2.Enabled = true;
            button5.Enabled = true;
        }
    }
}
