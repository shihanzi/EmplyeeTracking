namespace EmployeeTracking
{
    partial class SalaryList
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
            panel2 = new Panel();
            btnClose = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddNew = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            cmbDepartment = new ComboBox();
            cmbPosition = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtUserNo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            panel3 = new Panel();
            btnClear = new Button();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            rbEquals = new RadioButton();
            rbLess = new RadioButton();
            rbMore = new RadioButton();
            cmbMonth = new ComboBox();
            label8 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnAddNew);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 350);
            panel2.Name = "panel2";
            panel2.Size = new Size(1029, 100);
            panel2.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(642, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(141, 64);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(482, 16);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 64);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(321, 16);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(141, 64);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNew.Location = new Point(160, 16);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(141, 64);
            btnAddNew.TabIndex = 0;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1029, 168);
            dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbDepartment);
            panel1.Controls.Add(cmbPosition);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUserNo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtSurname);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 182);
            panel1.TabIndex = 0;
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(155, 107);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(196, 28);
            cmbDepartment.TabIndex = 3;
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(154, 143);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(197, 28);
            cmbPosition.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(55, 144);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 25;
            label5.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(53, 110);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 23;
            label4.Text = "Department";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 12);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 16;
            label1.Text = "User No";
            // 
            // txtUserNo
            // 
            txtUserNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserNo.Location = new Point(154, 8);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(197, 27);
            txtUserNo.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 45);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 19;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(53, 77);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 18;
            label3.Text = "Sur Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(154, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(197, 27);
            txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSurname.Location = new Point(154, 75);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(197, 27);
            txtSurname.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(cmbMonth);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(424, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(605, 182);
            panel3.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(177, 122);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 30);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(70, 122);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 30);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbEquals);
            groupBox1.Controls.Add(rbLess);
            groupBox1.Controls.Add(rbMore);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(273, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(199, 51);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // rbEquals
            // 
            rbEquals.AutoSize = true;
            rbEquals.Location = new Point(124, 22);
            rbEquals.Name = "rbEquals";
            rbEquals.Size = new Size(59, 19);
            rbEquals.TabIndex = 2;
            rbEquals.TabStop = true;
            rbEquals.Text = "Equals";
            rbEquals.UseVisualStyleBackColor = true;
            // 
            // rbLess
            // 
            rbLess.AutoSize = true;
            rbLess.Location = new Point(65, 22);
            rbLess.Name = "rbLess";
            rbLess.Size = new Size(48, 19);
            rbLess.TabIndex = 1;
            rbLess.TabStop = true;
            rbLess.Text = "Less";
            rbLess.UseVisualStyleBackColor = true;
            // 
            // rbMore
            // 
            rbMore.AutoSize = true;
            rbMore.Location = new Point(6, 22);
            rbMore.Name = "rbMore";
            rbMore.Size = new Size(55, 19);
            rbMore.TabIndex = 0;
            rbMore.TabStop = true;
            rbMore.Text = "More";
            rbMore.UseVisualStyleBackColor = true;
            // 
            // cmbMonth
            // 
            cmbMonth.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(70, 46);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(150, 28);
            cmbMonth.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(7, 49);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 25;
            label8.Text = "Month";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(70, 9);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(197, 27);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(70, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 27);
            textBox2.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(10, 13);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 0;
            label7.Text = "Year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(7, 83);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 21;
            label6.Text = "Salary";
            // 
            // SalaryList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Name = "SalaryList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalaryList";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btnClose;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAddNew;
        private Panel panel1;
        private Panel panel3;
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
        private GroupBox groupBox1;
        private RadioButton rbEquals;
        private RadioButton rbLess;
        private RadioButton rbMore;
        private ComboBox cmbMonth;
        private Label label8;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label7;
        private Label label6;
        private Button btnClear;
        private Button btnSearch;
    }
}