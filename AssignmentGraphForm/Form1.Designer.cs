namespace AssignmentGraphForm
{
    partial class Form1
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
            this.buttonExit = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.distanceTexbox = new System.Windows.Forms.TextBox();
            this.arrivalTexBox = new System.Windows.Forms.TextBox();
            this.departureTexBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.AddButton = new MetroFramework.Controls.MetroButton();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(622, 10);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(152, 47);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.listBox2);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.distanceTexbox);
            this.metroPanel1.Controls.Add(this.arrivalTexBox);
            this.metroPanel1.Controls.Add(this.departureTexBox);
            this.metroPanel1.Controls.Add(this.listBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(34, 70);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(796, 516);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Distance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Arrival Airport";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Departure Airport";
            // 
            // distanceTexbox
            // 
            this.distanceTexbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceTexbox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.distanceTexbox.Location = new System.Drawing.Point(238, 104);
            this.distanceTexbox.Name = "distanceTexbox";
            this.distanceTexbox.Size = new System.Drawing.Size(246, 30);
            this.distanceTexbox.TabIndex = 12;
            // 
            // arrivalTexBox
            // 
            this.arrivalTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalTexBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.arrivalTexBox.Location = new System.Drawing.Point(239, 60);
            this.arrivalTexBox.Name = "arrivalTexBox";
            this.arrivalTexBox.Size = new System.Drawing.Size(245, 30);
            this.arrivalTexBox.TabIndex = 11;
            // 
            // departureTexBox
            // 
            this.departureTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureTexBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.departureTexBox.Location = new System.Drawing.Point(238, 23);
            this.departureTexBox.Name = "departureTexBox";
            this.departureTexBox.Size = new System.Drawing.Size(246, 30);
            this.departureTexBox.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Azure;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(13, 157);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(449, 328);
            this.listBox1.TabIndex = 8;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroButton3);
            this.metroPanel2.Controls.Add(this.metroButton2);
            this.metroPanel2.Controls.Add(this.AddButton);
            this.metroPanel2.Controls.Add(this.buttonExit);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(34, 592);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(796, 71);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(421, 10);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(157, 47);
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Text = "Delete Flight";
            this.metroButton3.Click += new System.EventHandler(this.DeleteFlight_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(221, 9);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(166, 47);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Search Flight";
            this.metroButton2.Click += new System.EventHandler(this.SearchFlight_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(13, 9);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(167, 48);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add New Flight";
            this.AddButton.Click += new System.EventHandler(this.AddFlight_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Linen;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 22;
            this.listBox2.Location = new System.Drawing.Point(468, 157);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(308, 334);
            this.listBox2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 702);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Form1";
            this.Text = "Star Travel Agent";
            this.Load += new System.EventHandler(this.FormListAllFlights_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton buttonExit;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox distanceTexbox;
        private System.Windows.Forms.TextBox arrivalTexBox;
        private System.Windows.Forms.TextBox departureTexBox;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton AddButton;
        private System.Windows.Forms.ListBox listBox2;
    }
}

