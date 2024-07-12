namespace StudentAdministrator.UI
{
    partial class AssessmentRecord
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
            moduleBox = new ComboBox();
            stdIdBox = new TextBox();
            assessBox = new ComboBox();
            scoreBox = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            fNameBox = new TextBox();
            lNameBox = new TextBox();
            dProgramBox = new TextBox();
            cohortBox = new TextBox();
            searchBtn = new Button();
            updateBtn = new Button();
            assessList = new ListView();
            asssessId = new ColumnHeader();
            assessName = new ColumnHeader();
            moduleName = new ColumnHeader();
            score = new ColumnHeader();
            maxScore = new ColumnHeader();
            percentScored = new ColumnHeader();
            percentage = new ColumnHeader();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Red;
            closeBtn.Location = new Point(696, 9);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(71, 52);
            closeBtn.TabIndex = 46;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // moduleBox
            // 
            moduleBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            moduleBox.FormattingEnabled = true;
            moduleBox.Location = new Point(135, 362);
            moduleBox.Name = "moduleBox";
            moduleBox.Size = new Size(246, 40);
            moduleBox.TabIndex = 45;
            moduleBox.Text = "Select Module";
            moduleBox.SelectedIndexChanged += moduleBox_SelectedIndexChanged;
            // 
            // stdIdBox
            // 
            stdIdBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            stdIdBox.Location = new Point(135, 141);
            stdIdBox.Name = "stdIdBox";
            stdIdBox.PlaceholderText = "Student Id";
            stdIdBox.Size = new Size(246, 39);
            stdIdBox.TabIndex = 43;
            stdIdBox.TextAlign = HorizontalAlignment.Center;
            // 
            // assessBox
            // 
            assessBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            assessBox.FormattingEnabled = true;
            assessBox.Location = new Point(413, 362);
            assessBox.Name = "assessBox";
            assessBox.Size = new Size(246, 40);
            assessBox.TabIndex = 47;
            assessBox.Text = "Select Assessment";
            assessBox.SelectedIndexChanged += assessBox_SelectedIndexChanged;
            // 
            // scoreBox
            // 
            scoreBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            scoreBox.Location = new Point(135, 430);
            scoreBox.Name = "scoreBox";
            scoreBox.PlaceholderText = "Score";
            scoreBox.Size = new Size(124, 39);
            scoreBox.TabIndex = 48;
            scoreBox.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(closeBtn);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 68);
            panel1.TabIndex = 50;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(790, 14);
            button1.Name = "button1";
            button1.Size = new Size(115, 52);
            button1.TabIndex = 13;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1, 7);
            label1.Name = "label1";
            label1.Size = new Size(404, 45);
            label1.TabIndex = 0;
            label1.Text = "Student Academic Record";
            // 
            // fNameBox
            // 
            fNameBox.Enabled = false;
            fNameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fNameBox.Location = new Point(135, 217);
            fNameBox.Name = "fNameBox";
            fNameBox.PlaceholderText = "First Name";
            fNameBox.Size = new Size(246, 39);
            fNameBox.TabIndex = 52;
            fNameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // lNameBox
            // 
            lNameBox.Enabled = false;
            lNameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lNameBox.Location = new Point(413, 217);
            lNameBox.Name = "lNameBox";
            lNameBox.PlaceholderText = "Last Name";
            lNameBox.Size = new Size(246, 39);
            lNameBox.TabIndex = 53;
            lNameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // dProgramBox
            // 
            dProgramBox.Enabled = false;
            dProgramBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dProgramBox.Location = new Point(135, 289);
            dProgramBox.Name = "dProgramBox";
            dProgramBox.PlaceholderText = "Degree Program";
            dProgramBox.Size = new Size(246, 39);
            dProgramBox.TabIndex = 54;
            dProgramBox.TextAlign = HorizontalAlignment.Center;
            // 
            // cohortBox
            // 
            cohortBox.Enabled = false;
            cohortBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cohortBox.Location = new Point(413, 289);
            cohortBox.Name = "cohortBox";
            cohortBox.PlaceholderText = "Cohort";
            cohortBox.Size = new Size(246, 39);
            cohortBox.TabIndex = 55;
            cohortBox.TextAlign = HorizontalAlignment.Center;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.Goldenrod;
            searchBtn.Location = new Point(413, 141);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(246, 39);
            searchBtn.TabIndex = 57;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Green;
            updateBtn.Location = new Point(413, 430);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(246, 39);
            updateBtn.TabIndex = 56;
            updateBtn.Text = "Record";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // assessList
            // 
            assessList.Columns.AddRange(new ColumnHeader[] { asssessId, assessName, moduleName, score, maxScore, percentScored, percentage });
            assessList.Location = new Point(22, 496);
            assessList.Name = "assessList";
            assessList.Size = new Size(756, 367);
            assessList.TabIndex = 59;
            assessList.UseCompatibleStateImageBehavior = false;
            assessList.View = View.Details;
            // 
            // asssessId
            // 
            asssessId.Text = "Id";
            asssessId.Width = 80;
            // 
            // assessName
            // 
            assessName.Text = "Name";
            assessName.Width = 150;
            // 
            // moduleName
            // 
            moduleName.Text = "Module Code";
            moduleName.Width = 150;
            // 
            // score
            // 
            score.Text = "Score";
            score.Width = 100;
            // 
            // maxScore
            // 
            maxScore.Text = "Max Score";
            maxScore.Width = 100;
            // 
            // percentScored
            // 
            percentScored.Text = "Score (%)";
            percentScored.Width = 100;
            // 
            // percentage
            // 
            percentage.Text = "Percentage (%)";
            percentage.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 113);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 60;
            label2.Text = "Student Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 334);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 61;
            label3.Text = "Select Module";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 334);
            label4.Name = "label4";
            label4.Size = new Size(157, 25);
            label4.TabIndex = 62;
            label4.Text = "Select Assessment";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(276, 433);
            label5.Name = "label5";
            label5.Size = new Size(59, 32);
            label5.TabIndex = 63;
            label5.Text = "Max";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(135, 189);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 64;
            label6.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(413, 189);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 65;
            label7.Text = "Last Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(135, 259);
            label8.Name = "label8";
            label8.Size = new Size(143, 25);
            label8.TabIndex = 66;
            label8.Text = "Degree Program";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(413, 261);
            label9.Name = "label9";
            label9.Size = new Size(104, 25);
            label9.TabIndex = 67;
            label9.Text = "Cohort Year";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(135, 402);
            label10.Name = "label10";
            label10.Size = new Size(56, 25);
            label10.TabIndex = 68;
            label10.Text = "Score";
            // 
            // AssessmentRecord
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 886);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(assessList);
            Controls.Add(searchBtn);
            Controls.Add(updateBtn);
            Controls.Add(cohortBox);
            Controls.Add(dProgramBox);
            Controls.Add(lNameBox);
            Controls.Add(fNameBox);
            Controls.Add(panel1);
            Controls.Add(scoreBox);
            Controls.Add(assessBox);
            Controls.Add(moduleBox);
            Controls.Add(stdIdBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AssessmentRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssessmentRecord";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeBtn;
        private ComboBox moduleBox;
        private TextBox stdIdBox;
        private ComboBox assessBox;
        private TextBox scoreBox;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private TextBox fNameBox;
        private TextBox lNameBox;
        private TextBox dProgramBox;
        private TextBox cohortBox;
        private Button searchBtn;
        private Button updateBtn;
        private ListView assessList;
        private ColumnHeader asssessId;
        private ColumnHeader assessName;
        private ColumnHeader moduleName;
        private ColumnHeader score;
        private ColumnHeader maxScore;
        private ColumnHeader percentScored;
        private ColumnHeader percentage;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}