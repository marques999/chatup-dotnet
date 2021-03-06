using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

using ChatupNET.Model;

namespace ChatupNET.Forms
{
    /// <summary>
    ///
    /// </summary>
    internal partial class AddressForm : Form
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="addressObject"></param>
        public AddressForm(Address addressObject)
        {
            InitializeComponent();
            ModalData = addressObject;
        }

        /// <summary>
        ///
        /// </summary>
        public Address ModalData
        {
            get;
            private set;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        private ushort ParsePort()
        {
            try
            {
                return Convert.ToUInt16(fieldPort.Text);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        private IPAddress ParseAddress()
        {
            try
            {
                return IPAddress.Parse(fieldAddress.Text);
            }
            catch
            {
                return IPAddress.Loopback;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            return string.IsNullOrWhiteSpace(fieldAddress.Text) == false && string.IsNullOrEmpty(fieldPort.Text) == false && ushort.TryParse(fieldPort.Text, out ushort inputPort);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="ipDigits"></param>
        /// <returns></returns>
        private static string ReadAddress(IReadOnlyList<byte> ipDigits)
        {
            return $"{ipDigits[0]:D}.{ipDigits[1]:D}.{ipDigits[2]:D}.{ipDigits[3]:D}";
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void RegisterForm_Load(object sender, EventArgs args)
        {
            fieldAddress.Text = ReadAddress(ModalData.Host.GetAddressBytes());
            fieldPort.Text = Convert.ToString(ModalData.Port);
            buttonConfirm.Enabled = ValidateForm();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ButtonConfirm_Click(object sender, EventArgs args)
        {
            ModalData = new Address(ParseAddress(), ParsePort());
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ButtonCancel_Click(object sender, EventArgs args)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void FieldName_TextChanged(object sender, EventArgs args)
        {
            buttonConfirm.Enabled = ValidateForm();
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
    }
}