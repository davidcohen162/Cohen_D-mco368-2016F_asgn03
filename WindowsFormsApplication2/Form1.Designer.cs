namespace WindowsFormsApplication2
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
            this.numbersBox = new System.Windows.Forms.TextBox();
            this.index1 = new System.Windows.Forms.TextBox();
            this.index2 = new System.Windows.Forms.TextBox();
            this.numbersBar = new System.Windows.Forms.TextBox();
            this.cutoff = new System.Windows.Forms.TextBox();
            this.filter = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newNumbers = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numbersBox
            // 
            this.numbersBox.Location = new System.Drawing.Point(57, 12);
            this.numbersBox.Multiline = true;
            this.numbersBox.Name = "numbersBox";
            this.numbersBox.Size = new System.Drawing.Size(134, 111);
            this.numbersBox.TabIndex = 0;
            this.numbersBox.TextChanged += new System.EventHandler(this.numbersBox_TextChanged);
            // 
            // index1
            // 
            this.index1.Location = new System.Drawing.Point(133, 141);
            this.index1.Name = "index1";
            this.index1.Size = new System.Drawing.Size(19, 20);
            this.index1.TabIndex = 1;
            // 
            // index2
            // 
            this.index2.Location = new System.Drawing.Point(82, 140);
            this.index2.Name = "index2";
            this.index2.Size = new System.Drawing.Size(26, 20);
            this.index2.TabIndex = 2;
            // 
            // numbersBar
            // 
            this.numbersBar.Location = new System.Drawing.Point(60, 199);
            this.numbersBar.Name = "numbersBar";
            this.numbersBar.Size = new System.Drawing.Size(186, 20);
            this.numbersBar.TabIndex = 3;
            // 
            // cutoff
            // 
            this.cutoff.Location = new System.Drawing.Point(94, 227);
            this.cutoff.Name = "cutoff";
            this.cutoff.Size = new System.Drawing.Size(51, 20);
            this.cutoff.TabIndex = 4;
            this.cutoff.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(151, 225);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(75, 23);
            this.filter.TabIndex = 5;
            this.filter.Text = "Filter";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(168, 138);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(75, 23);
            this.display.TabIndex = 6;
            this.display.Text = "Display";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = ",";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numbers:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numbers:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cutoff:";
            // 
            // newNumbers
            // 
            this.newNumbers.Location = new System.Drawing.Point(104, 254);
            this.newNumbers.Name = "newNumbers";
            this.newNumbers.Size = new System.Drawing.Size(122, 24);
            this.newNumbers.TabIndex = 11;
            this.newNumbers.Text = "New Numbers";
            this.newNumbers.UseVisualStyleBackColor = true;
            this.newNumbers.Click += new System.EventHandler(this.newNumbers_Click);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(57, 164);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(169, 32);
            this.messageBox.TabIndex = 12;
            this.messageBox.Click += new System.EventHandler(this.messageBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 316);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.newNumbers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.display);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.cutoff);
            this.Controls.Add(this.numbersBar);
            this.Controls.Add(this.index2);
            this.Controls.Add(this.index1);
            this.Controls.Add(this.numbersBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numbersBox;
        private System.Windows.Forms.TextBox index1;
        private System.Windows.Forms.TextBox index2;
        private System.Windows.Forms.TextBox numbersBar;
        private System.Windows.Forms.TextBox cutoff;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newNumbers;
        private System.Windows.Forms.Label messageBox;
    }
}

