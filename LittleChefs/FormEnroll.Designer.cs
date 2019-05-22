namespace LittleChefs
{
    partial class FormEnroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnroll));
            this.add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedCourses = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.search_results = new System.Windows.Forms.ListBox();
            this.search_entry = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.student_schedule = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(153, 170);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(46, 36);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Enrollment";
            // 
            // selectedCourses
            // 
            this.selectedCourses.FormattingEnabled = true;
            this.selectedCourses.Location = new System.Drawing.Point(205, 124);
            this.selectedCourses.Name = "selectedCourses";
            this.selectedCourses.Size = new System.Drawing.Size(139, 147);
            this.selectedCourses.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "^";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.upButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 23);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.downButton_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(153, 212);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(46, 22);
            this.delete.TabIndex = 9;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(5, 54);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(274, 18);
            this.name.TabIndex = 38;
            this.name.Text = "Student_Name";
            // 
            // search_results
            // 
            this.search_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_results.FormattingEnabled = true;
            this.search_results.ItemHeight = 18;
            this.search_results.Location = new System.Drawing.Point(8, 124);
            this.search_results.Name = "search_results";
            this.search_results.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.search_results.Size = new System.Drawing.Size(139, 148);
            this.search_results.TabIndex = 40;
            // 
            // search_entry
            // 
            this.search_entry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.search_entry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.search_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_entry.Location = new System.Drawing.Point(8, 96);
            this.search_entry.MaxLength = 100;
            this.search_entry.Name = "search_entry";
            this.search_entry.Size = new System.Drawing.Size(139, 22);
            this.search_entry.TabIndex = 39;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(153, 96);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(46, 22);
            this.search.TabIndex = 42;
            this.search.Text = "->";
            this.search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(433, 205);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(68, 45);
            this.save.TabIndex = 43;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(433, 256);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(68, 45);
            this.cancel.TabIndex = 44;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // student_schedule
            // 
            this.student_schedule.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.student_schedule.Location = new System.Drawing.Point(412, 43);
            this.student_schedule.Name = "student_schedule";
            this.student_schedule.Size = new System.Drawing.Size(68, 38);
            this.student_schedule.TabIndex = 45;
            this.student_schedule.Text = "Student Schedule";
            this.student_schedule.UseVisualStyleBackColor = true;
            this.student_schedule.Click += new System.EventHandler(this.student_schedule_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(101, 278);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(46, 22);
            this.clear.TabIndex = 46;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.student_schedule);
            this.panel1.Controls.Add(this.search_entry);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.selectedCourses);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.search_results);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 311);
            this.panel1.TabIndex = 47;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(520, 25);
            this.toolStrip1.TabIndex = 48;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 22);
            this.toolStripButton1.Text = "Catalog";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 343);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enroll";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox selectedCourses;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ListBox search_results;
        private System.Windows.Forms.TextBox search_entry;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button student_schedule;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}