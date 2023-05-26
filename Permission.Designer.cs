namespace EmployeeTracking
{
    partial class Permission
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
            dtpTaskEnd = new DateTimePicker();
            dtpTaskStart = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtUserNo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDayAmount = new TextBox();
            txtExplanation = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // dtpTaskEnd
            // 
            dtpTaskEnd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTaskEnd.Location = new Point(111, 95);
            dtpTaskEnd.Name = "dtpTaskEnd";
            dtpTaskEnd.Size = new Size(198, 27);
            dtpTaskEnd.TabIndex = 1;
            // 
            // dtpTaskStart
            // 
            dtpTaskStart.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTaskStart.Location = new Point(111, 62);
            dtpTaskStart.Name = "dtpTaskStart";
            dtpTaskStart.Size = new Size(198, 27);
            dtpTaskStart.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(69, 98);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 6;
            label8.Text = "End";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(63, 64);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 5;
            label7.Text = "Start";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(32, 24);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 20;
            label6.Text = "User No";
            // 
            // txtUserNo
            // 
            txtUserNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserNo.Location = new Point(111, 21);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.ReadOnly = true;
            txtUserNo.Size = new Size(197, 27);
            txtUserNo.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 136);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 22;
            label1.Text = "Day Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 169);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 23;
            label2.Text = "Explanation";
            // 
            // txtDayAmount
            // 
            txtDayAmount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDayAmount.Location = new Point(112, 136);
            txtDayAmount.Name = "txtDayAmount";
            txtDayAmount.ReadOnly = true;
            txtDayAmount.Size = new Size(197, 27);
            txtDayAmount.TabIndex = 24;
            // 
            // txtExplanation
            // 
            txtExplanation.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtExplanation.Location = new Point(112, 178);
            txtExplanation.Multiline = true;
            txtExplanation.Name = "txtExplanation";
            txtExplanation.Size = new Size(382, 110);
            txtExplanation.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(265, 308);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 63);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(112, 308);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 63);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Permission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 386);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtExplanation);
            Controls.Add(txtDayAmount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(txtUserNo);
            Controls.Add(dtpTaskEnd);
            Controls.Add(dtpTaskStart);
            Controls.Add(label8);
            Controls.Add(label7);
            Name = "Permission";
            Text = "Permission";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpTaskEnd;
        private DateTimePicker dtpTaskStart;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtUserNo;
        private Label label1;
        private Label label2;
        private TextBox txtDayAmount;
        private TextBox txtExplanation;
        private Button btnClose;
        private Button btnSave;
    }
}