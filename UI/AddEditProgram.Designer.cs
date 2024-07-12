namespace StudentAdministrator.UI
{
    partial class AddEditProgram
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
            titleBox = new TextBox();
            idBox = new TextBox();
            closeBtn = new Button();
            panel1 = new Panel();
            label1 = new Label();
            updateBtn = new Button();
            durationBox = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // titleBox
            // 
            titleBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleBox.Location = new Point(42, 205);
            titleBox.Name = "titleBox";
            titleBox.PlaceholderText = "Title";
            titleBox.Size = new Size(246, 39);
            titleBox.TabIndex = 53;
            titleBox.TextAlign = HorizontalAlignment.Center;
            // 
            // idBox
            // 
            idBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idBox.Location = new Point(42, 128);
            idBox.Name = "idBox";
            idBox.PlaceholderText = "Id";
            idBox.ReadOnly = true;
            idBox.Size = new Size(246, 39);
            idBox.TabIndex = 52;
            idBox.TextAlign = HorizontalAlignment.Center;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Red;
            closeBtn.Location = new Point(316, 273);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(246, 52);
            closeBtn.TabIndex = 51;
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
            panel1.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(126, 12);
            label1.Name = "label1";
            label1.Size = new Size(336, 54);
            label1.TabIndex = 0;
            label1.Text = "Degree Program";
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.SeaGreen;
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(42, 273);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(246, 52);
            updateBtn.TabIndex = 49;
            updateBtn.Text = "Create";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // durationBox
            // 
            durationBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            durationBox.Location = new Point(316, 205);
            durationBox.Name = "durationBox";
            durationBox.PlaceholderText = "Duration";
            durationBox.Size = new Size(246, 39);
            durationBox.TabIndex = 54;
            durationBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 100);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 59;
            label5.Text = "Program Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 177);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 60;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 177);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 61;
            label3.Text = "Duration";
            // 
            // AddEditProgram
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(607, 361);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(durationBox);
            Controls.Add(titleBox);
            Controls.Add(idBox);
            Controls.Add(closeBtn);
            Controls.Add(panel1);
            Controls.Add(updateBtn);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEditProgram";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DegreeProgram";
            Load += AddEditProgram_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button closeBtn;
        private Panel panel1;
        private Label label1;
        public TextBox titleBox;
        public TextBox idBox;
        public TextBox durationBox;
        public Button updateBtn;
        private Label label5;
        private Label label2;
        private Label label3;
    }
}