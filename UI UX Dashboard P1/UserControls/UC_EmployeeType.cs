using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.Forms;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.UserControls
{
    public partial class UC_EmployeeType : UserControl
    {
        HotelEntities1 db = new HotelEntities1();
        public UC_EmployeeType()
        {
            InitializeComponent();
        }
        private void LoadDataGridView()
        {
            using (var context = new HotelEntities1())
            {
                dgvEmployeeType.DataSource = context.EmployeeTypes.Select(x => new { ID = x.ID, Name = x.Name, Status = x.isLocked == true ? "Lock" : "Active" }).ToList();
            }
        }
        public static int employeeTypeID = 0;
        private void UC_EmployeeType_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            if (dgvEmployeeType.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = dgvEmployeeType.SelectedRows[0];
                employeeTypeID = (int)dataGridViewRow.Cells[0].Value;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEmployeeType add = new frmAddEmployeeType();
            add.ShowDialog();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditEmployeeType edit = new frmEditEmployeeType();
            edit.ShowDialog();
            if (edit.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Edit employee success", "Message");
                LoadDataGridView();
            }
        }

        private void dgvEmployeeType_Click(object sender, EventArgs e)
        {
            if (dgvEmployeeType.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = dgvEmployeeType.SelectedRows[0];
                employeeTypeID = (int)dataGridViewRow.Cells[0].Value;
            }
        }

        private void dgvEmployeeType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if(dgvEmployeeType.SelectedRows.Count>0)
            {
                if (MessageBox.Show("Do you want to lock employee", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DataGridViewRow dataGridViewRow = dgvEmployeeType.SelectedRows[0];
                    EmployeeType employeeType = db.EmployeeTypes.Find(dataGridViewRow.Cells[0].Value);
                    employeeType.isLocked = true;
                    db.SaveChanges();

                    LoadDataGridView();
                }
            }
        }
    }
}
