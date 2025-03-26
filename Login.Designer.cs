namespace Form_PIM
{
    partial class Login
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
            lbWelcome = new Label();
            lbLogin = new Label();
            lbPassword = new Label();
            btnCancel = new Button();
            btnConfirm = new Button();
            mtxtPassword = new MaskedTextBox();
            txtLogin = new MaskedTextBox();
            SuspendLayout();
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.BackColor = Color.Transparent;
            lbWelcome.Font = new Font("Broadway", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWelcome.ForeColor = SystemColors.Menu;
            lbWelcome.Location = new Point(167, 94);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(188, 24);
            lbWelcome.TabIndex = 0;
            lbWelcome.Text = "Bem Vindo(a)!";
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Arial", 12F);
            lbLogin.Location = new Point(127, 167);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(51, 18);
            lbLogin.TabIndex = 1;
            lbLogin.Text = "Login:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(127, 267);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 18);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Senha:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Location = new Point(127, 348);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(192, 192, 0);
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Location = new Point(264, 348);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(114, 29);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "CONFIRMAR";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click_1;
            // 
            // mtxtPassword
            // 
            mtxtPassword.Location = new Point(127, 288);
            mtxtPassword.Name = "mtxtPassword";
            mtxtPassword.PasswordChar = '*';
            mtxtPassword.Size = new Size(251, 26);
            mtxtPassword.TabIndex = 4;
            // 
            // txtLogin
            // 
            txtLogin.Cursor = Cursors.IBeam;
            txtLogin.Location = new Point(127, 188);
            txtLogin.Mask = "099999999999999";
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(251, 26);
            txtLogin.TabIndex = 2;
            txtLogin.ValidatingType = typeof(int);
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(505, 470);
            Controls.Add(txtLogin);
            Controls.Add(mtxtPassword);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(lbPassword);
            Controls.Add(lbLogin);
            Controls.Add(lbWelcome);
            Font = new Font("Arial", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(521, 509);
            MinimizeBox = false;
            MinimumSize = new Size(521, 509);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbWelcome;
        private Label lbLogin;
        private Label lbPassword;
        private Button btnCancel;
        private Button btnConfirm;
        private MaskedTextBox mtxtPassword;
        private MaskedTextBox txtLogin;
    }
}
