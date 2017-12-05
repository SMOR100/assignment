namespace Hospital
{
    partial class ManageAppoinments
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtbAppID = new System.Windows.Forms.TextBox();
            this.txtbPatID = new System.Windows.Forms.TextBox();
            this.txtbStaffID = new System.Windows.Forms.TextBox();
            this.dtpAppDate = new System.Windows.Forms.DateTimePicker();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAppID = new System.Windows.Forms.TextBox();
            this.txtStID = new System.Windows.Forms.TextBox();
            this.dtpNewDate = new System.Windows.Forms.DateTimePicker();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDelAppID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(61, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Appoinment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Appoinment ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Staff ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(12, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Appoinment Date";
            // 
            // txtbAppID
            // 
            this.txtbAppID.Location = new System.Drawing.Point(175, 141);
            this.txtbAppID.Name = "txtbAppID";
            this.txtbAppID.ReadOnly = true;
            this.txtbAppID.Size = new System.Drawing.Size(156, 26);
            this.txtbAppID.TabIndex = 7;
            // 
            // txtbPatID
            // 
            this.txtbPatID.Location = new System.Drawing.Point(175, 187);
            this.txtbPatID.Name = "txtbPatID";
            this.txtbPatID.Size = new System.Drawing.Size(156, 26);
            this.txtbPatID.TabIndex = 8;
            // 
            // txtbStaffID
            // 
            this.txtbStaffID.Location = new System.Drawing.Point(175, 232);
            this.txtbStaffID.Name = "txtbStaffID";
            this.txtbStaffID.Size = new System.Drawing.Size(156, 26);
            this.txtbStaffID.TabIndex = 9;
            // 
            // dtpAppDate
            // 
            this.dtpAppDate.CustomFormat = "yyyy-mm-dd";
            this.dtpAppDate.Location = new System.Drawing.Point(190, 287);
            this.dtpAppDate.Name = "dtpAppDate";
            this.dtpAppDate.Size = new System.Drawing.Size(168, 26);
            this.dtpAppDate.TabIndex = 12;
            this.dtpAppDate.Value = new System.DateTime(2017, 11, 15, 1, 23, 24, 0);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(109, 365);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(145, 46);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(992, 551);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 49);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Go Back";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(456, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 36);
            this.label5.TabIndex = 15;
            this.label5.Text = "Edit Appoinment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(387, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Appoinment ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(387, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Change Staff ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(392, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Change Appoinment Date to";
            // 
            // txtAppID
            // 
            this.txtAppID.Location = new System.Drawing.Point(557, 140);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.Size = new System.Drawing.Size(134, 26);
            this.txtAppID.TabIndex = 19;
            // 
            // txtStID
            // 
            this.txtStID.Location = new System.Drawing.Point(557, 186);
            this.txtStID.Name = "txtStID";
            this.txtStID.Size = new System.Drawing.Size(134, 26);
            this.txtStID.TabIndex = 20;
            // 
            // dtpNewDate
            // 
            this.dtpNewDate.CustomFormat = "yyyy-mm-dd";
            this.dtpNewDate.Location = new System.Drawing.Point(499, 288);
            this.dtpNewDate.Name = "dtpNewDate";
            this.dtpNewDate.Size = new System.Drawing.Size(192, 26);
            this.dtpNewDate.TabIndex = 21;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(499, 365);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 46);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(844, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(267, 36);
            this.label10.TabIndex = 23;
            this.label10.Text = "Delete Appoinment";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(890, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Appoinment ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(895, 365);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 46);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtDelAppID
            // 
            this.txtDelAppID.Location = new System.Drawing.Point(878, 185);
            this.txtDelAppID.Name = "txtDelAppID";
            this.txtDelAppID.Size = new System.Drawing.Size(168, 26);
            this.txtDelAppID.TabIndex = 26;
            // 
            // ManageAppoinments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 612);
            this.Controls.Add(this.txtDelAppID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dtpNewDate);
            this.Controls.Add(this.txtStID);
            this.Controls.Add(this.txtAppID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dtpAppDate);
            this.Controls.Add(this.txtbStaffID);
            this.Controls.Add(this.txtbPatID);
            this.Controls.Add(this.txtbAppID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageAppoinments";
            this.Text = "ManageAppoinments";
            this.Load += new System.EventHandler(this.ManageAppoinments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbAppID;
        private System.Windows.Forms.TextBox txtbPatID;
        private System.Windows.Forms.TextBox txtbStaffID;
        private System.Windows.Forms.DateTimePicker dtpAppDate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAppID;
        private System.Windows.Forms.TextBox txtStID;
        private System.Windows.Forms.DateTimePicker dtpNewDate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDelAppID;
    }
}