namespace EmployeeTracking
{
    partial class Department
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
            label1 = new Label();
            txtDepartment = new TextBox();
            txtDeptAdd = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 53);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 0;
            label1.Text = "Department";
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDepartment.Location = new Point(157, 50);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(238, 33);
            txtDepartment.TabIndex = 0;
            // 
            // txtDeptAdd
            // 
            txtDeptAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDeptAdd.Location = new Point(58, 118);
            txtDeptAdd.Name = "txtDeptAdd";
            txtDeptAdd.Size = new Size(139, 63);
            txtDeptAdd.TabIndex = 1;
            txtDeptAdd.Text = "Add";
            txtDeptAdd.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(221, 118);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 63);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Department
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 159, 91);
            ClientSize = new Size(422, 242);
            Controls.Add(btnClose);
            Controls.Add(txtDeptAdd);
            Controls.Add(txtDepartment);
            Controls.Add(label1);
            Name = "Department";
            Text = "Department";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDepartment;
        private Button txtDeptAdd;
        private Button btnClose;
    }
}