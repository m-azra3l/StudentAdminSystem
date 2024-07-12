namespace StudentAdministrator.UI
{
    partial class AddEditAssessment
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
            closeBtn = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            percentBox = new TextBox();
            maxBox = new TextBox();
            nameBox = new TextBox();
            idBox = new TextBox();
            updateBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Red;
            closeBtn.Location = new Point(304, 262);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(246, 52);
            closeBtn.TabIndex = 49;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 79);
            panel1.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(162, 16);
            label1.Name = "label1";
            label1.Size = new Size(244, 54);
            label1.TabIndex = 0;
            label1.Text = "Assessment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(514, 195);
            label2.Name = "label2";
            label2.Size = new Size(46, 45);
            label2.TabIndex = 55;
            label2.Text = "%";
            // 
            // percentBox
            // 
            percentBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            percentBox.Location = new Point(304, 201);
            percentBox.Name = "percentBox";
            percentBox.PlaceholderText = "Percentage";
            percentBox.Size = new Size(204, 39);
            percentBox.TabIndex = 54;
            percentBox.TextAlign = HorizontalAlignment.Center;
            // 
            // maxBox
            // 
            maxBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maxBox.Location = new Point(32, 201);
            maxBox.Name = "maxBox";
            maxBox.PlaceholderText = "Max Score";
            maxBox.Size = new Size(246, 39);
            maxBox.TabIndex = 53;
            maxBox.TextAlign = HorizontalAlignment.Center;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameBox.Location = new Point(304, 126);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Name";
            nameBox.Size = new Size(246, 39);
            nameBox.TabIndex = 51;
            nameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // idBox
            // 
            idBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idBox.Location = new Point(32, 126);
            idBox.Name = "idBox";
            idBox.PlaceholderText = "Id";
            idBox.ReadOnly = true;
            idBox.Size = new Size(246, 39);
            idBox.TabIndex = 50;
            idBox.TextAlign = HorizontalAlignment.Center;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.SeaGreen;
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(32, 262);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(246, 52);
            updateBtn.TabIndex = 47;
            updateBtn.Text = "Create";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 98);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 56;
            label3.Text = "Assesment Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(304, 98);
            label4.Name = "label4";
            label4.Size = new Size(150, 25);
            label4.TabIndex = 57;
            label4.Text = "Assesment Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 173);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 58;
            label5.Text = "Max Score";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(304, 173);
            label6.Name = "label6";
            label6.Size = new Size(98, 25);
            label6.TabIndex = 59;
            label6.Text = "Percentage";
            // 
            // AddEditAssessment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(586, 340);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(closeBtn);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(percentBox);
            Controls.Add(maxBox);
            Controls.Add(nameBox);
            Controls.Add(idBox);
            Controls.Add(updateBtn);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEditAssessment";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAssessment";
            Load += AddEditAssessment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeBtn;
        private Panel panel1;
        private Label label1;
        private Label label2;
        public TextBox percentBox;
        public TextBox maxBox;
        public TextBox nameBox;
        public TextBox idBox;
        public Button updateBtn;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}