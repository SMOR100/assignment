namespace Hospital
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
            this.btnReg_Pat = new System.Windows.Forms.Button();
            this.btnManage_Appoinment = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrescription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReg_Pat
            // 
            this.btnReg_Pat.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReg_Pat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReg_Pat.Location = new System.Drawing.Point(76, 181);
            this.btnReg_Pat.Name = "btnReg_Pat";
            this.btnReg_Pat.Size = new System.Drawing.Size(163, 66);
            this.btnReg_Pat.TabIndex = 0;
            this.btnReg_Pat.Text = "Register Patient";
            this.btnReg_Pat.UseVisualStyleBackColor = true;
            this.btnReg_Pat.Click += new System.EventHandler(this.btnReg_Pat_Click);
            // 
            // btnManage_Appoinment
            // 
            this.btnManage_Appoinment.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManage_Appoinment.Location = new System.Drawing.Point(473, 181);
            this.btnManage_Appoinment.Name = "btnManage_Appoinment";
            this.btnManage_Appoinment.Size = new System.Drawing.Size(183, 66);
            this.btnManage_Appoinment.TabIndex = 1;
            this.btnManage_Appoinment.Text = "Manage Appoinments";
            this.btnManage_Appoinment.UseVisualStyleBackColor = true;
            this.btnManage_Appoinment.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(76, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(473, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(110, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to Over Surgery";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(525, 449);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 42);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrescription
            // 
            this.btnPrescription.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrescription.Location = new System.Drawing.Point(299, 181);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new System.Drawing.Size(129, 60);
            this.btnPrescription.TabIndex = 7;
            this.btnPrescription.Text = "Prescriptions";
            this.btnPrescription.UseVisualStyleBackColor = true;
            this.btnPrescription.Click += new System.EventHandler(this.btnPrescription_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(745, 514);
            this.Controls.Add(this.btnPrescription);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnManage_Appoinment);
            this.Controls.Add(this.btnReg_Pat);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReg_Pat;
        private System.Windows.Forms.Button btnManage_Appoinment;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrescription;
    }
}