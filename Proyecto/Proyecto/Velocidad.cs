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
    public partial class Velocidad : MetroForm
    {
        public Velocidad()
        {
            InitializeComponent();
        }

        public Velocidad(MetroFramework.Components.MetroStyleManager StyleManager, int tiempo)
        {
            InitializeComponent();
            this.StyleManager = StyleManager;
            trackBarTime.Value = tiempo;
        }

        private void Velocidad_Load(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
        }
    }
}
