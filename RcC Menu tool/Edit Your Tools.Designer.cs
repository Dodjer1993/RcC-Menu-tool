namespace RcC_Menu_tool
{
    partial class Edit_Your_Tools
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Your_Tools));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteItemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToRgistryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(328, 298);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Program Name";
            this.columnHeader1.Width = 228;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Program Path";
            this.columnHeader2.Width = 94;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteItemeToolStripMenuItem,
            this.jumpToRgistryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 48);
            // 
            // deleteItemeToolStripMenuItem
            // 
            this.deleteItemeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteItemeToolStripMenuItem.Image")));
            this.deleteItemeToolStripMenuItem.Name = "deleteItemeToolStripMenuItem";
            this.deleteItemeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.deleteItemeToolStripMenuItem.Text = "Delete this item";
            this.deleteItemeToolStripMenuItem.Click += new System.EventHandler(this.deleteItemeToolStripMenuItem_Click);
            // 
            // jumpToRgistryToolStripMenuItem
            // 
            this.jumpToRgistryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("jumpToRgistryToolStripMenuItem.Image")));
            this.jumpToRgistryToolStripMenuItem.Name = "jumpToRgistryToolStripMenuItem";
            this.jumpToRgistryToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.jumpToRgistryToolStripMenuItem.Text = "Jump to registry";
            this.jumpToRgistryToolStripMenuItem.Click += new System.EventHandler(this.jumpToRgistryToolStripMenuItem_Click);
            // 
            // Edit_Your_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 298);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Edit_Your_Tools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit_Your_Tools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Edit_Your_Tools_FormClosing);
            this.Load += new System.EventHandler(this.Edit_Your_Tools_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteItemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumpToRgistryToolStripMenuItem;
    }
}