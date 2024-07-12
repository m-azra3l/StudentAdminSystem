namespace StudentAdministrator.UI
{
    partial class AddEditModule
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
            programBox = new ComboBox();
            idBox = new TextBox();
            closeBtn = new Button();
            updateBtn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            optionCheck = new CheckBox();
            titleBox = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // programBox
            // 
            programBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            programBox.FormattingEnabled = true;
            programBox.Location = new Point(317, 216);
            programBox.Name = "programBox";
            programBox.Size = new Size(246, 40);
            programBox.TabIndex = 49;
            programBox.Text = "Select Program";
            // 
            // idBox
            // 
            idBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idBox.Location = new Point(43, 142);
            idBox.Name = "idBox";
            idBox.PlaceholderText = "Module Code";
            idBox.ReadOnly = true;
            idBox.Size = new Size(246, 39);
            idBox.TabIndex = 54;
            idBox.TextAlign = HorizontalAlignment.Center;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Red;
            closeBtn.Location = new Point(317, 310);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(246, 52);
            closeBtn.TabIndex = 53;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.SeaGreen;
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(43, 310);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(246, 52);
            updateBtn.TabIndex = 51;
            updateBtn.Text = "Create";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(215, 12);
            label1.Name = "label1";
            label1.Size = new Size(167, 54);
            label1.TabIndex = 0;
            label1.Text = "Module";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 79);
            panel1.TabIndex = 52;
            // 
            // optionCheck
            // 
            optionCheck.AutoSize = true;
            optionCheck.Location = new Point(242, 269);
            optionCheck.Name = "optionCheck";
            optionCheck.Size = new Size(107, 29);
            optionCheck.TabIndex = 57;
            optionCheck.Text = "Optional";
            optionCheck.UseVisualStyleBackColor = true;
            // 
            // titleBox
            // 
            titleBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleBox.Location = new Point(43, 217);
            titleBox.Name = "titleBox";
            titleBox.PlaceholderText = "Title";
            titleBox.Size = new Size(246, 39);
            titleBox.TabIndex = 59;
            titleBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 114);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 60;
            label5.Text = "Module Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 189);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 61;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 188);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 62;
            label3.Text = "Select Program";
            // 
            // AddEditModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(608, 400);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(titleBox);
            Controls.Add(optionCheck);
            Controls.Add(idBox);
            Controls.Add(closeBtn);
            Controls.Add(updateBtn);
            Controls.Add(panel1);
            Controls.Add(programBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEditModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Module";
            Load += AddEditModule_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button closeBtn;
        private Label label1;
        private Panel panel1;
        public ComboBox programBox;
        public TextBox idBox;
        public Button updateBtn;
        public CheckBox optionCheck;
        public TextBox titleBox;
        private Label label5;
        private Label label2;
        private Label label3;
    }
}