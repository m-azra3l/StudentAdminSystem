namespace StudentAdministrator.UI
{
    partial class AdminForm
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
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            minimizeToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            viewMenu = new ToolStripMenuItem();
            degreeProgramToolStripMenuItem1 = new ToolStripMenuItem();
            cohortToolStripMenuItem1 = new ToolStripMenuItem();
            assessmentsToolStripMenuItem = new ToolStripMenuItem();
            modulesToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem1 = new ToolStripMenuItem();
            studentListToolStripMenuItem = new ToolStripMenuItem();
            assessmentRecordToolStripMenuItem = new ToolStripMenuItem();
            windowsMenu = new ToolStripMenuItem();
            closeAllToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, viewMenu, windowsMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.MdiWindowListItem = windowsMenu;
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(10, 4, 0, 4);
            menuStrip.Size = new Size(1053, 44);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { minimizeToolStripMenuItem, exitToolStripMenuItem });
            fileMenu.ImageTransparentColor = SystemColors.ActiveBorder;
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(67, 36);
            fileMenu.Text = "&File";
            // 
            // minimizeToolStripMenuItem
            // 
            minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            minimizeToolStripMenuItem.Size = new Size(217, 40);
            minimizeToolStripMenuItem.Text = "&Minimize";
            minimizeToolStripMenuItem.Click += minimizeToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(217, 40);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += ExitToolsStripMenuItem_Click;
            // 
            // viewMenu
            // 
            viewMenu.DropDownItems.AddRange(new ToolStripItem[] { degreeProgramToolStripMenuItem1, cohortToolStripMenuItem1, assessmentsToolStripMenuItem, modulesToolStripMenuItem, studentToolStripMenuItem1 });
            viewMenu.Name = "viewMenu";
            viewMenu.Size = new Size(81, 36);
            viewMenu.Text = "&View";
            // 
            // degreeProgramToolStripMenuItem1
            // 
            degreeProgramToolStripMenuItem1.Name = "degreeProgramToolStripMenuItem1";
            degreeProgramToolStripMenuItem1.Size = new Size(303, 40);
            degreeProgramToolStripMenuItem1.Text = "Degree Programs";
            degreeProgramToolStripMenuItem1.Click += degreeProgramToolStripMenuItem1_Click;
            // 
            // cohortToolStripMenuItem1
            // 
            cohortToolStripMenuItem1.Name = "cohortToolStripMenuItem1";
            cohortToolStripMenuItem1.Size = new Size(303, 40);
            cohortToolStripMenuItem1.Text = "Cohorts";
            cohortToolStripMenuItem1.Click += cohortToolStripMenuItem1_Click;
            // 
            // assessmentsToolStripMenuItem
            // 
            assessmentsToolStripMenuItem.Name = "assessmentsToolStripMenuItem";
            assessmentsToolStripMenuItem.Size = new Size(303, 40);
            assessmentsToolStripMenuItem.Text = "Assessments";
            assessmentsToolStripMenuItem.Click += assessmentsToolStripMenuItem_Click;
            // 
            // modulesToolStripMenuItem
            // 
            modulesToolStripMenuItem.Name = "modulesToolStripMenuItem";
            modulesToolStripMenuItem.Size = new Size(303, 40);
            modulesToolStripMenuItem.Text = "Modules";
            modulesToolStripMenuItem.Click += modulesToolStripMenuItem_Click;
            // 
            // studentToolStripMenuItem1
            // 
            studentToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { studentListToolStripMenuItem, assessmentRecordToolStripMenuItem });
            studentToolStripMenuItem1.Name = "studentToolStripMenuItem1";
            studentToolStripMenuItem1.Size = new Size(303, 40);
            studentToolStripMenuItem1.Text = "Students";
            // 
            // studentListToolStripMenuItem
            // 
            studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            studentListToolStripMenuItem.Size = new Size(322, 40);
            studentListToolStripMenuItem.Text = "Student List";
            studentListToolStripMenuItem.Click += studentListToolStripMenuItem_Click;
            // 
            // assessmentRecordToolStripMenuItem
            // 
            assessmentRecordToolStripMenuItem.Name = "assessmentRecordToolStripMenuItem";
            assessmentRecordToolStripMenuItem.Size = new Size(322, 40);
            assessmentRecordToolStripMenuItem.Text = "Assessment Record";
            assessmentRecordToolStripMenuItem.Click += assessmentRecordToolStripMenuItem_Click;
            // 
            // windowsMenu
            // 
            windowsMenu.DropDownItems.AddRange(new ToolStripItem[] { closeAllToolStripMenuItem });
            windowsMenu.Name = "windowsMenu";
            windowsMenu.Size = new Size(127, 36);
            windowsMenu.Text = "&Windows";
            // 
            // closeAllToolStripMenuItem
            // 
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.Size = new Size(210, 40);
            closeAllToolStripMenuItem.Text = "C&lose All";
            closeAllToolStripMenuItem.Click += CloseAllToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip.Location = new Point(0, 788);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(2, 0, 23, 0);
            statusStrip.Size = new Size(1053, 32);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(179, 25);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1053, 820);
            ControlBox = false;
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Admin System - Admin Panel";
            WindowState = FormWindowState.Maximized;
            Load += AdminForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem studentToolStripMenuItem1;
        private ToolStripMenuItem cohortToolStripMenuItem1;
        private ToolStripMenuItem degreeProgramToolStripMenuItem1;
        private ToolStripMenuItem modulesToolStripMenuItem;
        private ToolStripMenuItem assessmentsToolStripMenuItem;
        private ToolStripMenuItem studentListToolStripMenuItem;
        private ToolStripMenuItem assessmentRecordToolStripMenuItem;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem minimizeToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}



