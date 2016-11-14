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
using MetroFramework;

namespace Proyecto
{
    public partial class AddTravelProblem : MetroForm
    {
        private User AuthUser;
        public AddTravelProblem()
        {
            InitializeComponent();
        }

        public AddTravelProblem(User AuthUser, MetroFramework.Components.MetroStyleManager StyleManager)
        {
            if (AuthUser.Role.Name == "Admin")
            {
                InitializeComponent();
                this.StyleManager = StyleManager;
                this.AuthUser = AuthUser;
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Operaciones OP = new Operaciones(AuthUser);
            int peso;
            int.TryParse(txtPeso.Text, out peso);
            if (OP.AgregarTravelProblem(txtNombre.Text, peso))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MetroMessageBox.Show(this, "No se pudo agregar el problema, el peso no puede ser 0 ni estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
