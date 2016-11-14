using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using MetroFramework;
using Proyecto.Data;

namespace Proyecto
{
    public partial class AddRole : MetroForm
    {
        private User AuthUser;
        public AddRole()
        {
            InitializeComponent();
        }

        public AddRole(User AuthUser, MetroFramework.Components.MetroStyleManager StyleManager)
        {
            if (AuthUser.Role.Name == "Admin")
            {
                InitializeComponent();
                this.StyleManager = StyleManager;
                this.AuthUser = AuthUser;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Operaciones OP = new Operaciones(AuthUser);
            if (OP.AgregarRole(txtRole.Text))
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
