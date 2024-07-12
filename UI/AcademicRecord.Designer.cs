using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentAdministrator.UI
{
    partial class AcademicRecord
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            moduleGrade = new TextBox();
            moduleScore = new TextBox();
            selectModule = new ComboBox();
            assessmentList = new ListView();
            assessmentId = new ColumnHeader();
            assessmentName = new ColumnHeader();
            markScored = new ColumnHeader();
            maxMark = new ColumnHeader();
            percentScored = new ColumnHeader();
            assessPercent = new ColumnHeader();
            tabPage2 = new TabPage();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            closeBtn = new Button();
            label6 = new Label();
            label7 = new Label();
            stdName = new TextBox();
            stdId = new TextBox();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(6, 176);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(737, 398);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DarkSlateGray;
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(moduleGrade);
            tabPage1.Controls.Add(moduleScore);
            tabPage1.Controls.Add(selectModule);
            tabPage1.Controls.Add(assessmentList);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(729, 360);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Assessment Record";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(494, 23);
            label5.Name = "label5";
            label5.Size = new Size(125, 25);
            label5.TabIndex = 22;
            label5.Text = "Module Grade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(267, 23);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 21;
            label4.Text = "Module Score";
            // 
            // moduleGrade
            // 
            moduleGrade.Enabled = false;
            moduleGrade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            moduleGrade.Location = new Point(494, 51);
            moduleGrade.Name = "moduleGrade";
            moduleGrade.PlaceholderText = "Module Grade";
            moduleGrade.Size = new Size(200, 39);
            moduleGrade.TabIndex = 18;
            moduleGrade.TextAlign = HorizontalAlignment.Center;
            // 
            // moduleScore
            // 
            moduleScore.Enabled = false;
            moduleScore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            moduleScore.Location = new Point(267, 51);
            moduleScore.Name = "moduleScore";
            moduleScore.PlaceholderText = "Module Score";
            moduleScore.Size = new Size(200, 39);
            moduleScore.TabIndex = 17;
            moduleScore.TextAlign = HorizontalAlignment.Center;
            // 
            // selectModule
            // 
            selectModule.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selectModule.FormattingEnabled = true;
            selectModule.Location = new Point(38, 50);
            selectModule.Name = "selectModule";
            selectModule.Size = new Size(200, 40);
            selectModule.TabIndex = 4;
            selectModule.Text = "Select Module";
            selectModule.SelectedIndexChanged += selectModule_SelectedIndexChanged;
            // 
            // assessmentList
            // 
            assessmentList.Columns.AddRange(new ColumnHeader[] { assessmentId, assessmentName, markScored, maxMark, percentScored, assessPercent });
            assessmentList.GridLines = true;
            assessmentList.Location = new Point(38, 122);
            assessmentList.Name = "assessmentList";
            assessmentList.Size = new Size(656, 218);
            assessmentList.TabIndex = 0;
            assessmentList.UseCompatibleStateImageBehavior = false;
            assessmentList.View = View.Details;
            // 
            // assessmentId
            // 
            assessmentId.Text = "Id";
            assessmentId.Width = 100;
            // 
            // assessmentName
            // 
            assessmentName.Text = "Name";
            assessmentName.Width = 150;
            // 
            // markScored
            // 
            markScored.Text = "Score";
            markScored.Width = 65;
            // 
            // maxMark
            // 
            maxMark.Text = "Max Score";
            maxMark.Width = 100;
            // 
            // percentScored
            // 
            percentScored.Text = "Score (%)";
            percentScored.Width = 95;
            // 
            // assessPercent
            // 
            assessPercent.Text = "Percantage (%)";
            assessPercent.Width = 140;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DarkSlateGray;
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(729, 360);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Program Record";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 205);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 21;
            label3.Text = "Program Grade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 76);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 20;
            label2.Text = "Program Score";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(240, 233);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Grade";
            textBox2.Size = new Size(246, 39);
            textBox2.TabIndex = 19;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(240, 119);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Program Score";
            textBox1.Size = new Size(246, 39);
            textBox1.TabIndex = 18;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(closeBtn);
            panel1.Location = new Point(6, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 68);
            panel1.TabIndex = 51;
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
            label1.Size = new Size(279, 45);
            label1.TabIndex = 0;
            label1.Text = "Academic Record";
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Red;
            closeBtn.Location = new Point(659, 7);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(71, 52);
            closeBtn.TabIndex = 46;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(320, 88);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 55;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 88);
            label7.Name = "label7";
            label7.Size = new Size(94, 25);
            label7.TabIndex = 54;
            label7.Text = "Student Id";
            // 
            // stdName
            // 
            stdName.Enabled = false;
            stdName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            stdName.Location = new Point(320, 116);
            stdName.Name = "stdName";
            stdName.PlaceholderText = "Name";
            stdName.Size = new Size(384, 39);
            stdName.TabIndex = 53;
            stdName.TextAlign = HorizontalAlignment.Center;
            // 
            // stdId
            // 
            stdId.Enabled = false;
            stdId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            stdId.Location = new Point(40, 116);
            stdId.Name = "stdId";
            stdId.PlaceholderText = "Student Id";
            stdId.Size = new Size(246, 39);
            stdId.TabIndex = 52;
            stdId.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 22);
            label8.Name = "label8";
            label8.Size = new Size(124, 25);
            label8.TabIndex = 23;
            label8.Text = "Select Module";
            // 
            // AcademicRecord
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(748, 581);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(stdName);
            Controls.Add(stdId);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "AcademicRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Academic Record";
            Load += AcademicRecord_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ColumnHeader assessmentId;
        private ColumnHeader assessmentName;
        private ColumnHeader markScored;
        private ColumnHeader maxMark;
        private ColumnHeader assessPercent;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button closeBtn;
        private ColumnHeader percentScored;
        public ComboBox selectModule;
        public TextBox moduleScore;
        public ListView assessmentList;
        public TextBox textBox2;
        public TextBox textBox1;
        public TextBox moduleGrade;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label7;
        public TextBox stdName;
        public TextBox stdId;
        private Label label8;
    }
}