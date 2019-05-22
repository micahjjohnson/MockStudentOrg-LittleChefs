namespace LittleChefs
{
    partial class Form14
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
            this.weekPanelReference = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // weekPanelReference
            // 
            this.weekPanelReference.Location = new System.Drawing.Point(12, 174);
            this.weekPanelReference.Name = "weekPanelReference";
            this.weekPanelReference.Size = new System.Drawing.Size(784, 180);
            this.weekPanelReference.TabIndex = 0;
            this.weekPanelReference.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 180);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.weekPanelReference);
            this.Name = "Form14";
            this.Text = "Form14";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel weekPanelReference;
        private System.Windows.Forms.Panel panel1;
    }
}