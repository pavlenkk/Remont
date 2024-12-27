namespace Remont
{
    partial class EditForm
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
            btnEdit = new Button();
            cmbStatus = new ComboBox();
            textClient = new TextBox();
            textProblemDescription = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            dgvRemont = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRemont).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.MidnightBlue;
            btnEdit.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(413, 402);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(402, 83);
            btnEdit.TabIndex = 29;
            btnEdit.Text = "Редактировать заявку";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "в ожидании", "в работе", "выполнено" });
            cmbStatus.Location = new Point(503, 311);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(395, 45);
            cmbStatus.TabIndex = 28;
            // 
            // textClient
            // 
            textClient.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textClient.Location = new Point(413, 248);
            textClient.Name = "textClient";
            textClient.Size = new Size(402, 43);
            textClient.TabIndex = 27;
            // 
            // textProblemDescription
            // 
            textProblemDescription.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textProblemDescription.Location = new Point(619, 181);
            textProblemDescription.Name = "textProblemDescription";
            textProblemDescription.Size = new Size(402, 43);
            textProblemDescription.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(245, 311);
            label7.Name = "label7";
            label7.Size = new Size(226, 45);
            label7.TabIndex = 22;
            label7.Text = "Статус заявки:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(245, 245);
            label6.Name = "label6";
            label6.Size = new Size(130, 45);
            label6.TabIndex = 21;
            label6.Text = "Клиент:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(245, 181);
            label5.Name = "label5";
            label5.Size = new Size(336, 45);
            label5.TabIndex = 20;
            label5.Text = "Описание проблемы:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(337, 31);
            label1.Name = "label1";
            label1.Size = new Size(608, 71);
            label1.TabIndex = 16;
            label1.Text = "Редактирование заявки";
            // 
            // dgvRemont
            // 
            dgvRemont.BackgroundColor = SystemColors.ButtonHighlight;
            dgvRemont.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRemont.Location = new Point(59, 532);
            dgvRemont.Name = "dgvRemont";
            dgvRemont.RowHeadersWidth = 82;
            dgvRemont.Size = new Size(1143, 346);
            dgvRemont.TabIndex = 30;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 933);
            Controls.Add(dgvRemont);
            Controls.Add(btnEdit);
            Controls.Add(cmbStatus);
            Controls.Add(textClient);
            Controls.Add(textProblemDescription);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "EditForm";
            Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)dgvRemont).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private ComboBox cmbStatus;
        private TextBox textClient;
        private TextBox textProblemDescription;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        private DataGridView dgvRemont;
    }
}