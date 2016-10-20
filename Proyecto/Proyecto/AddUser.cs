using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Forms;
using Proyecto.Data;

namespace Proyecto
{
    public partial class AddUser : MetroForm
    {
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
            Operaciones OP = new Operaciones();
            if (OP.AgregarUsuario(txtName.Text, txtEmail.Text, "M", txtPassword.Text, int.Parse(cmbUserRol.SelectedValue.ToString())))
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
