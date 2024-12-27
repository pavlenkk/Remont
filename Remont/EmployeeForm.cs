using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remont
{
    public partial class EmployeeForm : Form
    {
        private DatabaseManager dbManager;
        public EmployeeForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var AddForm = new AddForm();
            AddForm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var EditForm = new EditForm();
            EditForm.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvRemont.DataSource = dbManager.GetRemont();
        }
    }
}
