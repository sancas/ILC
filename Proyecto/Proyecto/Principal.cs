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
using Proyecto.Data;
using Proyecto.Properties;

namespace Proyecto
{
    public partial class Principal : MetroForm
    {
        User AuthUser; //Variable que almacenara el usuario logeado
        public Principal()
        {
            //InitializeComponent();
        }

        public Principal(User AuthUser) //Constructor que recibe usuario autenticada como parametro
        {
            this.AuthUser = AuthUser;
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.StyleManager = PrincipalStyleManager;
            this.lblAuthUserEmail.Text = AuthUser.Email;
            this.Text = "Bienvenido " + this.AuthUser.Name.ToString();
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
            else if(AuthUser.Role.Name == "Operator")
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
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 0;
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 1;
        }

        private void btnTravelProblems_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 2;
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 3;
        }
    }
}
