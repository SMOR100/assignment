﻿namespace Hospital
{
    partial class RegisterPatient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.txtbMail = new System.Windows.Forms.TextBox();
            this.txtbNumber = new System.Windows.Forms.TextBox();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.txtbFirName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(237, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(104, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(104, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(104, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(104, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(104, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mobile Number";
            // 
            // txtbID
            // 
            this.txtbID.Location = new System.Drawing.Point(287, 114);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(164, 26);
            this.txtbID.TabIndex = 7;
            // 
            // txtbMail
            // 
            this.txtbMail.Location = new System.Drawing.Point(287, 273);
            this.txtbMail.Name = "txtbMail";
            this.txtbMail.Size = new System.Drawing.Size(164, 26);
            this.txtbMail.TabIndex = 8;
            // 
            // txtbNumber
            // 
            this.txtbNumber.Location = new System.Drawing.Point(287, 329);
            this.txtbNumber.Name = "txtbNumber";
            this.txtbNumber.Size = new System.Drawing.Size(164, 26);
            this.txtbNumber.TabIndex = 10;
            // 
            // txtbLastName
            // 
            this.txtbLastName.Location = new System.Drawing.Point(287, 222);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.Size = new System.Drawing.Size(164, 26);
            this.txtbLastName.TabIndex = 11;
            // 
            // txtbFirName
            // 
            this.txtbFirName.Location = new System.Drawing.Point(287, 171);
            this.txtbFirName.Name = "txtbFirName";
            this.txtbFirName.Size = new System.Drawing.Size(164, 26);
            this.txtbFirName.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(155, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Register Patient Menu";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegisterPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 490);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbFirName);
            this.Controls.Add(this.txtbLastName);
            this.Controls.Add(this.txtbNumber);
            this.Controls.Add(this.txtbMail);
            this.Controls.Add(this.txtbID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "RegisterPatient";
            this.Text = "RegisterPatient";
            this.Load += new System.EventHandler(this.RegisterPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbID;
        private System.Windows.Forms.TextBox txtbMail;
        private System.Windows.Forms.TextBox txtbNumber;
        private System.Windows.Forms.TextBox txtbLastName;
        private System.Windows.Forms.TextBox txtbFirName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}