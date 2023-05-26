namespace EmployeeTracking
{
    partial class EmployeeList
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
            txtUserNo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmbPosition = new ComboBox();
            cmbDepartment = new ComboBox();
            btnSearch = new Button();
            btnClear = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            btnClose = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 11);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 1;
            label1.Text = "User No";
            // 
            // txtUserNo
            // 
            txtUserNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserNo.Location = new Point(155, 6);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(197, 33);
            txtUserNo.TabIndex = 2;
            txtUserNo.TextChanged += txtUserNo_TextChanged;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 48);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(54, 89);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 2;
            label3.Text = "Sur Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(155, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(197, 33);
            txtName.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(155, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 33);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(376, 9);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 6;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(376, 48);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 7;
            label5.Text = "Position";
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(501, 47);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(202, 33);
            cmbPosition.TabIndex = 7;
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(501, 6);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(202, 33);
            cmbDepartment.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(774, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(127, 53);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(774, 66);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(127, 53);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(948, 618);
            dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbDepartment);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(txtUserNo);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbPosition);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 126);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 518);
            panel2.Name = "panel2";
            panel2.Size = new Size(948, 100);
            panel2.TabIndex = 14;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(681, 20);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(176, 64);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(488, 20);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 64);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(292, 20);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(176, 64);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(99, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(176, 64);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // EmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 618);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "EmployeeList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emplyee List";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtUserNo;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private ComboBox cmbPosition;
        private ComboBox cmbDepartment;
        private Button btnSearch;
        private Button btnClear;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private Button btnClose;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}