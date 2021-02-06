using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
using System.Media;
namespace RcC_Menu_tool
{
    public partial class Edit_Your_Tools : Form
    {
        public Edit_Your_Tools()
        {
            InitializeComponent();
        }


        public void DeleteItem(string PathFile)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    if (Registry.ClassesRoot.OpenSubKey(PathFile  + listView1.FocusedItem.Text.Trim()) != null)
                    {
                        if (MessageBox.Show("Are You Sure To Delete This Item ?", "DeletKey ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                           Registry.ClassesRoot.DeleteSubKeyTree(PathFile  + listView1.FocusedItem.Text.Trim());
                           listView1.Items.Remove(listView1.SelectedItems[0]);
                           SystemSounds.Asterisk.Play();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Item Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        public void GetAllExeItem()
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
                        this.listView1.Items.Add(text).SubItems.Add("ExeFile");
                    }
                }
                else { return; }
                 }
             catch (Exception ex)
                 {
                      MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 }
        }
        public void GetAllDARItem(string PathFile,string kind)
        {
            try
            {
            RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(PathFile , false);
            string[] subKeyNames = registryKey.GetSubKeyNames();
            if (subKeyNames != null)
            {
                foreach (string text in subKeyNames)
                {
                    this.listView1.Items.Add(text).SubItems.Add(kind );
                }
            }
            else { return; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }



        private void Edit_Your_Tools_Load(object sender, EventArgs e)
        {
            
            GetAllExeItem();
            GetAllDARItem("dllfile\\shell","DllFile");
            GetAllDARItem("Directory\\Background\\shell", "RunFile");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void deleteItemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems[0].SubItems[1].Text == "ExeFile")
                { DeleteItem("exefile\\shell\\"); }
                else if (listView1.SelectedItems[0].SubItems[1].Text == "DllFile")
                { DeleteItem("dllfile\\shell\\"); }
                else if (listView1.SelectedItems[0].SubItems[1].Text == "RunFile")
                { DeleteItem("Directory\\Background\\shell\\"); }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("You must select a field", "Erorr selction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        }

        private void jumpToRgistryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                    StreamWriter sw = new StreamWriter("jumpToRegistry.vbs");
                    sw.WriteLine("Set WshShell = CreateObject(" + @"""WScript.Shell""" + ")");
                    if (listView1.SelectedItems[0].SubItems[1].Text == "ExeFile")
                    {
                        sw.WriteLine("WshShell.RegWrite" + @"""HKCU\Software\Microsoft\Windows\CurrentVersion\Applets\Regedit\Lastkey""" + "," + @"""HKEY_CLASSES_ROOT\exefile\shell\" + listView1.SelectedItems[0].Text + @"""," + @"""REG_SZ""");
                    }
                    else if (listView1.SelectedItems[0].SubItems[1].Text == "DllFile")
                    {
                        sw.WriteLine("WshShell.RegWrite" + @"""HKCU\Software\Microsoft\Windows\CurrentVersion\Applets\Regedit\Lastkey""" + "," + @"""HKEY_CLASSES_ROOT\dllfile\shell\" + listView1.SelectedItems[0].Text + @"""," + @"""REG_SZ""");
                    }
                    else if (listView1.SelectedItems[0].SubItems[1].Text == "RunFile")
                    {
                        sw.WriteLine("WshShell.RegWrite" + @"""HKCU\Software\Microsoft\Windows\CurrentVersion\Applets\Regedit\Lastkey""" + "," + @"""HKEY_CLASSES_ROOT\Directory\Background\shell\" + listView1.SelectedItems[0].Text + @"""," + @"""REG_SZ""");
                    }
                    sw.WriteLine("WshShell.Run" + @"""regedit""" + ", 1,True");
                    sw.Close();
                    if (File.Exists("jumpToRegistry.vbs"))
                    { Process.Start("jumpToRegistry.vbs"); }
            }

            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("You must select a field", "Erorr selction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Edit_Your_Tools_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists("jumpToRegistry.vbs"))
            { File.Delete("jumpToRegistry.vbs"); }
            this.Owner.Show();
            
        }
    }
}
