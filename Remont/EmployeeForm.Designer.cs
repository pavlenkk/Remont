namespace Remont
{
    partial class EmployeeForm
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
            button6 = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            label2 = new Label();
            label1 = new Label();
            dgvRemont = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRemont).BeginInit();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLightLight;
            button6.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button6.ForeColor = Color.MidnightBlue;
            button6.Location = new Point(1498, 180);
            button6.Name = "button6";
            button6.Size = new Size(49, 48);
            button6.TabIndex = 18;
            button6.Text = "о";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.MidnightBlue;
            btnEdit.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(582, 577);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(372, 70);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Редактировать заявку";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MidnightBlue;
            btnAdd.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(227, 577);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(330, 70);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Добавить заявку";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(227, 137);
            label2.Name = "label2";
            label2.Size = new Size(125, 37);
            label2.TabIndex = 14;
            label2.Text = "\"Заявки\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(500, 37);
            label1.Name = "label1";
            label1.Size = new Size(748, 92);
            label1.TabIndex = 13;
            label1.Text = "Ремонт оборудования";
            // 
            // dgvRemont
            // 
            dgvRemont.BackgroundColor = SystemColors.ButtonHighlight;
            dgvRemont.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRemont.Location = new Point(227, 180);
            dgvRemont.Name = "dgvRemont";
            dgvRemont.RowHeadersWidth = 82;
            dgvRemont.Size = new Size(1265, 369);
            dgvRemont.TabIndex = 12;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1732, 740);
            Controls.Add(button6);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvRemont);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)dgvRemont).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Button btnEdit;
        private Button btnAdd;
        private Label label2;
        private Label label1;
        private DataGridView dgvRemont;
    }
}