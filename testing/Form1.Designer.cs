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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Results = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Discussion = new System.Windows.Forms.TabPage();
            this.Conclusion = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Methods = new System.Windows.Forms.TabPage();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Results.SuspendLayout();
            this.Methods.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 71);
            this.panel1.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(112, 9);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 50);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNextClick);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(13, 9);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 50);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.bntPrevClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Methods);
            this.tabControl1.Controls.Add(this.Results);
            this.tabControl1.Controls.Add(this.Discussion);
            this.tabControl1.Controls.Add(this.Conclusion);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 71);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1054, 544);
            this.tabControl1.TabIndex = 3;
            // 
            // Results
            // 
            this.Results.Controls.Add(this.button1);
            this.Results.Location = new System.Drawing.Point(4, 29);
            this.Results.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Results.Name = "Results";
            this.Results.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Results.Size = new System.Drawing.Size(1046, 511);
            this.Results.TabIndex = 1;
            this.Results.Text = "Results";
            this.Results.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Discussion
            // 
            this.Discussion.Location = new System.Drawing.Point(4, 29);
            this.Discussion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Discussion.Name = "Discussion";
            this.Discussion.Size = new System.Drawing.Size(1046, 511);
            this.Discussion.TabIndex = 2;
            this.Discussion.Text = "DIscussion";
            this.Discussion.UseVisualStyleBackColor = true;
            // 
            // Conclusion
            // 
            this.Conclusion.Location = new System.Drawing.Point(4, 29);
            this.Conclusion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Conclusion.Name = "Conclusion";
            this.Conclusion.Size = new System.Drawing.Size(1046, 511);
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
            this.checkedListBox1.Location = new System.Drawing.Point(453, 268);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(498, 193);
            this.checkedListBox1.TabIndex = 0;
            // 
            // Methods
            // 
            this.Methods.Controls.Add(this.button3);
            this.Methods.Controls.Add(this.lblResult);
            this.Methods.Controls.Add(this.button2);
            this.Methods.Controls.Add(this.num2);
            this.Methods.Controls.Add(this.num1);
            this.Methods.Controls.Add(this.checkedListBox1);
            this.Methods.Location = new System.Drawing.Point(4, 29);
            this.Methods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Methods.Name = "Methods";
            this.Methods.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Methods.Size = new System.Drawing.Size(1046, 511);
            this.Methods.TabIndex = 0;
            this.Methods.Text = "Calculator";
            this.Methods.UseVisualStyleBackColor = true;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(41, 29);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 26);
            this.num1.TabIndex = 1;
            this.num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num1_KeyPress);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(176, 29);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 26);
            this.num2.TabIndex = 2;
            this.num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num1_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(172, 72);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(51, 20);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "Divide";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 615);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Results.ResumeLayout(false);
            this.Methods.ResumeLayout(false);
            this.Methods.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Results;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Discussion;
        private System.Windows.Forms.TabPage Conclusion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.TabPage Methods;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button3;
    }
}

