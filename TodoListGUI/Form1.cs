using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TodoListGUI
{
    public partial class Form1 : Form
    {
        private readonly string _dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tasks.txt");

        public Form1()
        {
            InitializeComponent();
            cmbFilter.SelectedIndex = 0; // All
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
        }

        // Model
        class TaskItem
        {
            public bool Done;
            public string Text;
            public override string ToString() { return Text; }
        }

        private readonly List<TaskItem> _all = new List<TaskItem>();

        // ----- Events -----

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFromFile();
            RefreshList();
            UpdateCounters();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToFile();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var t = (txtNew.Text ?? "").Trim();
            if (t.Length == 0) { MessageBox.Show("Enter a task."); txtNew.Focus(); return; }
            _all.Add(new TaskItem { Done = false, Text = t });
            txtNew.Clear();
            RefreshList();
            UpdateCounters();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete selected visible items
            var toDelete = new List<TaskItem>();
            foreach (int i in clbTasks.SelectedIndices)
            {
                var model = (TaskItem)clbTasks.Items[i];
                toDelete.Add(model);
            }
            if (toDelete.Count == 0) { MessageBox.Show("Select at least one task to delete."); return; }
            foreach (var m in toDelete) _all.Remove(m);
            RefreshList();
            UpdateCounters();
        }

        private void btnClearCompleted_Click(object sender, EventArgs e)
        {
            int removed = _all.RemoveAll(t => t.Done);
            if (removed == 0) { MessageBox.Show("No completed tasks to clear."); return; }
            RefreshList();
            UpdateCounters();
        }

        private void clbTasks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Update model when user checks/unchecks
            // Delay until after state changes: use BeginInvoke
            this.BeginInvoke((Action)(() =>
            {
                if (e.Index < 0 || e.Index >= clbTasks.Items.Count) return;
                var item = (TaskItem)clbTasks.Items[e.Index];
                item.Done = clbTasks.GetItemChecked(e.Index);
                UpdateCounters();
            }));
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveToFile();
            MessageBox.Show("Saved ✅");
        }

        // ----- Helpers -----

        private void RefreshList()
        {
            clbTasks.BeginUpdate();
            clbTasks.Items.Clear();

            IEnumerable<TaskItem> view = _all;
            switch (cmbFilter.SelectedIndex) // 0 All, 1 Active, 2 Completed
            {
                case 1: view = _all.Where(t => !t.Done); break;
                case 2: view = _all.Where(t => t.Done); break;
            }

            foreach (var t in view)
            {
                int idx = clbTasks.Items.Add(t);
                clbTasks.SetItemChecked(idx, t.Done);
            }
            clbTasks.EndUpdate();
        }

        private void UpdateCounters()
        {
            int total = _all.Count;
            int done = _all.Count(t => t.Done);
            int left = total - done;
            lblCounts.Text = string.Format("Total: {0}   Done: {1}   Left: {2}", total, done, left);
        }

        private void LoadFromFile()
        {
            _all.Clear();
            if (!File.Exists(_dataPath)) return;
            try
            {
                // Format per line: 0|Task text   or   1|Task text
                foreach (var line in File.ReadAllLines(_dataPath))
                {
                    if (line.Trim().Length == 0) continue;
                    var split = line.Split(new[] { '|' }, 2);
                    if (split.Length == 2)
                    {
                        bool done = split[0] == "1";
                        string text = split[1];
                        _all.Add(new TaskItem { Done = done, Text = text });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load tasks: " + ex.Message);
            }
        }

        private void SaveToFile()
        {
            try
            {
                var lines = _all.Select(t => (t.Done ? "1" : "0") + "|" + t.Text).ToArray();
                File.WriteAllLines(_dataPath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save tasks: " + ex.Message);
            }
        }
    }
}
