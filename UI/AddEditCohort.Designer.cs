﻿namespace StudentAdministrator.UI
{
    partial class AddEditCohort
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
            sessionBox = new TextBox();
            idBox = new TextBox();
            closeBtn = new Button();
            panel1 = new Panel();
            label1 = new Label();
            updateBtn = new Button();
            programBox = new ComboBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sessionBox
            // 
            sessionBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sessionBox.Location = new Point(46, 218);
            sessionBox.Name = "sessionBox";
            sessionBox.PlaceholderText = "Academic Session";
            sessionBox.Size = new Size(246, 39);
            sessionBox.TabIndex = 47;
            sessionBox.TextAlign = HorizontalAlignment.Center;
            // 
            // idBox
            // 
            idBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idBox.Location = new Point(46, 141);
            idBox.Name = "idBox";
            idBox.PlaceholderText = "Id";
            idBox.ReadOnly = true;
            idBox.Size = new Size(246, 39);
            idBox.TabIndex = 46;
            idBox.TextAlign = HorizontalAlignment.Center;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Red;
            closeBtn.Location = new Point(320, 278);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(246, 52);
            closeBtn.TabIndex = 45;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 79);
            panel1.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(215, 12);
            label1.Name = "label1";
            label1.Size = new Size(153, 54);
            label1.TabIndex = 0;
            label1.Text = "Cohort";
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.SeaGreen;
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(46, 278);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(246, 52);
            updateBtn.TabIndex = 43;
            updateBtn.Text = "Create";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // programBox
            // 
            programBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            programBox.FormattingEnabled = true;
            programBox.Location = new Point(320, 218);
            programBox.Name = "programBox";
            programBox.Size = new Size(246, 40);
            programBox.TabIndex = 48;
            programBox.Text = "Select Program";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 113);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 59;
            label5.Text = "Cohort Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 190);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 60;
            label2.Text = "Academic Session";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 190);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 61;
            label3.Text = "Select Program";
            // 
            // AddEditCohort
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(607, 356);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(programBox);
            Controls.Add(sessionBox);
            Controls.Add(idBox);
            Controls.Add(closeBtn);
            Controls.Add(panel1);
            Controls.Add(updateBtn);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEditCohort";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cohort";
            Load += AddEditCohort_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button closeBtn;
        private Panel panel1;
        private Label label1;
        public TextBox sessionBox;
        public TextBox idBox;
        public Button updateBtn;
        public ComboBox programBox;
        private Label label5;
        private Label label2;
        private Label label3;
    }
}