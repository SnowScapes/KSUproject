namespace foradmin
{
    partial class Main
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
            this.New_btn = new MetroFramework.Controls.MetroButton();
            this.load_btn = new MetroFramework.Controls.MetroButton();
            this.result_btn = new MetroFramework.Controls.MetroButton();
            this.welcome = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // New_btn
            // 
            this.New_btn.Location = new System.Drawing.Point(359, 154);
            this.New_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.New_btn.Name = "New_btn";
            this.New_btn.Size = new System.Drawing.Size(171, 62);
            this.New_btn.TabIndex = 0;
            this.New_btn.Text = "설문조사 생성";
            this.New_btn.UseSelectable = true;
            this.New_btn.Click += new System.EventHandler(this.New_btn_Click);
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(359, 261);
            this.load_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(171, 62);
            this.load_btn.TabIndex = 1;
            this.load_btn.Text = "설문조사 삭제";
            this.load_btn.UseSelectable = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // result_btn
            // 
            this.result_btn.Location = new System.Drawing.Point(359, 369);
            this.result_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.result_btn.Name = "result_btn";
            this.result_btn.Size = new System.Drawing.Size(171, 62);
            this.result_btn.TabIndex = 2;
            this.result_btn.Text = "설문조사 결과";
            this.result_btn.UseSelectable = true;
            this.result_btn.Click += new System.EventHandler(this.result_btn_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.White;
            this.welcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.welcome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.welcome.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.welcome.Location = new System.Drawing.Point(359, 63);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(108, 25);
            this.welcome.TabIndex = 3;
            this.welcome.Text = "환영합니다!";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.result_btn);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.New_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(21, 75, 21, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton New_btn;
        private MetroFramework.Controls.MetroButton load_btn;
        private MetroFramework.Controls.MetroButton result_btn;
        private MetroFramework.Controls.MetroLabel welcome;
    }
}