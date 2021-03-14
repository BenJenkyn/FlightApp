namespace WindowsFormsApp2
{
    partial class CustomerMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_backToMenu = new System.Windows.Forms.Button();
            this.btn_deleteCustomer = new System.Windows.Forms.Button();
            this.btn_addCustomer = new System.Windows.Forms.Button();
            this.btn_viewCustomer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xyzAirLinesLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.btn_backToMenu);
            this.panel1.Controls.Add(this.btn_deleteCustomer);
            this.panel1.Controls.Add(this.btn_addCustomer);
            this.panel1.Controls.Add(this.btn_viewCustomer);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 450);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_backToMenu
            // 
            this.btn_backToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_backToMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_backToMenu.Location = new System.Drawing.Point(0, 251);
            this.btn_backToMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_backToMenu.Name = "btn_backToMenu";
            this.btn_backToMenu.Size = new System.Drawing.Size(240, 64);
            this.btn_backToMenu.TabIndex = 1;
            this.btn_backToMenu.Text = "Back to Menu";
            this.btn_backToMenu.UseVisualStyleBackColor = true;
            this.btn_backToMenu.Click += new System.EventHandler(this.Btn_backToMenu_Click);
            // 
            // btn_deleteCustomer
            // 
            this.btn_deleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_deleteCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_deleteCustomer.Location = new System.Drawing.Point(0, 187);
            this.btn_deleteCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deleteCustomer.Name = "btn_deleteCustomer";
            this.btn_deleteCustomer.Size = new System.Drawing.Size(240, 64);
            this.btn_deleteCustomer.TabIndex = 0;
            this.btn_deleteCustomer.Text = "Delete Customer";
            this.btn_deleteCustomer.UseVisualStyleBackColor = true;
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_addCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_addCustomer.Location = new System.Drawing.Point(0, 59);
            this.btn_addCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(240, 64);
            this.btn_addCustomer.TabIndex = 0;
            this.btn_addCustomer.Text = "Add Customer";
            this.btn_addCustomer.UseVisualStyleBackColor = true;
            this.btn_addCustomer.Click += new System.EventHandler(this.Btn_addCustomer_Click);
            // 
            // btn_viewCustomer
            // 
            this.btn_viewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_viewCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_viewCustomer.Location = new System.Drawing.Point(0, 123);
            this.btn_viewCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_viewCustomer.Name = "btn_viewCustomer";
            this.btn_viewCustomer.Size = new System.Drawing.Size(240, 64);
            this.btn_viewCustomer.TabIndex = 0;
            this.btn_viewCustomer.Text = "View Customers";
            this.btn_viewCustomer.UseVisualStyleBackColor = true;
            this.btn_viewCustomer.Click += new System.EventHandler(this.btn_viewCustomer_Click);
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
            this.panel2.Size = new System.Drawing.Size(800, 60);
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
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerMenu";
            this.Text = "CustomerMenu";
            this.Load += new System.EventHandler(this.CustomerMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_deleteCustomer;
        private System.Windows.Forms.Button btn_addCustomer;
        private System.Windows.Forms.Button btn_viewCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label xyzAirLinesLbl;
        private System.Windows.Forms.Button btn_backToMenu;
    }
}