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
using MetroFramework.Controls;
using Proyecto.Data;

namespace Proyecto
{
    public partial class NuevoArco : MetroForm
    {
        private int peso;
        private CVertice nodoOrigen;
        private CVertice nodoDestino;
        public NuevoArco(MetroFramework.Components.MetroStyleManager StyleManager, CVertice nodoOrigen = null, CVertice nodoDestino = null)
        {
            InitializeComponent();
            this.StyleManager = StyleManager;
            using (var conexion = new ILC())
            {
                foreach (TravelProblem TravelProblem in conexion.TravelProblems)
                {
                    MetroCheckBox mchkb = new MetroCheckBox();
                    mchkb.Dock = DockStyle.Top;
                    mchkb.AutoSize = true;
                    mchkb.UseStyleColors = true;
                    mchkb.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
                    mchkb.Text = TravelProblem.Name;
                    mchkb.Name = TravelProblem.Peso.ToString();
                    mchkb.CheckedChanged += new System.EventHandler(TravelProblems_CheckedChanged);
                    travelProblems.Controls.Add(mchkb);
                }
            }
            this.nodoOrigen = nodoOrigen;
            this.nodoDestino = nodoDestino;
            peso = 0;
        }

        public void Refresh(List<string> C)
        {
            cmbNodoInicial.Items.Clear();
            cmbNodoFinal.Items.Clear();

            foreach (string miItem in C)
            {
                cmbNodoInicial.Items.Add(miItem);
                cmbNodoFinal.Items.Add(miItem);
            }
            cmbNodoInicial.ResetText();
            cmbNodoFinal.ResetText();
        }

        private void TravelProblems_CheckedChanged(object sender, EventArgs e)
        {
            MetroCheckBox miCheckbox = (MetroCheckBox)sender;
            if (miCheckbox.Checked)
                peso += int.Parse(miCheckbox.Name.ToString());
            else
                peso -= int.Parse(miCheckbox.Name.ToString());
            txtPeso.Text = peso.ToString();
        }

        private void NuevoArco_Load(object sender, EventArgs e)
        {
            if (nodoOrigen != null && nodoDestino != null)
            {
                cmbNodoInicial.SelectedItem = nodoOrigen.Valor;
                cmbNodoFinal.SelectedItem = nodoDestino.Valor;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbNodoInicial.SelectedIndex != -1 && cmbNodoFinal.SelectedIndex != -1 && peso != 0 && cmbNodoInicial.SelectedIndex != cmbNodoFinal.SelectedIndex)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MetroMessageBox.Show(this, "Verfique los datos.\nEl nodo inicial y final deben ser difrentes\nDebe seleccionar un nodo inicial y final\nEl peso no puede ser 0");
        }
    }
}
