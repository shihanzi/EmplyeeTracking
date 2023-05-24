namespace EmplyeeTracking
{
    partial class FrmDashboard
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
            btnEmployee = new Button();
            btnTasks = new Button();
            btnSalary = new Button();
            btnPermission = new Button();
            btnDepartment = new Button();
            btnPosition = new Button();
            btnLogout = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(252, 184, 127);
            btnEmployee.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployee.ForeColor = SystemColors.InactiveCaptionText;
            btnEmployee.Location = new Point(31, 25);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(138, 127);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = false;
            // 
            // btnTasks
            // 
            btnTasks.BackColor = Color.FromArgb(251, 209, 162);
            btnTasks.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTasks.ForeColor = SystemColors.InactiveCaptionText;
            btnTasks.Location = new Point(175, 25);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(137, 127);
            btnTasks.TabIndex = 1;
            btnTasks.Text = "Tasks";
            btnTasks.UseVisualStyleBackColor = false;
            // 
            // btnSalary
            // 
            btnSalary.BackColor = Color.FromArgb(244, 219, 173);
            btnSalary.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalary.ForeColor = SystemColors.InactiveCaptionText;
            btnSalary.Location = new Point(318, 25);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(136, 127);
            btnSalary.TabIndex = 2;
            btnSalary.Text = "Salary";
            btnSalary.UseVisualStyleBackColor = false;
            // 
            // btnPermission
            // 
            btnPermission.BackColor = Color.FromArgb(181, 218, 183);
            btnPermission.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPermission.ForeColor = SystemColors.InactiveCaptionText;
            btnPermission.Location = new Point(460, 25);
            btnPermission.Name = "btnPermission";
            btnPermission.Size = new Size(129, 127);
            btnPermission.TabIndex = 3;
            btnPermission.Text = "Permission";
            btnPermission.UseVisualStyleBackColor = false;
            // 
            // btnDepartment
            // 
            btnDepartment.BackColor = Color.FromArgb(125, 207, 182);
            btnDepartment.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepartment.ForeColor = SystemColors.InactiveCaptionText;
            btnDepartment.Location = new Point(595, 25);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(134, 127);
            btnDepartment.TabIndex = 4;
            btnDepartment.Text = "Department";
            btnDepartment.UseVisualStyleBackColor = false;
            // 
            // btnPosition
            // 
            btnPosition.BackColor = Color.FromArgb(88, 205, 155);
            btnPosition.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPosition.ForeColor = SystemColors.InactiveCaptionText;
            btnPosition.Location = new Point(735, 25);
            btnPosition.Name = "btnPosition";
            btnPosition.Size = new Size(126, 127);
            btnPosition.TabIndex = 5;
            btnPosition.Text = "Position";
            btnPosition.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(51, 202, 127);
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = SystemColors.InactiveCaptionText;
            btnLogout.Location = new Point(318, 181);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(136, 36);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.Location = new Point(460, 181);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(129, 36);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 159, 91);
            ClientSize = new Size(903, 245);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(btnPosition);
            Controls.Add(btnDepartment);
            Controls.Add(btnPermission);
            Controls.Add(btnSalary);
            Controls.Add(btnTasks);
            Controls.Add(btnEmployee);
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmployee;
        private Button btnTasks;
        private Button btnSalary;
        private Button btnPermission;
        private Button btnDepartment;
        private Button btnPosition;
        private Button btnLogout;
        private Button btnExit;
    }
}