namespace Remont
{
    partial class AddForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpDateAdded = new DateTimePicker();
            textEquipment = new TextBox();
            textFaultType = new TextBox();
            textProblemDescription = new TextBox();
            textClient = new TextBox();
            cmbStatus = new ComboBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(377, 27);
            label1.Name = "label1";
            label1.Size = new Size(508, 71);
            label1.TabIndex = 2;
            label1.Text = "Добавление заявки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(268, 178);
            label2.Name = "label2";
            label2.Size = new Size(201, 45);
            label2.TabIndex = 3;
            label2.Text = "Дата заявки:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(268, 244);
            label3.Name = "label3";
            label3.Size = new Size(247, 45);
            label3.TabIndex = 4;
            label3.Text = "Оборудование:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(268, 308);
            label4.Name = "label4";
            label4.Size = new Size(313, 45);
            label4.TabIndex = 5;
            label4.Text = "Тип неисправности:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(268, 373);
            label5.Name = "label5";
            label5.Size = new Size(336, 45);
            label5.TabIndex = 6;
            label5.Text = "Описание проблемы:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(268, 437);
            label6.Name = "label6";
            label6.Size = new Size(130, 45);
            label6.TabIndex = 7;
            label6.Text = "Клиент:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(268, 503);
            label7.Name = "label7";
            label7.Size = new Size(226, 45);
            label7.TabIndex = 8;
            label7.Text = "Статус заявки:";
            // 
            // dtpDateAdded
            // 
            dtpDateAdded.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtpDateAdded.Location = new Point(499, 178);
            dtpDateAdded.Name = "dtpDateAdded";
            dtpDateAdded.Size = new Size(400, 43);
            dtpDateAdded.TabIndex = 9;
            // 
            // textEquipment
            // 
            textEquipment.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textEquipment.Location = new Point(544, 244);
            textEquipment.Name = "textEquipment";
            textEquipment.Size = new Size(402, 43);
            textEquipment.TabIndex = 10;
            // 
            // textFaultType
            // 
            textFaultType.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textFaultType.Location = new Point(609, 308);
            textFaultType.Name = "textFaultType";
            textFaultType.Size = new Size(402, 43);
            textFaultType.TabIndex = 11;
            // 
            // textProblemDescription
            // 
            textProblemDescription.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textProblemDescription.Location = new Point(642, 373);
            textProblemDescription.Name = "textProblemDescription";
            textProblemDescription.Size = new Size(402, 43);
            textProblemDescription.TabIndex = 12;
            // 
            // textClient
            // 
            textClient.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textClient.Location = new Point(436, 440);
            textClient.Name = "textClient";
            textClient.Size = new Size(402, 43);
            textClient.TabIndex = 13;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "в ожидании", "в работе", "выполнено" });
            cmbStatus.Location = new Point(526, 503);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(395, 45);
            cmbStatus.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MidnightBlue;
            btnAdd.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(468, 615);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(330, 83);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Добавить заявку";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 729);
            Controls.Add(btnAdd);
            Controls.Add(cmbStatus);
            Controls.Add(textClient);
            Controls.Add(textProblemDescription);
            Controls.Add(textFaultType);
            Controls.Add(textEquipment);
            Controls.Add(dtpDateAdded);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpDateAdded;
        private TextBox textEquipment;
        private TextBox textFaultType;
        private TextBox textProblemDescription;
        private TextBox textClient;
        private ComboBox cmbStatus;
        private Button btnAdd;
    }
}