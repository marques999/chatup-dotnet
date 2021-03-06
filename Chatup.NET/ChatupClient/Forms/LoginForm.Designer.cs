using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using ChatupNET.Properties;

namespace ChatupNET.Forms
{
    /// <summary>
    ///
    /// </summary>
    internal partial class LoginForm
    {
        /// <summary>
        ///
        /// </summary>
        private IContainer components = null;

        /// <summary>
        ///
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        /// <summary>
        ///
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(LoginForm));
            labelPassword = new Label();
            labelUsername = new Label();
            fieldPassword = new TextBox();
            fieldUsername = new TextBox();
            buttonRegister = new Button();
            buttonValidate = new Button();
            buttonConfigure = new Button();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((ISupportInitialize)(pictureBox1)).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            //
            // pictureBox1
            //
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = ((Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabStop = false;
            //
            // tableLayoutPanel2
            //
            tableLayoutPanel2.BackColor = SystemColors.ControlDark;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonConfigure, 1, 0);
            tableLayoutPanel2.Controls.Add(buttonValidate, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 414);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(4);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(285, 40);
            //
            // buttonConfigure
            //
            buttonConfigure.BackColor = SystemColors.Control;
            buttonConfigure.Dock = DockStyle.Fill;
            buttonConfigure.FlatAppearance.BorderColor = SystemColors.ControlDark;
            buttonConfigure.FlatStyle = FlatStyle.Flat;
            buttonConfigure.Location = new Point(145, 7);
            buttonConfigure.Name = "buttonConfigure";
            buttonConfigure.Size = new Size(133, 26);
            buttonConfigure.TabIndex = 4;
            buttonConfigure.Text = "Configure";
            buttonConfigure.UseVisualStyleBackColor = false;
            buttonConfigure.Click += new EventHandler(ButtonConfigure_Click);
            //
            // buttonValidate
            //
            buttonValidate.BackColor = SystemColors.Control;
            buttonValidate.Dock = DockStyle.Fill;
            buttonValidate.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonValidate.FlatStyle = FlatStyle.Flat;
            buttonValidate.Location = new Point(7, 7);
            buttonValidate.Name = "buttonValidate";
            buttonValidate.Size = new Size(132, 26);
            buttonValidate.TabIndex = 2;
            buttonValidate.Text = "Validate";
            buttonValidate.UseVisualStyleBackColor = false;
            buttonValidate.Click += new EventHandler(ButtonValidate_Click);
            //
            // tableLayoutPanel1
            //
            tableLayoutPanel1.BackColor = SystemColors.ControlLight;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelUsername, 0, 0);
            tableLayoutPanel1.Controls.Add(fieldUsername, 0, 1);
            tableLayoutPanel1.Controls.Add(labelPassword, 0, 2);
            tableLayoutPanel1.Controls.Add(fieldPassword, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonRegister, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 242);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.625F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.375F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(285, 172);
            //
            // labelUsername
            //
            labelUsername.AutoSize = true;
            labelUsername.BorderStyle = BorderStyle.FixedSingle;
            labelUsername.Dock = DockStyle.Fill;
            labelUsername.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(8, 0);
            labelUsername.Margin = new Padding(8, 0, 8, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(269, 26);
            labelUsername.Text = "Username";
            labelUsername.TextAlign = ContentAlignment.MiddleCenter;
            //
            // fieldUsername
            //
            fieldUsername.Dock = DockStyle.Fill;
            fieldUsername.Location = new Point(8, 34);
            fieldUsername.Margin = new Padding(8);
            fieldUsername.Name = "fieldUsername";
            fieldUsername.Size = new Size(269, 20);
            fieldUsername.TabIndex = 0;
            fieldUsername.Text = "marques999";
            fieldUsername.TextChanged += new EventHandler(FieldUsername_TextChanged);
            fieldUsername.KeyPress += new KeyPressEventHandler(FieldUsername_KeyPress);
            //
            // label2
            //
            labelPassword.AutoSize = true;
            labelPassword.BorderStyle = BorderStyle.FixedSingle;
            labelPassword.Dock = DockStyle.Fill;
            labelPassword.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(8, 64);
            labelPassword.Margin = new Padding(8, 0, 8, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(269, 26);
            labelPassword.Text = "Password";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            //
            // fieldPassword
            //
            fieldPassword.Dock = DockStyle.Fill;
            fieldPassword.Location = new Point(8, 98);
            fieldPassword.Margin = new Padding(8);
            fieldPassword.Name = "fieldPassword";
            fieldPassword.PasswordChar = '*';
            fieldPassword.Size = new Size(269, 20);
            fieldPassword.TabIndex = 1;
            fieldPassword.Text = "14191091";
            fieldPassword.TextChanged += new EventHandler(FieldPassword_TextChanged);
            fieldPassword.KeyPress += new KeyPressEventHandler(FieldPassword_KeyPress);
            //
            // buttonRegister
            //
            buttonRegister.BackColor = SystemColors.ActiveBorder;
            buttonRegister.Dock = DockStyle.Fill;
            buttonRegister.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Location = new Point(64, 133);
            buttonRegister.Margin = new Padding(64, 8, 64, 16);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(157, 23);
            buttonRegister.TabIndex = 3;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += new EventHandler(ButtonRegister_Click);
            //
            // LoginForm
            //
            AcceptButton = buttonValidate;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 454);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Icon = Resources.chatup;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authentication";
            Load += new EventHandler(LoginForm_Load);
            ((ISupportInitialize)(pictureBox1)).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private Label labelPassword;
        private Label labelUsername;
        private TextBox fieldPassword;
        private TextBox fieldUsername;
        private Button buttonRegister;
        private Button buttonValidate;
        private Button buttonConfigure;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}