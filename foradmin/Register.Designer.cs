namespace foradmin
{
    partial class Register
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
            this.regID_label = new MetroFramework.Controls.MetroLabel();
            this.regPW_label = new MetroFramework.Controls.MetroLabel();
            this.RegID = new MetroFramework.Controls.MetroTextBox();
            this.RegPW = new MetroFramework.Controls.MetroTextBox();
            this.Reg_Btn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // regID_label
            // 
            this.regID_label.AutoSize = true;
            this.regID_label.Location = new System.Drawing.Point(80, 84);
            this.regID_label.Name = "regID_label";
            this.regID_label.Size = new System.Drawing.Size(21, 19);
            this.regID_label.TabIndex = 2;
            this.regID_label.Text = "ID";
            // 
            // regPW_label
            // 
            this.regPW_label.AutoSize = true;
            this.regPW_label.Location = new System.Drawing.Point(80, 120);
            this.regPW_label.Name = "regPW_label";
            this.regPW_label.Size = new System.Drawing.Size(30, 19);
            this.regPW_label.TabIndex = 3;
            this.regPW_label.Text = "PW";
            // 
            // RegID
            // 
            // 
            // 
            // 
            this.RegID.CustomButton.Image = null;
            this.RegID.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.RegID.CustomButton.Name = "";
            this.RegID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RegID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RegID.CustomButton.TabIndex = 1;
            this.RegID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RegID.CustomButton.UseSelectable = true;
            this.RegID.CustomButton.Visible = false;
            this.RegID.Lines = new string[0];
            this.RegID.Location = new System.Drawing.Point(148, 84);
            this.RegID.MaxLength = 32767;
            this.RegID.Name = "RegID";
            this.RegID.PasswordChar = '\0';
            this.RegID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RegID.SelectedText = "";
            this.RegID.SelectionLength = 0;
            this.RegID.SelectionStart = 0;
            this.RegID.ShortcutsEnabled = true;
            this.RegID.Size = new System.Drawing.Size(96, 23);
            this.RegID.TabIndex = 5;
            this.RegID.UseSelectable = true;
            this.RegID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RegID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // RegPW
            // 
            // 
            // 
            // 
            this.RegPW.CustomButton.Image = null;
            this.RegPW.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.RegPW.CustomButton.Name = "";
            this.RegPW.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RegPW.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RegPW.CustomButton.TabIndex = 1;
            this.RegPW.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RegPW.CustomButton.UseSelectable = true;
            this.RegPW.CustomButton.Visible = false;
            this.RegPW.Lines = new string[0];
            this.RegPW.Location = new System.Drawing.Point(148, 115);
            this.RegPW.MaxLength = 32767;
            this.RegPW.Name = "RegPW";
            this.RegPW.PasswordChar = '\0';
            this.RegPW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RegPW.SelectedText = "";
            this.RegPW.SelectionLength = 0;
            this.RegPW.SelectionStart = 0;
            this.RegPW.ShortcutsEnabled = true;
            this.RegPW.Size = new System.Drawing.Size(96, 23);
            this.RegPW.TabIndex = 6;
            this.RegPW.UseSelectable = true;
            this.RegPW.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RegPW.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Reg_Btn
            // 
            this.Reg_Btn.Location = new System.Drawing.Point(148, 158);
            this.Reg_Btn.Name = "Reg_Btn";
            this.Reg_Btn.Size = new System.Drawing.Size(75, 23);
            this.Reg_Btn.TabIndex = 7;
            this.Reg_Btn.Text = "Register";
            this.Reg_Btn.UseSelectable = true;
            this.Reg_Btn.Click += new System.EventHandler(this.Reg_Btn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 230);
            this.Controls.Add(this.Reg_Btn);
            this.Controls.Add(this.RegPW);
            this.Controls.Add(this.RegID);
            this.Controls.Add(this.regPW_label);
            this.Controls.Add(this.regID_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Register";
            this.Padding = new System.Windows.Forms.Padding(18, 48, 18, 16);
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel regID_label;
        private MetroFramework.Controls.MetroLabel regPW_label;
        private MetroFramework.Controls.MetroTextBox RegID;
        private MetroFramework.Controls.MetroTextBox RegPW;
        private MetroFramework.Controls.MetroButton Reg_Btn;
    }
}