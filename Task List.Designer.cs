namespace EmployeeTracking
{
    partial class FrmTask_List
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
            btnApprove = new Button();
            btnClose = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            pnlForUser = new Panel();
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
            pnlForAdmin = new Panel();
            cmbTaskState = new ComboBox();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            rdbStart = new RadioButton();
            label9 = new Label();
            dtpTaskEnd = new DateTimePicker();
            dtpTaskStart = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnClear = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlForUser.SuspendLayout();
            pnlForAdmin.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnApprove);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 472);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 100);
            panel1.TabIndex = 1;
            // 
            // btnApprove
            // 
            btnApprove.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnApprove.Location = new Point(66, 18);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(141, 64);
            btnApprove.TabIndex = 0;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(707, 18);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(141, 64);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(547, 18);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 64);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(386, 18);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(141, 64);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(225, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 64);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(938, 269);
            dataGridView1.TabIndex = 3;
            // 
            // pnlForUser
            // 
            pnlForUser.Controls.Add(cmbDepartment);
            pnlForUser.Controls.Add(cmbPosition);
            pnlForUser.Controls.Add(label5);
            pnlForUser.Controls.Add(label4);
            pnlForUser.Controls.Add(label1);
            pnlForUser.Controls.Add(txtUserNo);
            pnlForUser.Controls.Add(label2);
            pnlForUser.Controls.Add(label3);
            pnlForUser.Controls.Add(txtName);
            pnlForUser.Controls.Add(txtSurname);
            pnlForUser.Dock = DockStyle.Left;
            pnlForUser.Location = new Point(0, 0);
            pnlForUser.Name = "pnlForUser";
            pnlForUser.Size = new Size(472, 203);
            pnlForUser.TabIndex = 0;
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(112, 99);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(196, 28);
            cmbDepartment.TabIndex = 12;
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(111, 135);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(197, 28);
            cmbPosition.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 136);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 15;
            label5.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 102);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 13;
            label4.Text = "Department";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 6;
            label1.Text = "User No";
            // 
            // txtUserNo
            // 
            txtUserNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserNo.Location = new Point(111, 4);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(197, 27);
            txtUserNo.TabIndex = 7;
            txtUserNo.TextChanged += txtUserNo_TextChanged;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 69);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 8;
            label3.Text = "Sur Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(111, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(197, 27);
            txtName.TabIndex = 10;
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSurname.Location = new Point(111, 67);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(197, 27);
            txtSurname.TabIndex = 11;
            // 
            // pnlForAdmin
            // 
            pnlForAdmin.Controls.Add(btnClear);
            pnlForAdmin.Controls.Add(cmbTaskState);
            pnlForAdmin.Controls.Add(btnSearch);
            pnlForAdmin.Controls.Add(groupBox1);
            pnlForAdmin.Controls.Add(label9);
            pnlForAdmin.Controls.Add(dtpTaskEnd);
            pnlForAdmin.Controls.Add(dtpTaskStart);
            pnlForAdmin.Controls.Add(label8);
            pnlForAdmin.Controls.Add(label7);
            pnlForAdmin.Controls.Add(label6);
            pnlForAdmin.Dock = DockStyle.Right;
            pnlForAdmin.Location = new Point(478, 0);
            pnlForAdmin.Name = "pnlForAdmin";
            pnlForAdmin.Size = new Size(460, 203);
            pnlForAdmin.TabIndex = 2;
            // 
            // cmbTaskState
            // 
            cmbTaskState.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTaskState.FormattingEnabled = true;
            cmbTaskState.Location = new Point(81, 128);
            cmbTaskState.Name = "cmbTaskState";
            cmbTaskState.Size = new Size(174, 28);
            cmbTaskState.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(212, 162);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 30);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(rdbStart);
            groupBox1.Location = new Point(261, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(187, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(6, 50);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(88, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "End Date";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdbStart
            // 
            rdbStart.AutoSize = true;
            rdbStart.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rdbStart.Location = new Point(6, 16);
            rdbStart.Name = "rdbStart";
            rdbStart.Size = new Size(94, 24);
            rdbStart.TabIndex = 0;
            rdbStart.TabStop = true;
            rdbStart.Text = "Start Date";
            rdbStart.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(5, 132);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 17;
            label9.Text = "Task State";
            // 
            // dtpTaskEnd
            // 
            dtpTaskEnd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTaskEnd.Location = new Point(48, 86);
            dtpTaskEnd.Name = "dtpTaskEnd";
            dtpTaskEnd.Size = new Size(198, 27);
            dtpTaskEnd.TabIndex = 4;
            // 
            // dtpTaskStart
            // 
            dtpTaskStart.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTaskStart.Location = new Point(48, 53);
            dtpTaskStart.Name = "dtpTaskStart";
            dtpTaskStart.Size = new Size(198, 27);
            dtpTaskStart.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 86);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 2;
            label8.Text = "End";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(2, 54);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 1;
            label7.Text = "Start";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(24, 11);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 0;
            label6.Text = "Task Date";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(319, 162);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(121, 30);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // FrmTask_List
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 572);
            Controls.Add(pnlForAdmin);
            Controls.Add(pnlForUser);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FrmTask_List";
            Text = "Task_List";
            Load += FrmTask_List_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlForUser.ResumeLayout(false);
            pnlForUser.PerformLayout();
            pnlForAdmin.ResumeLayout(false);
            pnlForAdmin.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btnApprove;
        private Button btnClose;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Panel pnlForUser;
        private Panel pnlForAdmin;
        private Label label1;
        private TextBox txtUserNo;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtSurname;
        private ComboBox cmbDepartment;
        private ComboBox cmbPosition;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpTaskEnd;
        private DateTimePicker dtpTaskStart;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox cmbTaskState;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton rdbStart;
        private Label label9;
        private Button btnSearch;
        private Button btnClear;
    }
}