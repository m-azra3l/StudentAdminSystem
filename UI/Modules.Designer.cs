namespace StudentAdministrator.UI
{
    partial class Modules
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
            listView1 = new ListView();
            moduleId = new ColumnHeader();
            moduleTitle = new ColumnHeader();
            programId = new ColumnHeader();
            optional = new ColumnHeader();
            groupBox1 = new GroupBox();
            refreshBtn = new Button();
            searchBtn = new Button();
            createBtn = new Button();
            panel1 = new Panel();
            closeBtn = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { moduleId, moduleTitle, programId, optional });
            listView1.Location = new Point(12, 215);
            listView1.Name = "listView1";
            listView1.Size = new Size(923, 337);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // moduleId
            // 
            moduleId.Text = "Code";
            moduleId.Width = 200;
            // 
            // moduleTitle
            // 
            moduleTitle.Text = "Title";
            moduleTitle.Width = 300;
            // 
            // programId
            // 
            programId.Text = "Program Id";
            programId.Width = 300;
            // 
            // optional
            // 
            optional.Text = "Optional";
            optional.Width = 110;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(refreshBtn);
            groupBox1.Controls.Add(searchBtn);
            groupBox1.Controls.Add(createBtn);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(923, 106);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actions";
            // 
            // refreshBtn
            // 
            refreshBtn.BackColor = Color.Gray;
            refreshBtn.Location = new Point(614, 33);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(115, 52);
            refreshBtn.TabIndex = 19;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.Goldenrod;
            searchBtn.Location = new Point(405, 33);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(115, 52);
            searchBtn.TabIndex = 17;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // createBtn
            // 
            createBtn.BackColor = Color.SteelBlue;
            createBtn.Location = new Point(191, 33);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(115, 52);
            createBtn.TabIndex = 14;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click += createBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 79);
            panel1.TabIndex = 2;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Red;
            closeBtn.Location = new Point(831, 14);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(71, 52);
            closeBtn.TabIndex = 13;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 22);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 0;
            label1.Text = "Modules";
            // 
            // Modules
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(947, 564);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Modules";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modules";
            Load += Modules_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private GroupBox groupBox1;
        private Panel panel1;
        private Label label1;
        private Button closeBtn;
        private Button createBtn;
        private Button searchBtn;
        private ColumnHeader moduleId;
        private ColumnHeader moduleTitle;
        private ColumnHeader programId;
        private ColumnHeader optional;
        private Button refreshBtn;
    }
}