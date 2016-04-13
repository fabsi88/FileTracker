using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileTracker
{
    public partial class FileTracker : Form
    {
        public FileTracker()
        {
            InitializeComponent();
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            var result = fBDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.tPath.Text = fBDialog.SelectedPath.ToString();
            }
        }

        private void bTrack_Click(object sender, EventArgs e)
        {
            if(tPath.TextLength == 0)
            {
                MessageBox.Show("Please fill the path!", "Path missing", MessageBoxButtons.OK);
                return;
            }
            if(bTrack.Text == "Track!")
            {
                bTrack.Text = "Stop!";
                fsWatcher.Path = tPath.Text;
                fsWatcher.IncludeSubdirectories = cbSubdirectories.Checked;
                fsWatcher.EnableRaisingEvents = true;
                
            }
            else if (bTrack.Text == "Stop!")
            {
                bTrack.Text = "Track!";
                fsWatcher.EnableRaisingEvents = false;
            }

        }

        private void bClear_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
            {
                lvResults.Items.Clear();
            }
        }

        private void fsWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            try
            {
                var item = new ListViewItem(new[] { "",e.Name, e.ChangeType.ToString(), (new FileInfo(e.FullPath)).Length.ToString(), "0", e.FullPath.ToString() });

                if (e.ChangeType == System.IO.WatcherChangeTypes.Changed && cbTrackChange.Checked)
                {
                    lvResults.Items.Add(item);
                }
                else if (e.ChangeType == System.IO.WatcherChangeTypes.Created && cbTrackCreate.Checked)
                {
                    lvResults.Items.Add(item);
                }
                else if (e.ChangeType == System.IO.WatcherChangeTypes.Deleted && cbTrackDelete.Checked)
                {
                    lvResults.Items.Add(item);
                }
                else if (e.ChangeType == System.IO.WatcherChangeTypes.Renamed && cbTrackRename.Checked)
                {
                    lvResults.Items.Add(item);
                }
                fsWatcher.EnableRaisingEvents = false;
            }
            finally
            {
                fsWatcher.EnableRaisingEvents = true;
            }   
        }

        private void fsWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void fsWatcher_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void fsWatcher_Renamed(object sender, System.IO.RenamedEventArgs e)
        {

        }

        private void miClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FileTracker_Load(object sender, EventArgs e)
        {
            fsWatcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;

        }
    }
}
