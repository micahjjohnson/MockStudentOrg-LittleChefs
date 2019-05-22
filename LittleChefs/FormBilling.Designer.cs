namespace LittleChefs
{
    partial class FormBilling
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
            this.S_Address = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.zip = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.ComboBox();
            this.city = new System.Windows.Forms.TextBox();
            this.line2 = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.details = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notes_TB = new System.Windows.Forms.RichTextBox();
            this.new_payment = new System.Windows.Forms.Button();
            this.tax = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.due = new System.Windows.Forms.Label();
            this.sub = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.billingPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.billList = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.idLabel = new System.Windows.Forms.ToolStripLabel();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.billingPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // S_Address
            // 
            this.S_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Address.Location = new System.Drawing.Point(6, 23);
            this.S_Address.Name = "S_Address";
            this.S_Address.Size = new System.Drawing.Size(177, 89);
            this.S_Address.TabIndex = 3;
            this.S_Address.Text = "<address>";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(111, 140);
            this.phone.MaxLength = 10;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(206, 21);
            this.phone.TabIndex = 74;
            // 
            // zip
            // 
            this.zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zip.Location = new System.Drawing.Point(258, 105);
            this.zip.MaxLength = 5;
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(59, 21);
            this.zip.TabIndex = 62;
            // 
            // state
            // 
            this.state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.state.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.state.Location = new System.Drawing.Point(206, 103);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(45, 23);
            this.state.TabIndex = 61;
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(111, 105);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(89, 21);
            this.city.TabIndex = 60;
            // 
            // line2
            // 
            this.line2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line2.Location = new System.Drawing.Point(111, 78);
            this.line2.MaxLength = 6;
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(206, 21);
            this.line2.TabIndex = 59;
            // 
            // street
            // 
            this.street.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.street.Location = new System.Drawing.Point(111, 51);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(206, 21);
            this.street.TabIndex = 58;
            // 
            // details
            // 
            this.details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7});
            this.details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.FullRowSelect = true;
            this.details.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.details.Location = new System.Drawing.Point(6, 21);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(616, 201);
            this.details.TabIndex = 3;
            this.details.UseCompatibleStateImageBehavior = false;
            this.details.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Date";
            this.columnHeader9.Width = 99;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Post Date";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Method";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 102;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Employee Id";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 165;
            // 
            // notes_TB
            // 
            this.notes_TB.Location = new System.Drawing.Point(6, 21);
            this.notes_TB.MaxLength = 2000;
            this.notes_TB.Name = "notes_TB";
            this.notes_TB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.notes_TB.Size = new System.Drawing.Size(410, 100);
            this.notes_TB.TabIndex = 0;
            this.notes_TB.Text = "";
            // 
            // new_payment
            // 
            this.new_payment.Location = new System.Drawing.Point(645, 469);
            this.new_payment.Name = "new_payment";
            this.new_payment.Size = new System.Drawing.Size(68, 45);
            this.new_payment.TabIndex = 4;
            this.new_payment.Text = "New Payment";
            this.new_payment.UseVisualStyleBackColor = true;
            this.new_payment.Click += new System.EventHandler(this.new_payment_Click);
            // 
            // tax
            // 
            this.tax.Location = new System.Drawing.Point(132, 50);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(73, 16);
            this.tax.TabIndex = 20;
            this.tax.Text = "$ 0";
            this.tax.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(132, 78);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(73, 16);
            this.total.TabIndex = 19;
            this.total.Text = "$ 0";
            this.total.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // due
            // 
            this.due.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.due.ForeColor = System.Drawing.Color.Red;
            this.due.Location = new System.Drawing.Point(132, 105);
            this.due.Name = "due";
            this.due.Size = new System.Drawing.Size(73, 16);
            this.due.TabIndex = 18;
            this.due.Text = "label10";
            this.due.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(132, 21);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(73, 16);
            this.sub.TabIndex = 17;
            this.sub.Text = "$ 0";
            this.sub.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Subtotal";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tax";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(6, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Balance Due";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(6, 64);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(94, 20);
            this.checkBox5.TabIndex = 80;
            this.checkBox5.Text = "Store Copy";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(6, 85);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(112, 20);
            this.checkBox4.TabIndex = 79;
            this.checkBox4.Text = "Include Return";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(6, 43);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(119, 20);
            this.checkBox2.TabIndex = 77;
            this.checkBox2.Text = "Customer Copy";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(6, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 20);
            this.checkBox1.TabIndex = 76;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Billing Information";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(721, 260);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 24);
            this.button5.TabIndex = 84;
            this.button5.Text = "e-mail";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(721, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 24);
            this.button4.TabIndex = 83;
            this.button4.Text = "Print Preview";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(645, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 45);
            this.button3.TabIndex = 82;
            this.button3.Text = "View Schedule";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox5);
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Controls.Add(this.checkBox2);
            this.groupBox6.Controls.Add(this.checkBox4);
            this.groupBox6.Location = new System.Drawing.Point(721, 83);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(131, 110);
            this.groupBox6.TabIndex = 81;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Print Options";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.tax);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.total);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.due);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.sub);
            this.groupBox5.Location = new System.Drawing.Point(477, 532);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(216, 128);
            this.groupBox5.TabIndex = 80;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Account Details";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.notes_TB);
            this.groupBox4.Location = new System.Drawing.Point(10, 532);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 128);
            this.groupBox4.TabIndex = 79;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Notes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.details);
            this.groupBox3.Location = new System.Drawing.Point(10, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(629, 230);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "History";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.city);
            this.groupBox2.Controls.Add(this.line2);
            this.groupBox2.Controls.Add(this.name);
            this.groupBox2.Controls.Add(this.state);
            this.groupBox2.Controls.Add(this.phone);
            this.groupBox2.Controls.Add(this.street);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.zip);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(10, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 174);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Information";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 18);
            this.label11.TabIndex = 5;
            this.label11.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(111, 23);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(206, 20);
            this.name.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 18);
            this.label13.TabIndex = 63;
            this.label13.Text = "Phone";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Billing Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.S_Address);
            this.groupBox1.Location = new System.Drawing.Point(430, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 128);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address Label";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(721, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 24);
            this.button2.TabIndex = 21;
            this.button2.Text = "Print";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(784, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 45);
            this.button1.TabIndex = 20;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.saveNotes_Click);
            // 
            // billingPanel
            // 
            this.billingPanel.AutoScroll = true;
            this.billingPanel.Controls.Add(this.toolStrip1);
            this.billingPanel.Controls.Add(this.button5);
            this.billingPanel.Controls.Add(this.label3);
            this.billingPanel.Controls.Add(this.button4);
            this.billingPanel.Controls.Add(this.button1);
            this.billingPanel.Controls.Add(this.button3);
            this.billingPanel.Controls.Add(this.button2);
            this.billingPanel.Controls.Add(this.groupBox6);
            this.billingPanel.Controls.Add(this.groupBox1);
            this.billingPanel.Controls.Add(this.groupBox5);
            this.billingPanel.Controls.Add(this.groupBox2);
            this.billingPanel.Controls.Add(this.groupBox4);
            this.billingPanel.Controls.Add(this.new_payment);
            this.billingPanel.Controls.Add(this.groupBox3);
            this.billingPanel.Location = new System.Drawing.Point(12, 12);
            this.billingPanel.Name = "billingPanel";
            this.billingPanel.Size = new System.Drawing.Size(882, 673);
            this.billingPanel.TabIndex = 20;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idLabel,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.billList});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(882, 25);
            this.toolStrip1.TabIndex = 87;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(102, 22);
            this.toolStripLabel1.Text = "Select Bill to View:";
            // 
            // billList
            // 
            this.billList.Name = "billList";
            this.billList.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // idLabel
            // 
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(86, 22);
            this.idLabel.Text = "toolStripLabel2";
            // 
            // FormBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1406, 694);
            this.Controls.Add(this.billingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Billing Information";
            this.TopMost = true;
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.billingPanel.ResumeLayout(false);
            this.billingPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button new_payment;
        private System.Windows.Forms.Label S_Address;
        private System.Windows.Forms.ListView details;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label tax;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label due;
        private System.Windows.Forms.Label sub;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox notes_TB;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.ComboBox state;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox line2;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel billingPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel idLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox billList;
    }
}