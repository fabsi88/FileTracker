namespace FileTracker
{
    partial class FileTracker
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvResults = new System.Windows.Forms.ListView();
            this.cImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bTrack = new System.Windows.Forms.Button();
            this.tPath = new System.Windows.Forms.TextBox();
            this.lPath = new System.Windows.Forms.Label();
            this.fsWatcher = new System.IO.FileSystemWatcher();
            this.bClear = new System.Windows.Forms.Button();
            this.bBrowse = new System.Windows.Forms.Button();
            this.fBDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSubdirectories = new System.Windows.Forms.CheckBox();
            this.cbTrackUsernames = new System.Windows.Forms.CheckBox();
            this.cbTrackChange = new System.Windows.Forms.CheckBox();
            this.cbTrackCreate = new System.Windows.Forms.CheckBox();
            this.cbTrackDelete = new System.Windows.Forms.CheckBox();
            this.cbTrackRename = new System.Windows.Forms.CheckBox();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miTrack = new System.Windows.Forms.ToolStripMenuItem();
            this.miClear = new System.Windows.Forms.ToolStripMenuItem();
            this.miClose = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.fsWatcher)).BeginInit();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvResults
            // 
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cImage,
            this.cFileName,
            this.cState,
            this.cSize,
            this.cUser,
            this.cPath});
            this.lvResults.Location = new System.Drawing.Point(264, 85);
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(1089, 464);
            this.lvResults.TabIndex = 0;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            // 
            // cImage
            // 
            this.cImage.Text = "";
            this.cImage.Width = 37;
            // 
            // cFileName
            // 
            this.cFileName.Text = "Filename";
            this.cFileName.Width = 169;
            // 
            // cState
            // 
            this.cState.Text = "State";
            this.cState.Width = 84;
            // 
            // cSize
            // 
            this.cSize.Text = "Size";
            this.cSize.Width = 100;
            // 
            // cUser
            // 
            this.cUser.Text = "User";
            this.cUser.Width = 172;
            // 
            // cPath
            // 
            this.cPath.Text = "Path";
            this.cPath.Width = 522;
            // 
            // bTrack
            // 
            this.bTrack.Location = new System.Drawing.Point(12, 140);
            this.bTrack.Name = "bTrack";
            this.bTrack.Size = new System.Drawing.Size(75, 23);
            this.bTrack.TabIndex = 1;
            this.bTrack.Text = "Track!";
            this.bTrack.UseVisualStyleBackColor = true;
            this.bTrack.Click += new System.EventHandler(this.bTrack_Click);
            // 
            // tPath
            // 
            this.tPath.Location = new System.Drawing.Point(13, 114);
            this.tPath.Name = "tPath";
            this.tPath.Size = new System.Drawing.Size(209, 20);
            this.tPath.TabIndex = 2;
            // 
            // lPath
            // 
            this.lPath.AutoSize = true;
            this.lPath.Location = new System.Drawing.Point(13, 95);
            this.lPath.Name = "lPath";
            this.lPath.Size = new System.Drawing.Size(29, 13);
            this.lPath.TabIndex = 3;
            this.lPath.Text = "Path";
            // 
            // fsWatcher
            // 
            this.fsWatcher.EnableRaisingEvents = true;
            this.fsWatcher.SynchronizingObject = this;
            this.fsWatcher.Changed += new System.IO.FileSystemEventHandler(this.fsWatcher_Changed);
            this.fsWatcher.Created += new System.IO.FileSystemEventHandler(this.fsWatcher_Changed);
            this.fsWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fsWatcher_Changed);
            this.fsWatcher.Renamed += new System.IO.RenamedEventHandler(this.fsWatcher_Changed);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(183, 140);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 4;
            this.bClear.Text = "Clear!";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(228, 112);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(29, 23);
            this.bBrowse.TabIndex = 5;
            this.bBrowse.Text = "...";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // cbSubdirectories
            // 
            this.cbSubdirectories.AutoSize = true;
            this.cbSubdirectories.Checked = true;
            this.cbSubdirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSubdirectories.Location = new System.Drawing.Point(12, 191);
            this.cbSubdirectories.Name = "cbSubdirectories";
            this.cbSubdirectories.Size = new System.Drawing.Size(131, 17);
            this.cbSubdirectories.TabIndex = 7;
            this.cbSubdirectories.Text = "Include Subdirectories";
            this.cbSubdirectories.UseVisualStyleBackColor = true;
            // 
            // cbTrackUsernames
            // 
            this.cbTrackUsernames.AutoSize = true;
            this.cbTrackUsernames.Location = new System.Drawing.Point(12, 215);
            this.cbTrackUsernames.Name = "cbTrackUsernames";
            this.cbTrackUsernames.Size = new System.Drawing.Size(110, 17);
            this.cbTrackUsernames.TabIndex = 8;
            this.cbTrackUsernames.Text = "Track Usernames";
            this.cbTrackUsernames.UseVisualStyleBackColor = true;
            // 
            // cbTrackChange
            // 
            this.cbTrackChange.AutoSize = true;
            this.cbTrackChange.Checked = true;
            this.cbTrackChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTrackChange.Location = new System.Drawing.Point(12, 253);
            this.cbTrackChange.Name = "cbTrackChange";
            this.cbTrackChange.Size = new System.Drawing.Size(125, 17);
            this.cbTrackChange.TabIndex = 9;
            this.cbTrackChange.Text = "Track Change Event";
            this.cbTrackChange.UseVisualStyleBackColor = true;
            // 
            // cbTrackCreate
            // 
            this.cbTrackCreate.AutoSize = true;
            this.cbTrackCreate.Checked = true;
            this.cbTrackCreate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTrackCreate.Location = new System.Drawing.Point(12, 277);
            this.cbTrackCreate.Name = "cbTrackCreate";
            this.cbTrackCreate.Size = new System.Drawing.Size(119, 17);
            this.cbTrackCreate.TabIndex = 10;
            this.cbTrackCreate.Text = "Track Create Event";
            this.cbTrackCreate.UseVisualStyleBackColor = true;
            // 
            // cbTrackDelete
            // 
            this.cbTrackDelete.AutoSize = true;
            this.cbTrackDelete.Checked = true;
            this.cbTrackDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTrackDelete.Location = new System.Drawing.Point(12, 301);
            this.cbTrackDelete.Name = "cbTrackDelete";
            this.cbTrackDelete.Size = new System.Drawing.Size(119, 17);
            this.cbTrackDelete.TabIndex = 11;
            this.cbTrackDelete.Text = "Track Delete Event";
            this.cbTrackDelete.UseVisualStyleBackColor = true;
            // 
            // cbTrackRename
            // 
            this.cbTrackRename.AutoSize = true;
            this.cbTrackRename.Location = new System.Drawing.Point(12, 325);
            this.cbTrackRename.Name = "cbTrackRename";
            this.cbTrackRename.Size = new System.Drawing.Size(128, 17);
            this.cbTrackRename.TabIndex = 12;
            this.cbTrackRename.Text = "Track Rename Event";
            this.cbTrackRename.UseVisualStyleBackColor = true;
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.miHelp});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1365, 24);
            this.msMenu.TabIndex = 13;
            this.msMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTrack,
            this.miClear,
            this.miClose});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // miTrack
            // 
            this.miTrack.Name = "miTrack";
            this.miTrack.Size = new System.Drawing.Size(103, 22);
            this.miTrack.Text = "&Track";
            this.miTrack.Click += new System.EventHandler(this.bTrack_Click);
            // 
            // miClear
            // 
            this.miClear.Name = "miClear";
            this.miClear.Size = new System.Drawing.Size(103, 22);
            this.miClear.Text = "C&lear";
            this.miClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // miClose
            // 
            this.miClose.Name = "miClose";
            this.miClose.Size = new System.Drawing.Size(103, 22);
            this.miClose.Text = "&Close";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // miHelp
            // 
            this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(24, 20);
            this.miHelp.Text = "&?";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(107, 22);
            this.miAbout.Text = "&About";
            // 
            // FileTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 561);
            this.Controls.Add(this.cbTrackRename);
            this.Controls.Add(this.cbTrackDelete);
            this.Controls.Add(this.cbTrackCreate);
            this.Controls.Add(this.cbTrackChange);
            this.Controls.Add(this.cbTrackUsernames);
            this.Controls.Add(this.cbSubdirectories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.lPath);
            this.Controls.Add(this.tPath);
            this.Controls.Add(this.bTrack);
            this.Controls.Add(this.lvResults);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "FileTracker";
            this.Text = "FileTracker";
            this.Load += new System.EventHandler(this.FileTracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fsWatcher)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.ColumnHeader cImage;
        private System.Windows.Forms.ColumnHeader cFileName;
        private System.Windows.Forms.ColumnHeader cState;
        private System.Windows.Forms.ColumnHeader cSize;
        private System.Windows.Forms.ColumnHeader cUser;
        private System.Windows.Forms.ColumnHeader cPath;
        private System.Windows.Forms.Button bTrack;
        private System.Windows.Forms.TextBox tPath;
        private System.Windows.Forms.Label lPath;
        private System.IO.FileSystemWatcher fsWatcher;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.FolderBrowserDialog fBDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbTrackRename;
        private System.Windows.Forms.CheckBox cbTrackDelete;
        private System.Windows.Forms.CheckBox cbTrackCreate;
        private System.Windows.Forms.CheckBox cbTrackChange;
        private System.Windows.Forms.CheckBox cbTrackUsernames;
        private System.Windows.Forms.CheckBox cbSubdirectories;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miTrack;
        private System.Windows.Forms.ToolStripMenuItem miClear;
        private System.Windows.Forms.ToolStripMenuItem miClose;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
    }
}

