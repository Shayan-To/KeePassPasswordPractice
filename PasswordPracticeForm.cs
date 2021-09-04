using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

using KeePass.App;
using KeePass.UI;

using KeePassLib.Security;

namespace KeePassPasswordPractice
{
    public partial class PasswordPracticeForm : Form
    {
        public PasswordPracticeForm(ProtectedString password)
        {
            this.InitializeComponent();

            this._Password = password;

            this.PeekTextBox.UseSystemPasswordChar = false;
            this.PeekTextBox.TextEx = password;
            this.PeekTextBox.Select(password.Length, 0);
            this.Icon = AppIcons.Default;

            BannerFactory.CreateBannerEx(this, this.BannerImage, Properties.Resources.icon_48x48, "Password Practice", "Practice the password of the entry.");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                this.PeekButton.Checked ^= true;
                this.PeekTextBox.Focus();
                this.PasswordTextBox.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            this.PasswordTextBox.BackColor = this.CorrectPassword ? _GreenBack : SystemColors.Window;
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                this.PasswordAsteriskButton.Checked ^= true;
            }
        }

        private void PasswordAsteriskButton_CheckedChanged(object sender, EventArgs e)
        {
            this.PasswordTextBox.UseSystemPasswordChar = this.PasswordAsteriskButton.Checked;

            var selectionStart = this.PasswordTextBox.SelectionStart;
            var selectionLength = this.PasswordTextBox.SelectionLength;
            this.PasswordTextBox.TextEx = this.PasswordTextBox.TextEx;
            this.PasswordTextBox.Select(selectionStart, selectionLength);
        }

        private void PeekButton_CheckedChanged(object sender, EventArgs e)
        {
            this.PeekPanel.Visible = this.PeekButton.Checked;
            this.PasswordPanel.Visible = !this.PeekButton.Checked;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (!this.CorrectPassword)
            {
                SystemSounds.Exclamation.Play();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public ProtectedString EnteredPassword
        {
            get
            {
                return this.PasswordTextBox.TextEx;
            }
        }

        public bool CorrectPassword
        {
            get
            {
                return this.EnteredPassword.Equals(this._Password, false);
            }
        }

        private readonly ProtectedString _Password;

        private static readonly Color _GreenBack = Color.FromArgb(192, 255, 192);
    }
}
