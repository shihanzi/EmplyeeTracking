﻿using EmplyeeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeTracking
{
    public partial class PermissionList : Form
    {
        public PermissionList()
        {
            InitializeComponent();
        }
        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }
    }
}
