namespace foradmin
{
    partial class Login
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
            this.getID = new MetroFramework.Controls.MetroTextBox();
            this.getPW = new MetroFramework.Controls.MetroTextBox();
            this.Login_Label = new MetroFramework.Controls.MetroLabel();
            this.Login_Btn = new MetroFramework.Controls.MetroButton();
            this.ID_Label = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Register_Btn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // getID
            // 
            // 
            // 
            // 
            this.getID.CustomButton.Image = null;
            this.getID.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.getID.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getID.CustomButton.Name = "";
            this.getID.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.getID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.getID.CustomButton.TabIndex = 1;
            this.getID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.getID.CustomButton.UseSelectable = true;
            this.getID.CustomButton.Visible = false;
            this.getID.Lines = new string[0];
            this.getID.Location = new System.Drawing.Point(375, 262);
            this.getID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getID.MaxLength = 32767;
            this.getID.Name = "getID";
            this.getID.PasswordChar = '\0';
            this.getID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.getID.SelectedText = "";
            this.getID.SelectionLength = 0;
            this.getID.SelectionStart = 0;
            this.getID.ShortcutsEnabled = true;
            this.getID.Size = new System.Drawing.Size(171, 29);
            this.getID.TabIndex = 0;
            this.getID.UseSelectable = true;
            this.getID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.getID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // getPW
            // 
            // 
            // 
            // 
            this.getPW.CustomButton.Image = null;
            this.getPW.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.getPW.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getPW.CustomButton.Name = "";
            this.getPW.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.getPW.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.getPW.CustomButton.TabIndex = 1;
            this.getPW.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.getPW.CustomButton.UseSelectable = true;
            this.getPW.CustomButton.Visible = false;
            this.getPW.Lines = new string[0];
            this.getPW.Location = new System.Drawing.Point(375, 315);
            this.getPW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getPW.MaxLength = 32767;
            this.getPW.Name = "getPW";
            this.getPW.PasswordChar = '\0';
            this.getPW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.getPW.SelectedText = "";
            this.getPW.SelectionLength = 0;
            this.getPW.SelectionStart = 0;
            this.getPW.ShortcutsEnabled = true;
            this.getPW.Size = new System.Drawing.Size(171, 29);
            this.getPW.TabIndex = 1;
            this.getPW.UseSelectable = true;
            this.getPW.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.getPW.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Login_Label
            // 
            this.Login_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_Label.AutoSize = true;
            this.Login_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Login_Label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Login_Label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Login_Label.Location = new System.Drawing.Point(387, 190);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(125, 25);
            this.Login_Label.TabIndex = 2;
            this.Login_Label.Text = "관리자 로그인";
            this.Login_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_Btn
            // 
            this.Login_Btn.BackColor = System.Drawing.Color.White;
            this.Login_Btn.Location = new System.Drawing.Point(460, 371);
            this.Login_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(86, 29);
            this.Login_Btn.TabIndex = 3;
            this.Login_Btn.Text = "LogIn";
            this.Login_Btn.UseSelectable = true;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ID_Label.Location = new System.Drawing.Point(334, 262);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(24, 20);
            this.ID_Label.TabIndex = 4;
            this.ID_Label.Text = "ID";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(326, 315);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(31, 20);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "PW";
            // 
            // Register_Btn
            // 
            this.Register_Btn.Location = new System.Drawing.Point(375, 371);
            this.Register_Btn.Name = "Register_Btn";
            this.Register_Btn.Size = new System.Drawing.Size(79, 29);
            this.Register_Btn.TabIndex = 7;
            this.Register_Btn.Text = "Register";
            this.Register_Btn.UseSelectable = true;
            this.Register_Btn.Click += new System.EventHandler(this.Register_Btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.Register_Btn);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ID_Label);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.Login_Label);
            this.Controls.Add(this.getPW);
            this.Controls.Add(this.getID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
            this.Resizable = false;
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox getID;
        private MetroFramework.Controls.MetroTextBox getPW;
        private MetroFramework.Controls.MetroLabel Login_Label;
        private MetroFramework.Controls.MetroButton Login_Btn;
        private MetroFramework.Controls.MetroLabel ID_Label;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton Register_Btn;
    }
}