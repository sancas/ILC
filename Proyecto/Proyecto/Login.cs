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

namespace Proyecto
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (var conexion = new ILC())
            {
                User AuthUser = conexion.Users.Where(u => u.Email == this.txtEmail.Text && u.Password == this.txtPassword.Text).FirstOrDefault();
                if (AuthUser != null)
                {
                    this.Hide();
                    //Lanzar formulario principal pasando el usuario como parametro
                    ClearData();
                    this.Show();
                    this.Focus();
                }
                else
                    MetroMessageBox.Show(this, "Verifique sus datos de inicio de sesion", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.txtEmail.Focus();
            }
        }

        private void ClearData()
        {
            this.txtEmail.Clear();
            this.txtPassword.Clear();
        }
    }
}
