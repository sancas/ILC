using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using Proyecto.Data;
using Proyecto.Properties;

namespace Proyecto
{
    public partial class ChangePassword : MetroForm
    {
        private User AuthUser;
        public ChangePassword()
        {
            //InitializeComponent();
        }
        
        public ChangePassword(User AuthUser, MetroFramework.Components.MetroStyleManager StyleManager)
        {
            InitializeComponent();
            this.StyleManager = StyleManager;
            this.AuthUser = AuthUser;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            if (AuthUser.Role.Name == "Admin")
            {
                if (AuthUser.Gender == "M")
                {
                    this.avatarPictureBox.Image = ((System.Drawing.Image)(Resources.AdminMale));
                }
                else if (AuthUser.Gender == "F")
                {
                    this.avatarPictureBox.Image = ((System.Drawing.Image)(Resources.AdminFemale));
                }
            }
            else if (AuthUser.Role.Name == "Operator")
            {
                if (AuthUser.Gender == "M")
                {
                    this.avatarPictureBox.Image = ((System.Drawing.Image)(Resources.UserMale));
                }
                else if (AuthUser.Gender == "F")
                {
                    this.avatarPictureBox.Image = ((System.Drawing.Image)(Resources.UserFemale));
                }
            }
            lblAuthUserId.Text = "ID: " + AuthUser.Id.ToString();
            lblAuthUserEmail.Text = AuthUser.Username;
            lblAuthUserName.Text = AuthUser.Name;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPassword2.Text)
            {
                Operaciones OP = new Operaciones(AuthUser);
                if (OP.UpdatePassword(txtPassword.Text))
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MetroMessageBox.Show(this, "Los passwords no coinciden", "Error password", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
