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

namespace Proyecto
{
    public partial class FMultiple : MetroForm
    {
        private bool onlyOne;
        public FMultiple()
        {
            InitializeComponent();
        }

        public FMultiple(string Text, string[] WaterMark, MetroFramework.Components.MetroStyleManager StyleManager, bool onlyOne = false)
        {
            InitializeComponent();
            this.StyleManager = StyleManager;
            this.Text = Text;
            cmbInicial.PromptText = WaterMark[0];
            cmbFinal.PromptText = WaterMark[1];
            this.onlyOne = onlyOne;
            if (onlyOne)
                cmbFinal.Visible = false;
        }

        public void Refresh(List<string> C)
        {
            cmbInicial.Items.Clear();
            cmbFinal.Items.Clear();

            foreach (string miItem in C)
            {
                cmbInicial.Items.Add(miItem);
                cmbFinal.Items.Add(miItem);
            }
            cmbInicial.ResetText();
            cmbFinal.ResetText();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbInicial.SelectedIndex != -1 && cmbFinal.SelectedIndex != -1 && cmbFinal.SelectedIndex != cmbInicial.SelectedIndex)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if(onlyOne && cmbInicial.SelectedIndex != -1)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if(onlyOne)
                MetroMessageBox.Show(this, "Debe seleccionar un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroMessageBox.Show(this, "Verifique que selecciono todos los datos y que no son los mismos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
