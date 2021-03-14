namespace WindowsFormsApp2
{
    partial class BookingMenu
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
            this.btn_addBooking = new System.Windows.Forms.Button();
            this.btn_viewBookings = new System.Windows.Forms.Button();
            this.btn_backToMainMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xyzAirLinesLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addBooking
            // 
            this.btn_addBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_addBooking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_addBooking.Location = new System.Drawing.Point(0, 59);
            this.btn_addBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addBooking.Name = "btn_addBooking";
            this.btn_addBooking.Size = new System.Drawing.Size(240, 64);
            this.btn_addBooking.TabIndex = 0;
            this.btn_addBooking.Text = "Add booking";
            this.btn_addBooking.UseVisualStyleBackColor = true;
            this.btn_addBooking.Click += new System.EventHandler(this.btn_addBooking_Click);
            // 
            // btn_viewBookings
            // 
            this.btn_viewBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_viewBookings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_viewBookings.Location = new System.Drawing.Point(0, 123);
            this.btn_viewBookings.Margin = new System.Windows.Forms.Padding(2);
            this.btn_viewBookings.Name = "btn_viewBookings";
            this.btn_viewBookings.Size = new System.Drawing.Size(240, 64);
            this.btn_viewBookings.TabIndex = 0;
            this.btn_viewBookings.Text = "View bookings";
            this.btn_viewBookings.UseVisualStyleBackColor = true;
            this.btn_viewBookings.Click += new System.EventHandler(this.btn_viewBookings_Click);
            // 
            // btn_backToMainMenu
            // 
            this.btn_backToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_backToMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_backToMainMenu.Location = new System.Drawing.Point(0, 187);
            this.btn_backToMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_backToMainMenu.Name = "btn_backToMainMenu";
            this.btn_backToMainMenu.Size = new System.Drawing.Size(240, 64);
            this.btn_backToMainMenu.TabIndex = 0;
            this.btn_backToMainMenu.Text = "Back to main menu";
            this.btn_backToMainMenu.UseVisualStyleBackColor = true;
            this.btn_backToMainMenu.Click += new System.EventHandler(this.btn_backToMainMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.btn_backToMainMenu);
            this.panel1.Controls.Add(this.btn_addBooking);
            this.panel1.Controls.Add(this.btn_viewBookings);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 541);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.xyzAirLinesLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.panel2.Size = new System.Drawing.Size(890, 60);
            this.panel2.TabIndex = 24;
            // 
            // xyzAirLinesLbl
            // 
            this.xyzAirLinesLbl.AutoSize = true;
            this.xyzAirLinesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.xyzAirLinesLbl.ForeColor = System.Drawing.Color.White;
            this.xyzAirLinesLbl.Location = new System.Drawing.Point(12, 16);
            this.xyzAirLinesLbl.Name = "xyzAirLinesLbl";
            this.xyzAirLinesLbl.Size = new System.Drawing.Size(191, 24);
            this.xyzAirLinesLbl.TabIndex = 4;
            this.xyzAirLinesLbl.Text = "XYZ AirLines Limited.";
            // 
            // BookingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookingMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BookingMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addBooking;
        private System.Windows.Forms.Button btn_viewBookings;
        private System.Windows.Forms.Button btn_backToMainMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label xyzAirLinesLbl;
    }
}

