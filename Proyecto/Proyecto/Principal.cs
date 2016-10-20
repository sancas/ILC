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

namespace Proyecto
{
    public partial class Principal : MetroForm
    {
        User AuthUser; //Variable que almacenara el usuario logeado
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal)); //Variable para obtener los recursos de Principal
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
                    this.avatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AdminMale")));
                }
                else if (AuthUser.Gender == "F")
                {
                    this.avatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AdminFemale")));
                }
            }
            else if(AuthUser.Role.Name == "Operator")
            {
                if (AuthUser.Gender == "M")
                {
                    this.avatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserMale")));
                }
                else if (AuthUser.Gender == "F")
                {
                    this.avatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserFemale")));
                }
            }
        }
    }
}
