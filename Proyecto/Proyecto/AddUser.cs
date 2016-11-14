using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Proyecto.Data;

namespace Proyecto
{
    public partial class AddUser : MetroForm
    {
        private User AuthUser;
        public AddUser()
        {
            //InitializeComponent();
        }

        public AddUser(User AuthUser, MetroFramework.Components.MetroStyleManager StyleManager)
        {
            if (AuthUser.Role.Name == "Admin")
            {
                InitializeComponent();
                this.StyleManager = StyleManager;
                this.AuthUser = AuthUser;
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            using (var conexion = new ILC())
            {
                roleBindingSource.DataSource = conexion.Roles.ToList();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Operaciones OP = new Operaciones(AuthUser);
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPassword.Text) || cmbGender.SelectedIndex == -1 || cmbUserRol.SelectedIndex == -1)
                MetroMessageBox.Show(this, "Verfique que todos los datos se hayan ingresado", "Problema con los datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (OP.AgregarUsuario(txtName.Text, txtUsuario.Text, cmbGender.SelectedItem.ToString().Substring(0, 1), txtPassword.Text, int.Parse(cmbUserRol.SelectedValue.ToString())))
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
