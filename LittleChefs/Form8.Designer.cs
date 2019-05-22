namespace LittleChefs
{
    partial class Form8
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
            this.week_Container = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resize_bt = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.dailyButtons_rc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.classActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.holidayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weatherEmergencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.week_Container)).BeginInit();
            this.week_Container.Panel1.SuspendLayout();
            this.week_Container.Panel2.SuspendLayout();
            this.week_Container.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.dailyButtons_rc.SuspendLayout();
            this.SuspendLayout();
            // 
            // week_Container
            // 
            this.week_Container.Location = new System.Drawing.Point(12, 12);
            this.week_Container.Name = "week_Container";
            this.week_Container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // week_Container.Panel1
            // 
            this.week_Container.Panel1.Controls.Add(this.groupBox2);
            // 
            // week_Container.Panel2
            // 
            this.week_Container.Panel2.Controls.Add(this.groupBox1);
            this.week_Container.Size = new System.Drawing.Size(784, 180);
            this.week_Container.SplitterDistance = 45;
            this.week_Container.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resize_bt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 42);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Week One";
            // 
            // resize_bt
            // 
            this.resize_bt.Appearance = System.Windows.Forms.Appearance.Button;
            this.resize_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resize_bt.Location = new System.Drawing.Point(34, 15);
            this.resize_bt.Name = "resize_bt";
            this.resize_bt.Size = new System.Drawing.Size(103, 21);
            this.resize_bt.TabIndex = 1;
            this.resize_bt.Text = "expand";
            this.resize_bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resize_bt.UseVisualStyleBackColor = true;
            this.resize_bt.CheckedChanged += new System.EventHandler(this.resize_bt_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 119);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(660, 16);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 97);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            // 
            // dailyButtons_rc
            // 
            this.dailyButtons_rc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classActionsToolStripMenuItem});
            this.dailyButtons_rc.Name = "dailyButtons_rc";
            this.dailyButtons_rc.Size = new System.Drawing.Size(145, 26);
            // 
            // classActionsToolStripMenuItem
            // 
            this.classActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelClassToolStripMenuItem,
            this.notifyStudentsToolStripMenuItem,
            this.markAsToolStripMenuItem});
            this.classActionsToolStripMenuItem.Name = "classActionsToolStripMenuItem";
            this.classActionsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.classActionsToolStripMenuItem.Text = "Class Actions";
            // 
            // cancelClassToolStripMenuItem
            // 
            this.cancelClassToolStripMenuItem.Name = "cancelClassToolStripMenuItem";
            this.cancelClassToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cancelClassToolStripMenuItem.Text = "Cancel class";
            this.cancelClassToolStripMenuItem.Click += new System.EventHandler(this.cancelClassToolStripMenuItem_Click);
            // 
            // notifyStudentsToolStripMenuItem
            // 
            this.notifyStudentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byEmailToolStripMenuItem});
            this.notifyStudentsToolStripMenuItem.Name = "notifyStudentsToolStripMenuItem";
            this.notifyStudentsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.notifyStudentsToolStripMenuItem.Text = "Notify students...";
            // 
            // byEmailToolStripMenuItem
            // 
            this.byEmailToolStripMenuItem.Name = "byEmailToolStripMenuItem";
            this.byEmailToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.byEmailToolStripMenuItem.Text = "By e-mail";
            // 
            // markAsToolStripMenuItem
            // 
            this.markAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holidayToolStripMenuItem,
            this.weatherEmergencyToolStripMenuItem,
            this.noneToolStripMenuItem});
            this.markAsToolStripMenuItem.Name = "markAsToolStripMenuItem";
            this.markAsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.markAsToolStripMenuItem.Text = "Mark as...";
            // 
            // holidayToolStripMenuItem
            // 
            this.holidayToolStripMenuItem.Name = "holidayToolStripMenuItem";
            this.holidayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.holidayToolStripMenuItem.Text = "Holiday";
            // 
            // weatherEmergencyToolStripMenuItem
            // 
            this.weatherEmergencyToolStripMenuItem.Name = "weatherEmergencyToolStripMenuItem";
            this.weatherEmergencyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.weatherEmergencyToolStripMenuItem.Text = "Weather Emergency";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noneToolStripMenuItem.Text = "None";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(551, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 97);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(442, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 97);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(333, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 97);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 97);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 97);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.dailyButtons_rc;
            this.button1.Location = new System.Drawing.Point(6, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 97);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 274);
            this.ContextMenuStrip = this.dailyButtons_rc;
            this.Controls.Add(this.week_Container);
            this.Name = "Form8";
            this.Text = "Form8";
            this.week_Container.Panel1.ResumeLayout(false);
            this.week_Container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.week_Container)).EndInit();
            this.week_Container.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.dailyButtons_rc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer week_Container;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox resize_bt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ContextMenuStrip dailyButtons_rc;
        private System.Windows.Forms.ToolStripMenuItem classActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notifyStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holidayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weatherEmergencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
    }
}