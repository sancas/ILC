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

namespace Proyecto
{
    public partial class VMultiple : MetroForm
    {
        public VMultiple()
        {
            InitializeComponent();
        }

        public VMultiple(string Text, string WaterMark, MetroFramework.Components.MetroStyleManager StyleManager)
        {
            InitializeComponent();
            this.StyleManager = StyleManager;
            this.Text = Text;
            this.txtValor.WaterMark = WaterMark;
        }

        private void VMultiple_Load(object sender, EventArgs e)
        {
            txtValor.Clear();
            txtValor.Focus();
        }
    }
}
