namespace KeePassPasswordPractice
{
    partial class PasswordPracticeForm
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
            this.components = new System.ComponentModel.Container();
            this.OkButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new KeePass.UI.SecureTextBoxEx();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.PasswordAsteriskButton = new System.Windows.Forms.CheckBox();
            this._CancelButton = new System.Windows.Forms.Button();
            this.PeekPanel = new System.Windows.Forms.Panel();
            this.PeekTextBox = new KeePass.UI.SecureTextBoxEx();
            this.PeekLabel = new System.Windows.Forms.Label();
            this.PeekButton = new System.Windows.Forms.CheckBox();
            this.BannerImage = new System.Windows.Forms.PictureBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PasswordPanel.SuspendLayout();
            this.PeekPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(162, 98);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(80, 24);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.Location = new System.Drawing.Point(65, 3);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(210, 20);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.PasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(3, 6);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordPanel.Controls.Add(this.PasswordAsteriskButton);
            this.PasswordPanel.Controls.Add(this.PasswordTextBox);
            this.PasswordPanel.Controls.Add(this.PasswordLabel);
            this.PasswordPanel.Location = new System.Drawing.Point(12, 66);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(316, 26);
            this.PasswordPanel.TabIndex = 0;
            // 
            // PasswordAsteriskButton
            // 
            this.PasswordAsteriskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordAsteriskButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.PasswordAsteriskButton.Checked = true;
            this.PasswordAsteriskButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PasswordAsteriskButton.Image = global::KeePassPasswordPractice.Properties.Resources.dots;
            this.PasswordAsteriskButton.Location = new System.Drawing.Point(281, 3);
            this.PasswordAsteriskButton.Name = "PasswordAsteriskButton";
            this.PasswordAsteriskButton.Size = new System.Drawing.Size(32, 20);
            this.PasswordAsteriskButton.TabIndex = 2;
            this.PasswordAsteriskButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToolTip.SetToolTip(this.PasswordAsteriskButton, "Show/hide password using asterisks (F2)");
            this.PasswordAsteriskButton.UseVisualStyleBackColor = true;
            this.PasswordAsteriskButton.CheckedChanged += new System.EventHandler(this.PasswordAsteriskButton_CheckedChanged);
            // 
            // _CancelButton
            // 
            this._CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._CancelButton.Location = new System.Drawing.Point(248, 98);
            this._CancelButton.Name = "_CancelButton";
            this._CancelButton.Size = new System.Drawing.Size(80, 24);
            this._CancelButton.TabIndex = 3;
            this._CancelButton.Text = "Cancel";
            this._CancelButton.UseVisualStyleBackColor = true;
            // 
            // PeekPanel
            // 
            this.PeekPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PeekPanel.Controls.Add(this.PeekTextBox);
            this.PeekPanel.Controls.Add(this.PeekLabel);
            this.PeekPanel.Location = new System.Drawing.Point(12, 66);
            this.PeekPanel.Name = "PeekPanel";
            this.PeekPanel.Size = new System.Drawing.Size(316, 26);
            this.PeekPanel.TabIndex = 1;
            this.PeekPanel.Visible = false;
            // 
            // PeekTextBox
            // 
            this.PeekTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PeekTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PeekTextBox.Location = new System.Drawing.Point(65, 3);
            this.PeekTextBox.Name = "PeekTextBox";
            this.PeekTextBox.ReadOnly = true;
            this.PeekTextBox.Size = new System.Drawing.Size(248, 20);
            this.PeekTextBox.TabIndex = 1;
            // 
            // PeekLabel
            // 
            this.PeekLabel.AutoSize = true;
            this.PeekLabel.Location = new System.Drawing.Point(3, 6);
            this.PeekLabel.Name = "PeekLabel";
            this.PeekLabel.Size = new System.Drawing.Size(35, 13);
            this.PeekLabel.TabIndex = 0;
            this.PeekLabel.Text = "Peek:";
            // 
            // PeekButton
            // 
            this.PeekButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PeekButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.PeekButton.Image = global::KeePassPasswordPractice.Properties.Resources.help;
            this.PeekButton.Location = new System.Drawing.Point(12, 98);
            this.PeekButton.Name = "PeekButton";
            this.PeekButton.Size = new System.Drawing.Size(24, 24);
            this.PeekButton.TabIndex = 4;
            this.PeekButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToolTip.SetToolTip(this.PeekButton, "Peek (F1)");
            this.PeekButton.UseVisualStyleBackColor = true;
            this.PeekButton.CheckedChanged += new System.EventHandler(this.PeekButton_CheckedChanged);
            // 
            // BannerImage
            // 
            this.BannerImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.BannerImage.Location = new System.Drawing.Point(0, 0);
            this.BannerImage.Name = "BannerImage";
            this.BannerImage.Size = new System.Drawing.Size(340, 60);
            this.BannerImage.TabIndex = 17;
            this.BannerImage.TabStop = false;
            // 
            // PasswordPracticeForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._CancelButton;
            this.ClientSize = new System.Drawing.Size(340, 134);
            this.Controls.Add(this.PeekButton);
            this.Controls.Add(this._CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.BannerImage);
            this.Controls.Add(this.PasswordPanel);
            this.Controls.Add(this.PeekPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordPracticeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password Practice";
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.PeekPanel.ResumeLayout(false);
            this.PeekPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannerImage)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.PictureBox BannerImage;
        private System.Windows.Forms.Button OkButton;
        private KeePass.UI.SecureTextBoxEx PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.Button _CancelButton;
        private System.Windows.Forms.Panel PeekPanel;
        private KeePass.UI.SecureTextBoxEx PeekTextBox;
        private System.Windows.Forms.Label PeekLabel;
        private System.Windows.Forms.CheckBox PeekButton;
        private System.Windows.Forms.CheckBox PasswordAsteriskButton;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}