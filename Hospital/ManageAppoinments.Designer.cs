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
            this.label7.Location = new System.Drawing.Point(13, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Appoinment Date";
            // 
            // txtbAppID
            // 
            this.txtbAppID.Location = new System.Drawing.Point(175, 141);
            this.txtbAppID.Name = "txtbAppID";
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
            this.dtpAppDate.CustomFormat = "dd-MM-yyyy";
            this.dtpAppDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppDate.Location = new System.Drawing.Point(190, 287);
            this.dtpAppDate.Name = "dtpAppDate";
            this.dtpAppDate.Size = new System.Drawing.Size(141, 26);
            this.dtpAppDate.TabIndex = 12;
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
            // ManageAppoinments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 612);
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
    }
}