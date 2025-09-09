namespace TodoListGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckedListBox clbTasks;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearCompleted;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblCounts;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNew = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.clbTasks = new System.Windows.Forms.CheckedListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearCompleted = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblCounts = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(16, 16);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(290, 20);
            this.txtNew.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(316, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 24);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // clbTasks
            // 
            this.clbTasks.CheckOnClick = true;
            this.clbTasks.FormattingEnabled = true;
            this.clbTasks.Location = new System.Drawing.Point(16, 50);
            this.clbTasks.Name = "clbTasks";
            this.clbTasks.Size = new System.Drawing.Size(360, 169);
            this.clbTasks.TabIndex = 2;
            this.clbTasks.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbTasks_ItemCheck);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 226);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 26);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearCompleted
            // 
            this.btnClearCompleted.Location = new System.Drawing.Point(116, 226);
            this.btnClearCompleted.Name = "btnClearCompleted";
            this.btnClearCompleted.Size = new System.Drawing.Size(110, 26);
            this.btnClearCompleted.TabIndex = 4;
            this.btnClearCompleted.Text = "Clear Completed";
            this.btnClearCompleted.UseVisualStyleBackColor = true;
            this.btnClearCompleted.Click += new System.EventHandler(this.btnClearCompleted_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "All",
            "Active",
            "Completed"});
            this.cmbFilter.Location = new System.Drawing.Point(276, 228);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(100, 21);
            this.cmbFilter.TabIndex = 5;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(236, 232);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(32, 13);
            this.lblFilter.TabIndex = 6;
            this.lblFilter.Text = "Filter:";
            // 
            // lblCounts
            // 
            this.lblCounts.AutoSize = true;
            this.lblCounts.Location = new System.Drawing.Point(16, 262);
            this.lblCounts.Name = "lblCounts";
            this.lblCounts.Size = new System.Drawing.Size(98, 13);
            this.lblCounts.TabIndex = 7;
            this.lblCounts.Text = "Total: 0   Done: 0   Left: 0";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(316, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 24);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Now";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 292);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCounts);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.btnClearCompleted);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.clbTasks);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To-Do List (Day 17)";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
