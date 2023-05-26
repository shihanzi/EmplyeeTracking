namespace EmployeeTracking
{
    partial class PositionList
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
            DgvPositionList = new DataGridView();
            panel1 = new Panel();
            btnClose = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddNew = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvPositionList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DgvPositionList
            // 
            DgvPositionList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPositionList.Dock = DockStyle.Top;
            DgvPositionList.Location = new Point(0, 0);
            DgvPositionList.Name = "DgvPositionList";
            DgvPositionList.RowTemplate.Height = 25;
            DgvPositionList.Size = new Size(800, 353);
            DgvPositionList.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAddNew);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(603, 18);
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
            btnDelete.Location = new Point(410, 18);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 64);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(214, 18);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(176, 64);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNew.Location = new Point(21, 18);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(176, 64);
            btnAddNew.TabIndex = 0;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // PositionList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(DgvPositionList);
            Name = "PositionList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PositionList";
            ((System.ComponentModel.ISupportInitialize)DgvPositionList).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvPositionList;
        private Panel panel1;
        private Button btnClose;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAddNew;
    }
}