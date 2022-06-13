namespace foradmin
{
    partial class Result
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
            this.selectlist = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.resultlist = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // selectlist
            // 
            this.selectlist.FormattingEnabled = true;
            this.selectlist.ItemHeight = 24;
            this.selectlist.Location = new System.Drawing.Point(23, 76);
            this.selectlist.Name = "selectlist";
            this.selectlist.Size = new System.Drawing.Size(177, 30);
            this.selectlist.TabIndex = 0;
            this.selectlist.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(206, 76);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(64, 30);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "결과 확인";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // resultlist
            // 
            this.resultlist.HideSelection = false;
            this.resultlist.Location = new System.Drawing.Point(23, 112);
            this.resultlist.Name = "resultlist";
            this.resultlist.Size = new System.Drawing.Size(965, 457);
            this.resultlist.TabIndex = 2;
            this.resultlist.UseCompatibleStateImageBehavior = false;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 580);
            this.Controls.Add(this.resultlist);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.selectlist);
            this.Name = "Result";
            this.Text = "Result";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox selectlist;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ListView resultlist;
    }
}