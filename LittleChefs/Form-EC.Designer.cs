namespace LittleChefs
{
    partial class Form7
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phone_two = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.phone_three = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.phone_one = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.street = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.zip = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.room = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mother",
            "Father",
            "Sister",
            "Brother",
            "Grandmother",
            "Grandfather",
            "Neighbor",
            "Babysitter/Nanny"});
            this.comboBox1.Location = new System.Drawing.Point(205, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 24);
            this.comboBox1.TabIndex = 86;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.phone_two);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.phone_three);
            this.groupBox1.Controls.Add(this.lastname);
            this.groupBox1.Controls.Add(this.phone_one);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.firstname);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 137);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Information";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 17);
            this.label8.TabIndex = 88;
            this.label8.Text = "First Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phone_two
            // 
            this.phone_two.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_two.Location = new System.Drawing.Point(51, 79);
            this.phone_two.MaxLength = 3;
            this.phone_two.Name = "phone_two";
            this.phone_two.Size = new System.Drawing.Size(39, 26);
            this.phone_two.TabIndex = 94;
            this.phone_two.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(205, 108);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(151, 22);
            this.label20.TabIndex = 84;
            this.label20.Text = "Relationship";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phone_three
            // 
            this.phone_three.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_three.Location = new System.Drawing.Point(96, 79);
            this.phone_three.MaxLength = 4;
            this.phone_three.Name = "phone_three";
            this.phone_three.Size = new System.Drawing.Size(59, 26);
            this.phone_three.TabIndex = 93;
            this.phone_three.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(220, 21);
            this.lastname.MaxLength = 20;
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(150, 26);
            this.lastname.TabIndex = 91;
            // 
            // phone_one
            // 
            this.phone_one.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_one.Location = new System.Drawing.Point(6, 79);
            this.phone_one.MaxLength = 3;
            this.phone_one.Name = "phone_one";
            this.phone_one.Size = new System.Drawing.Size(39, 26);
            this.phone_one.TabIndex = 92;
            this.phone_one.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 18);
            this.label12.TabIndex = 84;
            this.label12.Text = "Phone";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstname
            // 
            this.firstname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(6, 21);
            this.firstname.MaxLength = 20;
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(150, 26);
            this.firstname.TabIndex = 90;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(220, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 16);
            this.label16.TabIndex = 89;
            this.label16.Text = "Last Name";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.street);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.zip);
            this.groupBox2.Controls.Add(this.city);
            this.groupBox2.Controls.Add(this.state);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.room);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 136);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address Information";
            // 
            // street
            // 
            this.street.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.street.Location = new System.Drawing.Point(5, 21);
            this.street.MaxLength = 75;
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(255, 26);
            this.street.TabIndex = 84;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(161, 16);
            this.label17.TabIndex = 89;
            this.label17.Text = "City";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(273, 51);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 19);
            this.label23.TabIndex = 86;
            this.label23.Text = "Apt/Ste/Room";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(2, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(239, 19);
            this.label18.TabIndex = 87;
            this.label18.Text = "Street";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // zip
            // 
            this.zip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zip.Location = new System.Drawing.Point(291, 78);
            this.zip.MaxLength = 5;
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(76, 26);
            this.zip.TabIndex = 92;
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(5, 78);
            this.city.MaxLength = 25;
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(161, 26);
            this.city.TabIndex = 88;
            // 
            // state
            // 
            this.state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.state.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.FormattingEnabled = true;
            this.state.Items.AddRange(new object[] {
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
            this.state.Location = new System.Drawing.Point(198, 77);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(59, 27);
            this.state.TabIndex = 91;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(291, 107);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 15);
            this.label21.TabIndex = 93;
            this.label21.Text = "Zip";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // room
            // 
            this.room.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room.Location = new System.Drawing.Point(280, 21);
            this.room.MaxLength = 8;
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(76, 26);
            this.room.TabIndex = 85;
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
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(341, 25);
            this.label19.TabIndex = 90;
            this.label19.Text = "Emergency Contact Information";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(182, 362);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(68, 45);
            this.delete.TabIndex = 87;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Visible = false;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(256, 362);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(68, 45);
            this.save.TabIndex = 88;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(330, 362);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(68, 45);
            this.cancel.TabIndex = 89;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Emergency Contacy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phone_two;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox phone_three;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox phone_one;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.ComboBox state;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox room;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
    }
}