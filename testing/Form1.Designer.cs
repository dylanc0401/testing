namespace testing
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Methods = new System.Windows.Forms.TabPage();
            this.Results = new System.Windows.Forms.TabPage();
            this.Discussion = new System.Windows.Forms.TabPage();
            this.Conclusion = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabControl1.SuspendLayout();
            this.Methods.SuspendLayout();
            this.Results.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Methods);
            this.tabControl1.Controls.Add(this.Results);
            this.tabControl1.Controls.Add(this.Discussion);
            this.tabControl1.Controls.Add(this.Conclusion);
            this.tabControl1.Location = new System.Drawing.Point(237, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(465, 282);
            this.tabControl1.TabIndex = 1;
            // 
            // Methods
            // 
            this.Methods.Controls.Add(this.checkedListBox1);
            this.Methods.Location = new System.Drawing.Point(4, 22);
            this.Methods.Name = "Methods";
            this.Methods.Padding = new System.Windows.Forms.Padding(3);
            this.Methods.Size = new System.Drawing.Size(457, 256);
            this.Methods.TabIndex = 0;
            this.Methods.Text = "Methods";
            this.Methods.UseVisualStyleBackColor = true;
            // 
            // Results
            // 
            this.Results.Controls.Add(this.button1);
            this.Results.Location = new System.Drawing.Point(4, 22);
            this.Results.Name = "Results";
            this.Results.Padding = new System.Windows.Forms.Padding(3);
            this.Results.Size = new System.Drawing.Size(457, 256);
            this.Results.TabIndex = 1;
            this.Results.Text = "Results";
            this.Results.UseVisualStyleBackColor = true;
            // 
            // Discussion
            // 
            this.Discussion.Location = new System.Drawing.Point(4, 22);
            this.Discussion.Name = "Discussion";
            this.Discussion.Size = new System.Drawing.Size(457, 256);
            this.Discussion.TabIndex = 2;
            this.Discussion.Text = "DIscussion";
            this.Discussion.UseVisualStyleBackColor = true;
            // 
            // Conclusion
            // 
            this.Conclusion.Location = new System.Drawing.Point(4, 22);
            this.Conclusion.Name = "Conclusion";
            this.Conclusion.Size = new System.Drawing.Size(457, 256);
            this.Conclusion.TabIndex = 3;
            this.Conclusion.Text = "Conclusion";
            this.Conclusion.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1.Cut the agar jelly into 10mm,20mm,30,, and 40mm cubes.",
            "2. Add the jelly into a beaker and fill it up with hydrochloric acid",
            "3. Mix and observe for 8 minutes",
            "4"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 6);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(333, 139);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 400);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Methods.ResumeLayout(false);
            this.Results.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Methods;
        private System.Windows.Forms.TabPage Results;
        private System.Windows.Forms.TabPage Discussion;
        private System.Windows.Forms.TabPage Conclusion;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

