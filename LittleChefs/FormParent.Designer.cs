namespace LittleChefs
{
    partial class FormParent
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
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.parent_work_street = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.parent_work_zip = new System.Windows.Forms.TextBox();
            this.parent_work_city = new System.Windows.Forms.TextBox();
            this.parent_work_state = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.parent_work_room = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guardian_rb = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.mother_rb = new System.Windows.Forms.RadioButton();
            this.father_rb = new System.Windows.Forms.RadioButton();
            this.parent_phone_two = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.parent_phone_three = new System.Windows.Forms.TextBox();
            this.parent_ln = new System.Windows.Forms.TextBox();
            this.parent_phone_one = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.parent_fn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(330, 362);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(68, 45);
            this.cancel.TabIndex = 58;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(256, 362);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(68, 45);
            this.save.TabIndex = 55;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(182, 362);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(68, 45);
            this.delete.TabIndex = 50;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 25);
            this.label10.TabIndex = 81;
            this.label10.Text = "Parent Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.parent_work_street);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.parent_work_zip);
            this.groupBox2.Controls.Add(this.parent_work_city);
            this.groupBox2.Controls.Add(this.parent_work_state);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.parent_work_room);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 136);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Work Address Information";
            // 
            // parent_work_street
            // 
            this.parent_work_street.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parent_work_street.Location = new System.Drawing.Point(5, 21);
            this.parent_work_street.MaxLength = 75;
            this.parent_work_street.Name = "parent_work_street";
            this.parent_work_street.Size = new System.Drawing.Size(255, 26);
            this.parent_work_street.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 89;
            this.label1.Text = "Work City";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(280, 50);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 19);
            this.label23.TabIndex = 86;
            this.label23.Text = "Ste/Room";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(2, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(239, 19);
            this.label16.TabIndex = 87;
            this.label16.Text = "Work Street";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // parent_work_zip
            // 
            this.parent_work_zip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parent_work_zip.Location = new System.Drawing.Point(291, 78);
            this.parent_work_zip.MaxLength = 5;
            this.parent_work_zip.Name = "parent_work_zip";
            this.parent_work_zip.Size = new System.Drawing.Size(76, 26);
            this.parent_work_zip.TabIndex = 92;
            // 
            // parent_work_city
            // 
            this.parent_work_city.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parent_work_city.Location = new System.Drawing.Point(5, 78);
            this.parent_work_city.MaxLength = 25;
            this.parent_work_city.Name = "parent_work_city";
            this.parent_work_city.Size = new System.Drawing.Size(161, 26);
            this.parent_work_city.TabIndex = 88;
            // 
            // parent_work_state
            // 
            this.parent_work_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parent_work_state.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parent_work_state.FormattingEnabled = true;
            this.parent_work_state.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.parent_work_state.Location = new System.Drawing.Point(198, 77);
            this.parent_work_state.Name = "parent_work_state";
            this.parent_work_state.Size = new System.Drawing.Size(59, 27);
            this.parent_work_state.TabIndex = 91;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(288, 107);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 15);
            this.label21.TabIndex = 93;
            this.label21.Text = "Work Zip";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // parent_work_room
            // 
            this.parent_work_room.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parent_work_room.Location = new System.Drawing.Point(280, 21);
            this.parent_work_room.MaxLength = 8;
            this.parent_work_room.Name = "parent_work_room";
            this.parent_work_room.Size = new System.Drawing.Size(76, 26);
            this.parent_work_room.TabIndex = 85;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(198, 107);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 16);
            this.label22.TabIndex = 90;
            this.label22.Text = "State";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.guardian_rb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mother_rb);
            this.groupBox1.Controls.Add(this.father_rb);
            this.groupBox1.Controls.Add(this.parent_phone_two);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.parent_phone_three);
            this.groupBox1.Controls.Add(this.parent_ln);
            this.groupBox1.Controls.Add(this.parent_phone_one);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.parent_fn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 177);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parent Information";
            // 
            // guardian_rb
            // 
            this.guardian_rb.AutoSize = true;
            this.guardian_rb.Location = new System.Drawing.Point(304, 85);
            this.guardian_rb.Name = "guardian_rb";
            this.guardian_rb.Size = new System.Drawing.Size(81, 20);
            this.guardian_rb.TabIndex = 87;
            this.guardian_rb.TabStop = true;
            this.guardian_rb.Text = "Guardian";
            this.guardian_rb.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 88;
            this.label3.Text = "First Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mother_rb
            // 
            this.mother_rb.AutoSize = true;
            this.mother_rb.Location = new System.Drawing.Point(170, 84);
            this.mother_rb.Name = "mother_rb";
            this.mother_rb.Size = new System.Drawing.Size(67, 20);
            this.mother_rb.TabIndex = 85;
            this.mother_rb.TabStop = true;
            this.mother_rb.Text = "Mother";
            this.mother_rb.UseVisualStyleBackColor = true;
            // 
            // father_rb
            // 
            this.father_rb.AutoSize = true;
            this.father_rb.Location = new System.Drawing.Point(243, 85);
            this.father_rb.Name = "father_rb";
            this.father_rb.Size = new System.Drawing.Size(64, 20);
            this.father_rb.TabIndex = 86;
            this.father_rb.TabStop = true;
            this.father_rb.Text = "Father";
            this.father_rb.UseVisualStyleBackColor = true;
            // 
            // parent_phone_two
            // 
            this.parent_phone_two.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parent_phone_two.Location = new System.Drawing.Point(51, 79);
            this.parent_phone_two.MaxLength = 3;
            this.parent_phone_two.Name = "parent_phone_two";
            this.parent_phone_two.Size = new System.Drawing.Size(39, 26);
            this.parent_phone_two.TabIndex = 94;
            this.parent_phone_two.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(167, 104);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(196, 16);
            this.label20.TabIndex = 84;
            this.label20.Text = "Relationship";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // parent_phone_three
            // 
            this.parent_phone_three.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parent_phone_three.Location = new System.Drawing.Point(96, 79);
            this.parent_phone_three.MaxLength = 4;
            this.parent_phone_three.Name = "parent_phone_three";
            this.parent_phone_three.Size = new System.Drawing.Size(59, 26);
            this.parent_phone_three.TabIndex = 93;
            this.parent_phone_three.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // parent_ln
            // 
            this.parent_ln.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parent_ln.Location = new System.Drawing.Point(220, 21);
            this.parent_ln.MaxLength = 20;
            this.parent_ln.Name = "parent_ln";
            this.parent_ln.Size = new System.Drawing.Size(150, 26);
            this.parent_ln.TabIndex = 91;
            // 
            // parent_phone_one
            // 
            this.parent_phone_one.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parent_phone_one.Location = new System.Drawing.Point(6, 79);
            this.parent_phone_one.MaxLength = 3;
            this.parent_phone_one.Name = "parent_phone_one";
            this.parent_phone_one.Size = new System.Drawing.Size(39, 26);
            this.parent_phone_one.TabIndex = 92;
            this.parent_phone_one.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 18);
            this.label7.TabIndex = 84;
            this.label7.Text = "Phone";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // parent_fn
            // 
            this.parent_fn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parent_fn.Location = new System.Drawing.Point(6, 21);
            this.parent_fn.MaxLength = 20;
            this.parent_fn.Name = "parent_fn";
            this.parent_fn.Size = new System.Drawing.Size(150, 26);
            this.parent_fn.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 89;
            this.label4.Text = "Last Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 14);
            this.label14.TabIndex = 96;
            this.label14.Text = "E-mail";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(9, 129);
            this.email.MaxLength = 50;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(177, 22);
            this.email.TabIndex = 95;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parent Information";
            this.TopMost = true;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox parent_phone_two;
        private System.Windows.Forms.TextBox parent_phone_three;
        private System.Windows.Forms.TextBox parent_ln;
        private System.Windows.Forms.TextBox parent_phone_one;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox parent_fn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox parent_work_street;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox parent_work_zip;
        private System.Windows.Forms.TextBox parent_work_city;
        private System.Windows.Forms.ComboBox parent_work_state;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox parent_work_room;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RadioButton guardian_rb;
        private System.Windows.Forms.RadioButton mother_rb;
        private System.Windows.Forms.RadioButton father_rb;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox email;
    }
}