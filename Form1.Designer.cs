namespace Moon_Asg1_classes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textStudentID = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textNumberOfCredits = new System.Windows.Forms.TextBox();
            this.checkBoxIsFullTime = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "# of Credits:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Is Full Time:";
            // 
            // textBox1
            // 
            this.textID.Location = new System.Drawing.Point(222, 68);
            this.textID.Name = "textBox1";
            this.textID.Size = new System.Drawing.Size(198, 20);
            this.textID.TabIndex = 6;
            this.textID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textStudentID.Location = new System.Drawing.Point(222, 94);
            this.textStudentID.Name = "textBox2";
            this.textStudentID.Size = new System.Drawing.Size(198, 20);
            this.textStudentID.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textFirstName.Location = new System.Drawing.Point(222, 119);
            this.textFirstName.Name = "textBox3";
            this.textFirstName.Size = new System.Drawing.Size(198, 20);
            this.textFirstName.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textLastName.Location = new System.Drawing.Point(222, 144);
            this.textLastName.Name = "textBox4";
            this.textLastName.Size = new System.Drawing.Size(198, 20);
            this.textLastName.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textEmail.Location = new System.Drawing.Point(222, 168);
            this.textEmail.Name = "textBox5";
            this.textEmail.Size = new System.Drawing.Size(198, 20);
            this.textEmail.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textNumberOfCredits.Location = new System.Drawing.Point(222, 192);
            this.textNumberOfCredits.Name = "textBox6";
            this.textNumberOfCredits.Size = new System.Drawing.Size(198, 20);
            this.textNumberOfCredits.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBoxIsFullTime.AutoSize = true;
            this.checkBoxIsFullTime.Location = new System.Drawing.Point(222, 224);
            this.checkBoxIsFullTime.Name = "checkBox1";
            this.checkBoxIsFullTime.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsFullTime.TabIndex = 12;
            this.checkBoxIsFullTime.UseVisualStyleBackColor = true;
            this.checkBoxIsFullTime.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 60);
            this.button1.TabIndex = 14;
            this.button1.Text = "<= Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 60);
            this.button2.TabIndex = 15;
            this.button2.Text = "Next =>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxIsFullTime);
            this.Controls.Add(this.textNumberOfCredits);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.textStudentID);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textStudentID;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textNumberOfCredits;
        private System.Windows.Forms.CheckBox checkBoxIsFullTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

