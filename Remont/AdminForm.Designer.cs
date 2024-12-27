namespace Remont
{
    partial class AdminForm
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
            dgvRemont = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvUsers = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExportUsers = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRemont).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvRemont
            // 
            dgvRemont.BackgroundColor = SystemColors.ButtonHighlight;
            dgvRemont.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRemont.Location = new Point(256, 152);
            dgvRemont.Name = "dgvRemont";
            dgvRemont.RowHeadersWidth = 82;
            dgvRemont.Size = new Size(1265, 369);
            dgvRemont.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(529, 9);
            label1.Name = "label1";
            label1.Size = new Size(748, 92);
            label1.TabIndex = 1;
            label1.Text = "Ремонт оборудования";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(256, 109);
            label2.Name = "label2";
            label2.Size = new Size(125, 37);
            label2.TabIndex = 2;
            label2.Text = "\"Заявки\"";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(468, 701);
            label3.Name = "label3";
            label3.Size = new Size(213, 37);
            label3.TabIndex = 4;
            label3.Text = "\"Пользователи\"";
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = SystemColors.ButtonHighlight;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(468, 744);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 82;
            dgvUsers.Size = new Size(866, 259);
            dgvUsers.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MidnightBlue;
            btnAdd.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(256, 549);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(330, 70);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Добавить заявку";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.MidnightBlue;
            btnEdit.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(611, 549);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(372, 70);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Редактировать заявку";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlLightLight;
            btnDelete.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDelete.ForeColor = Color.MidnightBlue;
            btnDelete.Location = new Point(1227, 549);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(294, 70);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Удалить заявку";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExportUsers
            // 
            btnExportUsers.BackColor = Color.MidnightBlue;
            btnExportUsers.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExportUsers.ForeColor = SystemColors.ButtonHighlight;
            btnExportUsers.Location = new Point(717, 1019);
            btnExportUsers.Name = "btnExportUsers";
            btnExportUsers.Size = new Size(372, 70);
            btnExportUsers.TabIndex = 10;
            btnExportUsers.Text = "Выгрузить пользователей";
            btnExportUsers.UseVisualStyleBackColor = false;
            btnExportUsers.Click += btnExportUsers_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLightLight;
            button6.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button6.ForeColor = Color.MidnightBlue;
            button6.Location = new Point(1527, 152);
            button6.Name = "button6";
            button6.Size = new Size(49, 48);
            button6.TabIndex = 11;
            button6.Text = "о";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1770, 1145);
            Controls.Add(button6);
            Controls.Add(btnExportUsers);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(dgvUsers);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvRemont);
            Name = "AdminForm";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dgvRemont).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRemont;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvUsers;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnExportUsers;
        private Button button6;
    }
}