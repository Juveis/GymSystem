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
    public partial class FrmSearchEmployee : Form
    {
        //Properties
        public Employee _Employee { get; set; }

        private List<Employee> employeeList; 

        
        
        //Class Constructor
        public FrmSearchEmployee()
        {
            InitializeComponent();
        }


        //Private methods
        //Private Methods
        private void Search()
        {
            foreach (RadioButton radio in gbFilters.Controls)
            {
                if (radio.Checked)
                {
                    var lenth = radio.Name.Length;
                    var field = radio.Name.Substring(2);
                    var value = txtSearch.Text;

                    if (field == "Todos")
                    {
                        employeeList = Employee.GetAll();
                        ListToDataTable();
                    }
                    else
                    {
                        employeeList = Employee.GetEmployee(field, value);
                        ListToDataTable();
                    }

                }
            }
        }

        private void ListToDataTable()
        {
            dgvResults.Rows.Clear();

            if (employeeList != null)
            {
                foreach (var employee in employeeList)
                {
                    dgvResults.Rows.Add(
                        employee,
                        employee.Number.ToString("0000"),
                        employee.FirstName,
                        employee.FirstLastName,
                        employee.JobPosition,
                        employee.Status
                        );
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void dgvResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _Employee = (Employee) dgvResults.SelectedRows[0].Cells["EmployeeObject"].Value;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
