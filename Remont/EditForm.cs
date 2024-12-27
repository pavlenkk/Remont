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
    public partial class EditForm : Form
    {
        private DatabaseManager dbManager;
        
        public EditForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            LoadTasks();
        }

        private void LoadTasks()
        {
            dgvRemont.DataSource = dbManager.GetRemont();
        }

        private void dgvRemont_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRemont.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvRemont.SelectedRows[0];
                textProblemDescription.Text = row.Cells["problemdescription"].Value.ToString();
                textClient.Text = row.Cells["client"].Value.ToString();
                cmbStatus.SelectedItem = row.Cells["status"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRemont.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите задачу для редактирования.");
                return;
            }

            DataGridViewRow selectedRow = dgvRemont.SelectedRows[0];
            int requestId = (int)selectedRow.Cells["requestid"].Value;

            string newDescription = textProblemDescription.Text;
            string newClient = textClient.Text;
            string newStatus = cmbStatus.SelectedItem.ToString();
            

            var databaseManager = new DatabaseManager();


            databaseManager.Update(requestId, newDescription, newClient, newStatus);

            MessageBox.Show("Задача успешно обновлена.");

            LoadTasks();
        }
    }
}
