namespace EmployeeApplication
{
    partial class frmComputeSalary
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
            this.firstname = new System.Windows.Forms.TextBox();
            this.rateperhour = new System.Windows.Forms.TextBox();
            this.jobtitle = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.hoursworked = new System.Windows.Forms.TextBox();
            this.compute = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.resultname = new System.Windows.Forms.Label();
            this.resultlast = new System.Windows.Forms.Label();
            this.resultsalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Hourds Worked";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rate per Hour";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Job Title";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(337, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // firstname
            // 
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(53, 85);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(266, 29);
            this.firstname.TabIndex = 6;
            // 
            // rateperhour
            // 
            this.rateperhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateperhour.Location = new System.Drawing.Point(53, 252);
            this.rateperhour.Name = "rateperhour";
            this.rateperhour.Size = new System.Drawing.Size(266, 29);
            this.rateperhour.TabIndex = 7;
            // 
            // jobtitle
            // 
            this.jobtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobtitle.Location = new System.Drawing.Point(343, 154);
            this.jobtitle.Name = "jobtitle";
            this.jobtitle.Size = new System.Drawing.Size(264, 29);
            this.jobtitle.TabIndex = 8;
            // 
            // department
            // 
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.Location = new System.Drawing.Point(53, 154);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(266, 29);
            this.department.TabIndex = 9;
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(343, 85);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(264, 29);
            this.lastname.TabIndex = 10;
            // 
            // hoursworked
            // 
            this.hoursworked.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursworked.Location = new System.Drawing.Point(343, 252);
            this.hoursworked.Name = "hoursworked";
            this.hoursworked.Size = new System.Drawing.Size(264, 29);
            this.hoursworked.TabIndex = 11;
            // 
            // compute
            // 
            this.compute.Location = new System.Drawing.Point(264, 287);
            this.compute.Name = "compute";
            this.compute.Size = new System.Drawing.Size(135, 43);
            this.compute.TabIndex = 12;
            this.compute.Text = "Compute Salary";
            this.compute.UseVisualStyleBackColor = true;
            this.compute.Click += new System.EventHandler(this.compute_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "First name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Last Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Basic Salary:";
            // 
            // resultname
            // 
            this.resultname.AutoSize = true;
            this.resultname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultname.Location = new System.Drawing.Point(190, 376);
            this.resultname.Name = "resultname";
            this.resultname.Size = new System.Drawing.Size(173, 24);
            this.resultname.TabIndex = 16;
            this.resultname.Text = "<first name here>";
            // 
            // resultlast
            // 
            this.resultlast.AutoSize = true;
            this.resultlast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultlast.Location = new System.Drawing.Point(190, 411);
            this.resultlast.Name = "resultlast";
            this.resultlast.Size = new System.Drawing.Size(172, 24);
            this.resultlast.TabIndex = 17;
            this.resultlast.Text = "<last name here>";
            // 
            // resultsalary
            // 
            this.resultsalary.AutoSize = true;
            this.resultsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsalary.Location = new System.Drawing.Point(190, 443);
            this.resultsalary.Name = "resultsalary";
            this.resultsalary.Size = new System.Drawing.Size(60, 24);
            this.resultsalary.TabIndex = 18;
            this.resultsalary.Text = "00.00";
            // 
            // frmComputeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(660, 515);
            this.Controls.Add(this.resultsalary);
            this.Controls.Add(this.resultlast);
            this.Controls.Add(this.resultname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.compute);
            this.Controls.Add(this.hoursworked);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.department);
            this.Controls.Add(this.jobtitle);
            this.Controls.Add(this.rateperhour);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmComputeSalary";
            this.Text = "Employee Salary Calculator";
            this.Load += new System.EventHandler(this.frmComputeSalary_Load);
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
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox rateperhour;
        private System.Windows.Forms.TextBox jobtitle;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox hoursworked;
        private System.Windows.Forms.Button compute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label resultname;
        private System.Windows.Forms.Label resultlast;
        private System.Windows.Forms.Label resultsalary;
    }
}