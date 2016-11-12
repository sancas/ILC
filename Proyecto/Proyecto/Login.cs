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
                string hashedPassword = Operaciones.CalculateMD5Hash(this.txtPassword.Text);
                User AuthUser = conexion.Users.Where(u => u.Email == this.txtEmail.Text && u.Password == hashedPassword).FirstOrDefault();
                if (AuthUser != null)
                {
                    this.Hide();
                    if (AuthUser.Role.Name == "Admin")
                    {
                        Principal frmPrincipal = new Principal(AuthUser);
                        frmPrincipal.ShowDialog(this);
                    }
                    else
                    {
                        Graficador frmGraficador = new Graficador(AuthUser);
                        frmGraficador.ShowDialog(this);
                    }
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

        private void Login_Load(object sender, EventArgs e)
        {
            this.StyleManager = LoginStyleManager;
            this.ActiveControl = txtEmail;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAceptar.PerformClick();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
