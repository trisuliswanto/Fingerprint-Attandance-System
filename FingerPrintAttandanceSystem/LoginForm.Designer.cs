namespace FingerPrintAttandanceSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.AdminPictureBox2 = new System.Windows.Forms.PictureBox();
            this.LinkLabel2 = new System.Windows.Forms.LinkLabel();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.AdminLabel2 = new System.Windows.Forms.Label();
            this.AdminLabel1 = new System.Windows.Forms.Label();
            this.CmdAdminLogin = new System.Windows.Forms.Button();
            this.TxtAdminPassword = new System.Windows.Forms.TextBox();
            this.TxtAdminUserName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminPictureBox2
            // 
            this.AdminPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("AdminPictureBox2.Image")));
            this.AdminPictureBox2.Location = new System.Drawing.Point(13, 40);
            this.AdminPictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.AdminPictureBox2.Name = "AdminPictureBox2";
            this.AdminPictureBox2.Size = new System.Drawing.Size(132, 139);
            this.AdminPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AdminPictureBox2.TabIndex = 20;
            this.AdminPictureBox2.TabStop = false;
            // 
            // LinkLabel2
            // 
            this.LinkLabel2.AutoSize = true;
            this.LinkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LinkLabel2.LinkColor = System.Drawing.Color.RoyalBlue;
            this.LinkLabel2.Location = new System.Drawing.Point(20, 9);
            this.LinkLabel2.Name = "LinkLabel2";
            this.LinkLabel2.Size = new System.Drawing.Size(125, 27);
            this.LinkLabel2.TabIndex = 19;
            this.LinkLabel2.TabStop = true;
            this.LinkLabel2.Text = "Login Admin";
            this.LinkLabel2.Visible = false;
            this.LinkLabel2.VisitedLinkColor = System.Drawing.Color.Navy;
            // 
            // CmdCancel
            // 
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("CmdCancel.Image")));
            this.CmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCancel.Location = new System.Drawing.Point(284, 139);
            this.CmdCancel.Margin = new System.Windows.Forms.Padding(4);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(97, 40);
            this.CmdCancel.TabIndex = 3;
            this.CmdCancel.Text = "   &Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // AdminLabel2
            // 
            this.AdminLabel2.AutoSize = true;
            this.AdminLabel2.BackColor = System.Drawing.Color.Transparent;
            this.AdminLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel2.ForeColor = System.Drawing.Color.White;
            this.AdminLabel2.Location = new System.Drawing.Point(182, 73);
            this.AdminLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminLabel2.Name = "AdminLabel2";
            this.AdminLabel2.Size = new System.Drawing.Size(79, 19);
            this.AdminLabel2.TabIndex = 16;
            this.AdminLabel2.Text = "Password :";
            // 
            // AdminLabel1
            // 
            this.AdminLabel1.AutoSize = true;
            this.AdminLabel1.BackColor = System.Drawing.Color.Transparent;
            this.AdminLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel1.ForeColor = System.Drawing.Color.White;
            this.AdminLabel1.Location = new System.Drawing.Point(182, 21);
            this.AdminLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminLabel1.Name = "AdminLabel1";
            this.AdminLabel1.Size = new System.Drawing.Size(89, 19);
            this.AdminLabel1.TabIndex = 15;
            this.AdminLabel1.Text = "User Name :";
            // 
            // CmdAdminLogin
            // 
            this.CmdAdminLogin.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAdminLogin.ForeColor = System.Drawing.Color.Black;
            this.CmdAdminLogin.Image = ((System.Drawing.Image)(resources.GetObject("CmdAdminLogin.Image")));
            this.CmdAdminLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdAdminLogin.Location = new System.Drawing.Point(183, 139);
            this.CmdAdminLogin.Margin = new System.Windows.Forms.Padding(4);
            this.CmdAdminLogin.Name = "CmdAdminLogin";
            this.CmdAdminLogin.Size = new System.Drawing.Size(97, 40);
            this.CmdAdminLogin.TabIndex = 2;
            this.CmdAdminLogin.Text = "    &Login";
            this.CmdAdminLogin.UseVisualStyleBackColor = true;
            this.CmdAdminLogin.Click += new System.EventHandler(this.CmdAdminLogin_Click);
            // 
            // TxtAdminPassword
            // 
            this.TxtAdminPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdminPassword.Location = new System.Drawing.Point(183, 95);
            this.TxtAdminPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAdminPassword.Name = "TxtAdminPassword";
            this.TxtAdminPassword.PasswordChar = '*';
            this.TxtAdminPassword.Size = new System.Drawing.Size(200, 23);
            this.TxtAdminPassword.TabIndex = 1;
            // 
            // TxtAdminUserName
            // 
            this.TxtAdminUserName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdminUserName.Location = new System.Drawing.Point(183, 42);
            this.TxtAdminUserName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAdminUserName.Name = "TxtAdminUserName";
            this.TxtAdminUserName.Size = new System.Drawing.Size(200, 23);
            this.TxtAdminUserName.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(395, 196);
            this.Controls.Add(this.AdminPictureBox2);
            this.Controls.Add(this.LinkLabel2);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.TxtAdminUserName);
            this.Controls.Add(this.AdminLabel2);
            this.Controls.Add(this.TxtAdminPassword);
            this.Controls.Add(this.AdminLabel1);
            this.Controls.Add(this.CmdAdminLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.AdminPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.PictureBox AdminPictureBox2;
        private System.Windows.Forms.LinkLabel LinkLabel2;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Label AdminLabel2;
        internal System.Windows.Forms.Label AdminLabel1;
        internal System.Windows.Forms.Button CmdAdminLogin;
        internal System.Windows.Forms.TextBox TxtAdminPassword;
        internal System.Windows.Forms.TextBox TxtAdminUserName;
    }
}