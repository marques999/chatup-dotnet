using System;
using System.Windows.Forms;

namespace ChatupNET.Forms
{
    /// <summary>
    ///
    /// </summary>
    internal partial class PasswordForm : Form
    {
        /// <summary>
        ///
        /// </summary>
        public PasswordForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///
        /// </summary>
        public string Password => fieldPassword.Text;

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm() => !string.IsNullOrEmpty(fieldPassword.Text);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="argse"></param>
        private void ButtonCancel_Click(object sender, EventArgs argse)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ButtonConfirm_Click(object sender, EventArgs args)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void FieldPassword_TextChanged(object sender, EventArgs args)
        {
            buttonConfirm.Enabled = ValidateForm();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PasswordForm_Load(object sender, EventArgs args)
        {
            buttonConfirm.Enabled = ValidateForm();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void FieldPassword_KeyPress(object sender, KeyPressEventArgs args)
        {
            if (char.IsControl(args.KeyChar) == false && char.IsLetterOrDigit(args.KeyChar) == false)
            {
                args.Handled = true;
            }
        }
    }
}