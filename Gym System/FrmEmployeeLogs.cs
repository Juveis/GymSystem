using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Entities.Employees;

namespace GYM_System
{
    public partial class FrmEmployeeLogs : Form
    {
        //Class Constructor
        public FrmEmployeeLogs()
        {
            InitializeComponent();
        }

        //Properties
        public List<EmployeeLogs> Logs { get; set; }

        //Methods
        private void LoadLogs()
        {
            dgvEmployeeLogs.Rows.Clear();
            
            var start = dtpStartDate.Value;
            var end = dtpEndDate.Value;

            Logs = EmployeeLogs.GetByDate(start, end);

            foreach (var log in Logs)
            {
                if (log.CheckOut == DateTime.MinValue)
                {
                    var checkOut = "";
                    dgvEmployeeLogs.Rows.Add(log.EmployeeNumber, log.FirstName, log.LastName, log.CheckIn, checkOut);
                }
                else
                {
                    dgvEmployeeLogs.Rows.Add(log.EmployeeNumber, log.FirstName, log.LastName, log.CheckIn, log.CheckOut);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }
    }
}
