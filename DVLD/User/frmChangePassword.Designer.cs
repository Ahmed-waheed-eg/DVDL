namespace DVLD.User
{
    partial class frmChangePassword
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlUserCard1 = new DVLD.Controls.ctrlUserCard();
            this.btnClose1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtConfirmPassword1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPassword1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCurrentPassword1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(942, 413);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 131;
            this.label3.Text = "Confirm Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(942, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 128;
            this.label2.Text = "New Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(942, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 136;
            this.label1.Text = "Current Password:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.Color.White;
            this.ctrlUserCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlUserCard1.Location = new System.Drawing.Point(0, 8);
            this.ctrlUserCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(925, 646);
            this.ctrlUserCard1.TabIndex = 0;
            // 
            // btnClose1
            // 
            this.btnClose1.BorderRadius = 27;
            this.btnClose1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.btnClose1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose1.ForeColor = System.Drawing.Color.White;
            this.btnClose1.Location = new System.Drawing.Point(932, 566);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(250, 65);
            this.btnClose1.TabIndex = 137;
            this.btnClose1.Text = "Close";
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // btnSave1
            // 
            this.btnSave1.BorderRadius = 27;
            this.btnSave1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.btnSave1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave1.ForeColor = System.Drawing.Color.White;
            this.btnSave1.Location = new System.Drawing.Point(1200, 566);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(250, 65);
            this.btnSave1.TabIndex = 138;
            this.btnSave1.Text = "Save";
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // txtConfirmPassword1
            // 
            this.txtConfirmPassword1.BorderColor = System.Drawing.Color.Silver;
            this.txtConfirmPassword1.BorderRadius = 14;
            this.txtConfirmPassword1.BorderThickness = 4;
            this.txtConfirmPassword1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword1.DefaultText = "";
            this.txtConfirmPassword1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtConfirmPassword1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword1.Location = new System.Drawing.Point(947, 443);
            this.txtConfirmPassword1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmPassword1.MaxLength = 50;
            this.txtConfirmPassword1.Name = "txtConfirmPassword1";
            this.txtConfirmPassword1.PasswordChar = '*';
            this.txtConfirmPassword1.PlaceholderText = "";
            this.txtConfirmPassword1.SelectedText = "";
            this.txtConfirmPassword1.Size = new System.Drawing.Size(445, 43);
            this.txtConfirmPassword1.TabIndex = 139;
            this.txtConfirmPassword1.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword1_Validating);
            // 
            // txtNewPassword1
            // 
            this.txtNewPassword1.BorderColor = System.Drawing.Color.Silver;
            this.txtNewPassword1.BorderRadius = 14;
            this.txtNewPassword1.BorderThickness = 4;
            this.txtNewPassword1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword1.DefaultText = "";
            this.txtNewPassword1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassword1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassword1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNewPassword1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword1.Location = new System.Drawing.Point(947, 312);
            this.txtNewPassword1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPassword1.MaxLength = 50;
            this.txtNewPassword1.Name = "txtNewPassword1";
            this.txtNewPassword1.PasswordChar = '*';
            this.txtNewPassword1.PlaceholderText = "";
            this.txtNewPassword1.SelectedText = "";
            this.txtNewPassword1.Size = new System.Drawing.Size(445, 43);
            this.txtNewPassword1.TabIndex = 140;
            this.txtNewPassword1.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword1_Validating);
            // 
            // txtCurrentPassword1
            // 
            this.txtCurrentPassword1.BorderColor = System.Drawing.Color.Silver;
            this.txtCurrentPassword1.BorderRadius = 14;
            this.txtCurrentPassword1.BorderThickness = 4;
            this.txtCurrentPassword1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPassword1.DefaultText = "";
            this.txtCurrentPassword1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrentPassword1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrentPassword1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPassword1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPassword1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCurrentPassword1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPassword1.Location = new System.Drawing.Point(938, 181);
            this.txtCurrentPassword1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurrentPassword1.MaxLength = 50;
            this.txtCurrentPassword1.Name = "txtCurrentPassword1";
            this.txtCurrentPassword1.PasswordChar = '*';
            this.txtCurrentPassword1.PlaceholderText = "";
            this.txtCurrentPassword1.SelectedText = "";
            this.txtCurrentPassword1.Size = new System.Drawing.Size(445, 43);
            this.txtCurrentPassword1.TabIndex = 141;
            this.txtCurrentPassword1.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPassword1_Validating);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Panel2.BorderRadius = 35;
            this.guna2Panel2.BorderThickness = 3;
            this.guna2Panel2.Controls.Add(this.lblTitle);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Panel2.Location = new System.Drawing.Point(947, 12);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(515, 87);
            this.guna2Panel2.TabIndex = 142;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(43, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(428, 50);
            this.lblTitle.TabIndex = 89;
            this.lblTitle.Text = "Change Password";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1474, 712);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.txtCurrentPassword1);
            this.Controls.Add(this.txtNewPassword1);
            this.Controls.Add(this.txtConfirmPassword1);
            this.Controls.Add(this.btnSave1);
            this.Controls.Add(this.btnClose1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlUserCard1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlUserCard ctrlUserCard1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button btnSave1;
        private Guna.UI2.WinForms.Guna2Button btnClose1;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword1;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentPassword1;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblTitle;
    }
}