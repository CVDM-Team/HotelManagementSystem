using HotelManagementSystem.Models;
using HotelManagementSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms
{
    public partial class frmEditEmployeeType : Form
    {
        HotelEntities1 db = new HotelEntities1();
        public frmEditEmployeeType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool status = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text == "")
                    {
                        status = false;
                    }
                }
            }
            if (!status)
            {
                MessageBox.Show("Please input all information employee", "Message");
                return;
            }
            try
            {
                EmployeeType em = db.EmployeeTypes.Find(UC_EmployeeType.employeeTypeID);
                
                em.Name = txtName.Text;
                db.SaveChanges();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void EditEmployeeType_Load(object sender, EventArgs e)
        {
            if (UC_EmployeeType.employeeTypeID != 0)
            {
                EmployeeType employeeType = db.EmployeeTypes.Find(UC_EmployeeType.employeeTypeID);
                txtName.Text = employeeType.Name;
            }
        }
    }
}



            


    