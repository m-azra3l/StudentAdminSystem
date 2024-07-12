namespace StudentAdministrator.UI
{
    partial class StudentProfile
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
            lastNameBox = new TextBox();
            firstNameBox = new TextBox();
            degreeBox = new ComboBox();
            cohortBox = new ComboBox();
            idBox = new TextBox();
            closeBtn = new Button();
            updateBtn = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lastNameBox
            // 
            lastNameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameBox.Location = new Point(307, 253);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.PlaceholderText = "Last Name";
            lastNameBox.Size = new Size(246, 39);
            lastNameBox.TabIndex = 24;
            lastNameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // firstNameBox
            // 
            firstNameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameBox.Location = new Point(34, 253);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.PlaceholderText = "First Name";
            firstNameBox.Size = new Size(246, 39);
            firstNameBox.TabIndex = 23;
            firstNameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // degreeBox
            // 
            degreeBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            degreeBox.FormattingEnabled = true;
            degreeBox.Location = new Point(34, 337);
            degreeBox.Name = "degreeBox";
            degreeBox.Size = new Size(246, 40);
            degreeBox.TabIndex = 22;
            degreeBox.Text = "Degree Program";
            degreeBox.SelectedIndexChanged += degreeBox_SelectedIndexChanged;
            // 
            // cohortBox
            // 
            cohortBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cohortBox.FormattingEnabled = true;
            cohortBox.Location = new Point(307, 337);
            cohortBox.Name = "cohortBox";
            cohortBox.Size = new Size(246, 40);
            cohortBox.TabIndex = 21;
            cohortBox.Text = "Cohort";
            cohortBox.SelectedIndexChanged += cohortBox_SelectedIndexChanged;
            // 
            // idBox
            // 
            idBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idBox.Location = new Point(34, 166);
            idBox.Name = "idBox";
            idBox.PlaceholderText = "Student Id";
            idBox.ReadOnly = true;
            idBox.Size = new Size(246, 39);
            idBox.TabIndex = 37;
            idBox.TextAlign = HorizontalAlignment.Center;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Red;
            closeBtn.Location = new Point(307, 419);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(246, 50);
            closeBtn.TabIndex = 44;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.SeaGreen;
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(34, 419);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(246, 50);
            updateBtn.TabIndex = 43;
            updateBtn.Text = "Create";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(34, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 79);
            panel1.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(108, 12);
            label1.Name = "label1";
            label1.Size = new Size(305, 54);
            label1.TabIndex = 0;
            label1.Text = "Student Profile";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 309);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 67;
            label8.Text = "Degree";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 309);
            label5.Name = "label5";
            label5.Size = new Size(126, 25);
            label5.TabIndex = 64;
            label5.Text = "Academic Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 225);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 63;
            label4.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 225);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 62;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 138);
            label2.Name = "label2";
            label2.Size = new Size(28, 25);
            label2.TabIndex = 61;
            label2.Text = "Id";
            // 
            // StudentProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(589, 511);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(closeBtn);
            Controls.Add(updateBtn);
            Controls.Add(idBox);
            Controls.Add(lastNameBox);
            Controls.Add(firstNameBox);
            Controls.Add(degreeBox);
            Controls.Add(cohortBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentProfile";
            Load += StudentProfile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button closeBtn;
        public TextBox lastNameBox;
        public TextBox firstNameBox;
        public ComboBox degreeBox;
        public ComboBox cohortBox;
        public TextBox idBox;
        public Button updateBtn;
        private Panel panel1;
        private Label label1;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}