namespace LLModInspector
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPanel = new Panel();
            btn_info = new Button();
            btn_getModsPath = new Button();
            logoPanel = new Panel();
            movePanel = new Panel();
            btn_minimize = new Button();
            btn_close = new Button();
            label1 = new Label();
            modsListBox = new ListBox();
            btnPanel.SuspendLayout();
            movePanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnPanel
            // 
            btnPanel.Controls.Add(btn_info);
            btnPanel.Controls.Add(btn_getModsPath);
            btnPanel.Controls.Add(logoPanel);
            btnPanel.Dock = DockStyle.Left;
            btnPanel.Location = new Point(0, 0);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(200, 450);
            btnPanel.TabIndex = 0;
            // 
            // btn_info
            // 
            btn_info.Dock = DockStyle.Top;
            btn_info.FlatAppearance.BorderSize = 0;
            btn_info.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            btn_info.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btn_info.FlatStyle = FlatStyle.Flat;
            btn_info.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_info.Location = new Point(0, 160);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(200, 60);
            btn_info.TabIndex = 3;
            btn_info.Text = "Info";
            btn_info.UseVisualStyleBackColor = true;
            btn_info.Click += btn_info_Click;
            // 
            // btn_getModsPath
            // 
            btn_getModsPath.Dock = DockStyle.Top;
            btn_getModsPath.FlatAppearance.BorderSize = 0;
            btn_getModsPath.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            btn_getModsPath.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btn_getModsPath.FlatStyle = FlatStyle.Flat;
            btn_getModsPath.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_getModsPath.Location = new Point(0, 100);
            btn_getModsPath.Name = "btn_getModsPath";
            btn_getModsPath.Size = new Size(200, 60);
            btn_getModsPath.TabIndex = 1;
            btn_getModsPath.Text = "Set Mods Folder";
            btn_getModsPath.UseVisualStyleBackColor = true;
            btn_getModsPath.Click += btn_getModsPath_Click;
            // 
            // logoPanel
            // 
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(200, 100);
            logoPanel.TabIndex = 0;
            // 
            // movePanel
            // 
            movePanel.BackColor = SystemColors.ControlDark;
            movePanel.Controls.Add(btn_minimize);
            movePanel.Controls.Add(btn_close);
            movePanel.Dock = DockStyle.Top;
            movePanel.Location = new Point(200, 0);
            movePanel.Name = "movePanel";
            movePanel.Size = new Size(600, 100);
            movePanel.TabIndex = 1;
            movePanel.MouseDown += movePanel_MouseDown;
            movePanel.MouseMove += movePanel_MouseMove;
            // 
            // btn_minimize
            // 
            btn_minimize.BackColor = SystemColors.ControlDarkDark;
            btn_minimize.Dock = DockStyle.Right;
            btn_minimize.FlatAppearance.BorderSize = 0;
            btn_minimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btn_minimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.Font = new Font("Segoe UI", 40F);
            btn_minimize.Location = new Point(400, 0);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(100, 100);
            btn_minimize.TabIndex = 1;
            btn_minimize.Text = "-";
            btn_minimize.UseVisualStyleBackColor = false;
            btn_minimize.Click += minimizeButton_Click;
            // 
            // btn_close
            // 
            btn_close.BackColor = SystemColors.ControlDarkDark;
            btn_close.Dock = DockStyle.Right;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btn_close.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Segoe UI", 40F);
            btn_close.Location = new Point(500, 0);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(100, 100);
            btn_close.TabIndex = 0;
            btn_close.Text = "X";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F);
            label1.Location = new Point(416, 119);
            label1.Name = "label1";
            label1.Size = new Size(173, 22);
            label1.TabIndex = 3;
            label1.Text = "Current mods list:";
            // 
            // modsListBox
            // 
            modsListBox.BorderStyle = BorderStyle.None;
            modsListBox.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modsListBox.FormattingEnabled = true;
            modsListBox.HorizontalScrollbar = true;
            modsListBox.ItemHeight = 18;
            modsListBox.Location = new Point(200, 144);
            modsListBox.Name = "modsListBox";
            modsListBox.SelectionMode = SelectionMode.MultiSimple;
            modsListBox.Size = new Size(600, 288);
            modsListBox.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(modsListBox);
            Controls.Add(label1);
            Controls.Add(movePanel);
            Controls.Add(btnPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            btnPanel.ResumeLayout(false);
            movePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel btnPanel;
        private Button btn_getModsPath;
        private Panel logoPanel;
        private Panel movePanel;
        private Button btn_minimize;
        private Button btn_close;
        private Button btn_info;
        private Label label1;
        private ListBox modsListBox;
    }
}
