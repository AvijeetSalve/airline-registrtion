namespace Airline_registration
{
    partial class Viewflight
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DestCb = new System.Windows.Forms.ComboBox();
            this.SourceCb = new System.Windows.Forms.ComboBox();
            this.Seatnum = new System.Windows.Forms.TextBox();
            this.FcodeTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FlightDGV = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FlightDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(298, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(326, 34);
            this.label8.TabIndex = 5;
            this.label8.Text = "View Scheduled Flights";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(352, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 34);
            this.label7.TabIndex = 4;
            this.label7.Text = "Skynet Airlines";
            // 
            // FDate
            // 
            this.FDate.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FDate.Location = new System.Drawing.Point(193, 262);
            this.FDate.Name = "FDate";
            this.FDate.Size = new System.Drawing.Size(176, 27);
            this.FDate.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "TakeOffDate";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DestCb
            // 
            this.DestCb.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DestCb.ForeColor = System.Drawing.Color.Red;
            this.DestCb.FormattingEnabled = true;
            this.DestCb.Items.AddRange(new object[] {
            "Chandigarh",
            "Mangalore",
            "Patna",
            "Siliguri",
            "Madurai",
            "Jaipur",
            "Imphal",
            "Srinagar",
            "Nagpur",
            "Tiruchirappalli",
            "Hyderabad",
            "Varanasi",
            "Guwahati",
            "Bhubaneswar",
            "Coimbatore",
            "Thiruvananthapuram",
            "Pune ",
            "Goa",
            "Delhi",
            "Ahemdabad",
            "Kochi",
            "Indore",
            "Surat",
            "Kannur",
            "Amritsar",
            "Visakhapatnam",
            "Lucknow",
            "Kolkatta",
            "Chennai",
            "Banglore",
            "Mumbai",
            "New York",
            "Washington,DC",
            "Los Angeles",
            "Las Vegas",
            "London",
            "Dubai",
            "Tokyo",
            "Beijing",
            "Moscow",
            "Brazil",
            "Spain",
            "Barcelona",
            "Portugese",
            "Cuba",
            "Egypt",
            "Cairo",
            "Arizona",
            "Chicago",
            "Hokaido",
            "Hong Kong",
            "Singapore",
            "Malasiya",
            "Thailand",
            "Indonesia",
            "Fiji",
            "Kyoto",
            "Paris",
            "France",
            "Germany",
            "Chile",
            "Rome",
            "Italy",
            "Ireland",
            "New Zealand"});
            this.DestCb.Location = new System.Drawing.Point(608, 261);
            this.DestCb.Name = "DestCb";
            this.DestCb.Size = new System.Drawing.Size(176, 29);
            this.DestCb.TabIndex = 24;
            // 
            // SourceCb
            // 
            this.SourceCb.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourceCb.ForeColor = System.Drawing.Color.Red;
            this.SourceCb.FormattingEnabled = true;
            this.SourceCb.Items.AddRange(new object[] {
            "Chandigarh",
            "Mangalore",
            "Patna",
            "Siliguri",
            "Madurai",
            "Jaipur",
            "Imphal",
            "Srinagar",
            "Nagpur",
            "Tiruchirappalli",
            "Hyderabad",
            "Varanasi",
            "Guwahati",
            "Bhubaneswar",
            "Coimbatore",
            "Thiruvananthapuram",
            "Pune ",
            "Goa",
            "Delhi",
            "Ahemdabad",
            "Kochi",
            "Indore",
            "Surat",
            "Kannur",
            "Amritsar",
            "Visakhapatnam",
            "Lucknow",
            "Kolkatta",
            "Chennai",
            "Banglore",
            "Mumbai",
            "New York",
            "Washington,DC",
            "Los Angeles",
            "Las Vegas",
            "London",
            "Dubai",
            "Tokyo",
            "Beijing",
            "Moscow",
            "Brazil",
            "Spain",
            "Barcelona",
            "Portugese",
            "Cuba",
            "Egypt",
            "Cairo",
            "Arizona",
            "Chicago",
            "Hokaido",
            "Hong Kong",
            "Singapore",
            "Malasiya",
            "Thailand",
            "Indonesia",
            "Fiji",
            "Kyoto",
            "Paris",
            "France",
            "Germany",
            "Chile",
            "Rome",
            "Italy",
            "Ireland",
            "New Zealand"});
            this.SourceCb.Location = new System.Drawing.Point(608, 195);
            this.SourceCb.Name = "SourceCb";
            this.SourceCb.Size = new System.Drawing.Size(176, 29);
            this.SourceCb.TabIndex = 23;
            // 
            // Seatnum
            // 
            this.Seatnum.Location = new System.Drawing.Point(448, 344);
            this.Seatnum.Name = "Seatnum";
            this.Seatnum.Size = new System.Drawing.Size(176, 27);
            this.Seatnum.TabIndex = 22;
            // 
            // FcodeTb
            // 
            this.FcodeTb.Location = new System.Drawing.Point(193, 195);
            this.FcodeTb.Name = "FcodeTb";
            this.FcodeTb.Size = new System.Drawing.Size(176, 27);
            this.FcodeTb.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(253, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Number of Seats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(441, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(429, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Destinaton";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Flight Code";
            // 
            // FlightDGV
            // 
            this.FlightDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightDGV.Location = new System.Drawing.Point(12, 530);
            this.FlightDGV.Name = "FlightDGV";
            this.FlightDGV.RowHeadersWidth = 51;
            this.FlightDGV.RowTemplate.Height = 29;
            this.FlightDGV.Size = new System.Drawing.Size(845, 276);
            this.FlightDGV.TabIndex = 27;
            this.FlightDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightDGV_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(477, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 49);
            this.button2.TabIndex = 29;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(156, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 49);
            this.button1.TabIndex = 28;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(312, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 49);
            this.button3.TabIndex = 30;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(641, 433);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 49);
            this.button4.TabIndex = 31;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Viewflight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 818);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FlightDGV);
            this.Controls.Add(this.FDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DestCb);
            this.Controls.Add(this.SourceCb);
            this.Controls.Add(this.Seatnum);
            this.Controls.Add(this.FcodeTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Viewflight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewflight";
            this.Load += new System.EventHandler(this.Viewflight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private Label label7;
        private DateTimePicker FDate;
        private Label label1;
        private ComboBox DestCb;
        private ComboBox SourceCb;
        private TextBox Seatnum;
        private TextBox FcodeTb;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView FlightDGV;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}