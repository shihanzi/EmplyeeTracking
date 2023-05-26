namespace EmployeeTracking
{
    partial class FrmTask
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
            panel1 = new Panel();
            cmbDepartment = new ComboBox();
            cmbPosition = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtUserNo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label9 = new Label();
            cmbTaskState = new ComboBox();
            label10 = new Label();
            txtTitle = new TextBox();
            label11 = new Label();
            txtContent = new TextBox();
            btnClose = new Button();
            btnTaskSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbDepartment);
            panel1.Controls.Add(cmbPosition);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(344, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 547);
            panel1.TabIndex = 0;
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(111, 26);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(196, 28);
            cmbDepartment.TabIndex = 16;
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(110, 62);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(197, 28);
            cmbPosition.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(11, 63);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 19;
            label5.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 29);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 17;
            label4.Text = "Department";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(317, 428);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(313, 857);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 12;
            label1.Text = "User No";
            // 
            // txtUserNo
            // 
            txtUserNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserNo.Location = new Point(412, 853);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(197, 27);
            txtUserNo.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(313, 886);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 15;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(311, 918);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 14;
            label3.Text = "Sur Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(412, 884);
            txtName.Name = "txtName";
            txtName.Size = new Size(197, 27);
            txtName.TabIndex = 16;
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSurname.Location = new Point(412, 916);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(197, 27);
            txtSurname.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 26);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 18;
            label6.Text = "User No";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(111, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 27);
            textBox1.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 55);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 21;
            label7.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(10, 87);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 20;
            label8.Text = "Sur Name";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(111, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 27);
            textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(111, 85);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(197, 27);
            textBox3.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(10, 125);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 24;
            label9.Text = "Task State";
            // 
            // cmbTaskState
            // 
            cmbTaskState.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTaskState.FormattingEnabled = true;
            cmbTaskState.Location = new Point(112, 120);
            cmbTaskState.Name = "cmbTaskState";
            cmbTaskState.Size = new Size(121, 28);
            cmbTaskState.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 164);
            label10.Name = "label10";
            label10.Size = new Size(38, 20);
            label10.TabIndex = 26;
            label10.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(112, 162);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(197, 27);
            txtTitle.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(15, 200);
            label11.Name = "label11";
            label11.Size = new Size(61, 20);
            label11.TabIndex = 28;
            label11.Text = "Content";
            // 
            // txtContent
            // 
            txtContent.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContent.Location = new Point(112, 200);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(197, 245);
            txtContent.TabIndex = 29;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(176, 451);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 63);
            btnClose.TabIndex = 31;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnTaskSave
            // 
            btnTaskSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTaskSave.Location = new Point(23, 451);
            btnTaskSave.Name = "btnTaskSave";
            btnTaskSave.Size = new Size(139, 63);
            btnTaskSave.TabIndex = 30;
            btnTaskSave.Text = "Add";
            btnTaskSave.UseVisualStyleBackColor = true;
            // 
            // FrmTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 547);
            Controls.Add(btnClose);
            Controls.Add(btnTaskSave);
            Controls.Add(txtContent);
            Controls.Add(label11);
            Controls.Add(txtTitle);
            Controls.Add(label10);
            Controls.Add(cmbTaskState);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(txtUserNo);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(txtSurname);
            Controls.Add(panel1);
            Name = "FrmTask";
            Text = "FormTask";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private ComboBox cmbDepartment;
        private ComboBox cmbPosition;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox txtUserNo;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtSurname;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label9;
        private ComboBox cmbTaskState;
        private Label label10;
        private TextBox txtTitle;
        private Label label11;
        private TextBox txtContent;
        private Button btnClose;
        private Button btnTaskSave;
    }
}