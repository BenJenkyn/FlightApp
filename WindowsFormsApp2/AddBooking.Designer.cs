namespace WindowsFormsApp2
{
    partial class AddBooking
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
            this.lbl_selectCustomer = new System.Windows.Forms.Label();
            this.cmb_selectCustomer = new System.Windows.Forms.ComboBox();
            this.lbl_selectFlight = new System.Windows.Forms.Label();
            this.cmb_selectFlight = new System.Windows.Forms.ComboBox();
            this.btn_saveBooking = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xyzAirLinesLbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_selectCustomer
            // 
            this.lbl_selectCustomer.AutoSize = true;
            this.lbl_selectCustomer.Location = new System.Drawing.Point(109, 139);
            this.lbl_selectCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_selectCustomer.Name = "lbl_selectCustomer";
            this.lbl_selectCustomer.Size = new System.Drawing.Size(86, 13);
            this.lbl_selectCustomer.TabIndex = 1;
            this.lbl_selectCustomer.Text = "Select customer:";
            // 
            // cmb_selectCustomer
            // 
            this.cmb_selectCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_selectCustomer.FormattingEnabled = true;
            this.cmb_selectCustomer.Location = new System.Drawing.Point(263, 137);
            this.cmb_selectCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_selectCustomer.Name = "cmb_selectCustomer";
            this.cmb_selectCustomer.Size = new System.Drawing.Size(152, 21);
            this.cmb_selectCustomer.TabIndex = 2;
            // 
            // lbl_selectFlight
            // 
            this.lbl_selectFlight.AutoSize = true;
            this.lbl_selectFlight.Location = new System.Drawing.Point(109, 190);
            this.lbl_selectFlight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_selectFlight.Name = "lbl_selectFlight";
            this.lbl_selectFlight.Size = new System.Drawing.Size(65, 13);
            this.lbl_selectFlight.TabIndex = 1;
            this.lbl_selectFlight.Text = "Select flight:";
            // 
            // cmb_selectFlight
            // 
            this.cmb_selectFlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_selectFlight.FormattingEnabled = true;
            this.cmb_selectFlight.Location = new System.Drawing.Point(263, 188);
            this.cmb_selectFlight.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_selectFlight.Name = "cmb_selectFlight";
            this.cmb_selectFlight.Size = new System.Drawing.Size(152, 21);
            this.cmb_selectFlight.TabIndex = 2;
            // 
            // btn_saveBooking
            // 
            this.btn_saveBooking.Location = new System.Drawing.Point(319, 244);
            this.btn_saveBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saveBooking.Name = "btn_saveBooking";
            this.btn_saveBooking.Size = new System.Drawing.Size(95, 22);
            this.btn_saveBooking.TabIndex = 3;
            this.btn_saveBooking.Text = "Save booking";
            this.btn_saveBooking.UseVisualStyleBackColor = true;
            this.btn_saveBooking.Click += new System.EventHandler(this.btn_saveBooking_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(111, 244);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(95, 22);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(111, 288);
            this.lbl_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 4;
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
            this.panel2.Size = new System.Drawing.Size(533, 60);
            this.panel2.TabIndex = 25;
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
            // AddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 371);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_saveBooking);
            this.Controls.Add(this.cmb_selectFlight);
            this.Controls.Add(this.lbl_selectFlight);
            this.Controls.Add(this.cmb_selectCustomer);
            this.Controls.Add(this.lbl_selectCustomer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddBooking";
            this.Text = "AddBooking";
            this.Load += new System.EventHandler(this.AddBooking_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_selectCustomer;
        private System.Windows.Forms.ComboBox cmb_selectCustomer;
        private System.Windows.Forms.Label lbl_selectFlight;
        private System.Windows.Forms.ComboBox cmb_selectFlight;
        private System.Windows.Forms.Button btn_saveBooking;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label xyzAirLinesLbl;
    }
}