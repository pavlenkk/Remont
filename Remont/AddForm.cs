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
    public partial class AddForm : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=repair;Username=postgres;Password=alina";

        public AddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime DateAdded = dtpDateAdded.Value;
                string Equipment = textEquipment.Text;
                string FaultType = textFaultType.Text;
                string ProblemDescription = textProblemDescription.Text;
                string Client = textClient.Text;
                string Status = cmbStatus.SelectedItem.ToString();
                

                var databaseManager = new DatabaseManager();

                databaseManager.AddTask(DateAdded, Equipment, FaultType, ProblemDescription, Client, Status);

                MessageBox.Show("Задача успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении задачи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
