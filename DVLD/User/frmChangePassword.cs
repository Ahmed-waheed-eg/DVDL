using DVLD.Classes;
using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User
{
    public partial class frmChangePassword : Form
    {
        private int _UserID;
        private clsUser _User;

        public frmChangePassword(int UserID )
        {
            InitializeComponent();

            _UserID=UserID;
        }

        private void _ResetDefualtValues()
        {
            txtCurrentPassword1.Text = "";
            txtNewPassword1.Text = "";
            txtConfirmPassword1.Text = "";
            txtCurrentPassword1.Focus(); 
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
             _ResetDefualtValues();

              _User = clsUser.FindByUserID(_UserID);

            if (_User == null)
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Could not Find User with id = " + _UserID,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 this.Close();

                return;

            }
            ctrlUserCard1.LoadUserInfo(_UserID);

        }







        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = txtNewPassword1.Text;

            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully.",
                   "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();
            }
            else
            {
                MessageBox.Show("An Erro Occured, Password did not change.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void txtCurrentPassword1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword1.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword1, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword1, null);
            };

            if (_User.Password != txtCurrentPassword1.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword1, "Current password is wrong!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword1, null);
            };
        }

        private void txtNewPassword1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword1.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword1, "New Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtNewPassword1, null);
            };
        }

        private void txtConfirmPassword1_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword1.Text.Trim() != txtNewPassword1.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword1, "Password Confirmation does not match New Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword1, null);
            };
        }
    }
}
