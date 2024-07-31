namespace ModInspector_for_Legacy_Launcher
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
            button1 = new Button();
            logoPanel = new Panel();
            movePanel = new Panel();
            minimizeButton = new Button();
            closeButton = new Button();
            btnPanel.SuspendLayout();
            movePanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnPanel
            // 
            btnPanel.Controls.Add(button1);
            btnPanel.Controls.Add(logoPanel);
            btnPanel.Dock = DockStyle.Left;
            btnPanel.Location = new Point(0, 0);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(200, 450);
            btnPanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 100);
            button1.Name = "button1";
            button1.Size = new Size(200, 60);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
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
            movePanel.Controls.Add(minimizeButton);
            movePanel.Controls.Add(closeButton);
            movePanel.Dock = DockStyle.Top;
            movePanel.Location = new Point(200, 0);
            movePanel.Name = "movePanel";
            movePanel.Size = new Size(600, 100);
            movePanel.TabIndex = 1;
            movePanel.MouseDown += movePanel_MouseDown;
            movePanel.MouseMove += movePanel_MouseMove;
            // 
            // minimizeButton
            // 
            minimizeButton.BackColor = SystemColors.ControlDarkDark;
            minimizeButton.Dock = DockStyle.Right;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            minimizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Font = new Font("Segoe UI", 40F);
            minimizeButton.Location = new Point(400, 0);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(100, 100);
            minimizeButton.TabIndex = 1;
            minimizeButton.Text = "-";
            minimizeButton.UseVisualStyleBackColor = false;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = SystemColors.ControlDarkDark;
            closeButton.Dock = DockStyle.Right;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            closeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe UI", 40F);
            closeButton.Location = new Point(500, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(100, 100);
            closeButton.TabIndex = 0;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(movePanel);
            Controls.Add(btnPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            btnPanel.ResumeLayout(false);
            movePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel btnPanel;
        private Button button1;
        private Panel logoPanel;
        private Panel movePanel;
        private Button minimizeButton;
        private Button closeButton;
    }
}
