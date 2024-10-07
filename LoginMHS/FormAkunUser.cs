using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginMHS
{
    public partial class FormAkunUser : Form
    {
        public FormAkunUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilterUser1.SetParameterValue("akun_user", txtUsername.Text);
            crystalReportViewer1.ReportSource = FilterUser1;
            crystalReportViewer1.Refresh();
        }
    }
}
